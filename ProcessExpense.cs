using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiyanHomes
{
    public partial class ProcessExpense : Form
    {
        public ProcessExpense()
        {
            InitializeComponent();
            onLoadDropDown();
            
        }

        private void Search_Click(object sender, EventArgs e)
        {

            string sFilter = YearMonth.Text;
            try
            {
                TransactionGrid.DataSource =
                    sFilter=="ALL"?
                    new Commons().SqlExecuteToDataSet("SELECT * FROM Expense ORDER BY ExpenseDate DESC")
                    :
                new Commons().SqlExecuteToDataSet("SELECT * FROM Expense WHERE FORMAT(MonthYear,'yyyy-MM')='" + sFilter + "' ORDER BY ExpenseDate DESC");
                TranGridView.PopulateColumns();

                GridColumnSummaryItem item1 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "Sum={0:n0}");
                item1.Format = new MyFormat();
                TranGridView.Columns["Amount"].Summary.Add(item1);
                TranGridView.OptionsView.ShowFooter = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void onLoadDropDown()
        {
            try
            {
                DataTable dt = new Commons().SqlExecuteToDataSet("SELECT DISTINCT FORMAT(MonthYear,'yyyy-MM') FROM BankTransaction order by FORMAT(MonthYear,'yyyy-MM') DESC");

                YearMonth.Items.Add("ALL");
                foreach (DataRow row in dt.Rows)
                    YearMonth.Items.Add(row[0].ToString());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            new Commons().ExportToExcel(TransactionGrid);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddExpense add = new AddExpense();
            if (add.ShowDialog() == DialogResult.OK)
            {
                add.Enabled = false;
                onLoadGrid();
            }
        }

        private void onLoadGrid()
        {
            try
            {
                string sFilter = YearMonth.Text;
                TransactionGrid.DataSource =
                    sFilter != "" ?
                                new Commons().SqlExecuteToDataSet("SELECT * FROM Expense WHERE FORMAT(MonthYear,'yyyy-MM')='" + sFilter + "' ORDER BY ExpenseDate DESC")
                                :
                                new Commons().SqlExecuteToDataSet("select * from Expense order by ModifiedDate desc");

                TranGridView.PopulateColumns();

                GridColumnSummaryItem item1 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "Sum={0:n0}");
                item1.Format = new MyFormat();
                TranGridView.Columns["Amount"].Summary.Add(item1);
                TranGridView.OptionsView.ShowFooter = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {

            int index = TranGridView.GetFocusedDataSourceRowIndex();
            DataTable dt = TranGridView.GridControl.DataSource as DataTable;
            //DataRow dr= dt.Rows[index];



            ModifyExpense mod = new ModifyExpense(dt.Rows[index]["id_num"].ToString());
            if (mod.ShowDialog() == DialogResult.OK)
            {
                mod.Enabled = false;
                onLoadGrid();
            }
        }

        private void TranGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if ((e.Column.Name == "colAmount"))
            {
                e.DisplayText = Indianformat.ConvertString(e.Value.ToString());
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            int index = TranGridView.GetFocusedDataSourceRowIndex();
            DataTable dt = TranGridView.GridControl.DataSource as DataTable;


            CopyExpense cpy = new CopyExpense(dt.Rows[index]["id_num"].ToString());
            if (cpy.ShowDialog() == DialogResult.OK)
            {
                cpy.Enabled = false;
                onLoadGrid();
            }
        }
    }
}
