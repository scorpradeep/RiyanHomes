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
    public partial class SearchTransactions : Form
    {
        public SearchTransactions()
        {
            InitializeComponent();
            
            onLoadGrid();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string sFilter = SearchText.Text;


            try
            {
                string stest = "SELECT * FROM BankTransaction WHERE  TransactionRemarks like '%"+ sFilter + "%' ORDER BY TransactionDate DESC";
                TransactionGrid.DataSource = new Commons().SqlExecuteToDataSet(stest);
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

       
        private void onLoadGrid()
        {
            try
            {
                string sFilter = SearchText.Text;
                if (sFilter == "")
                    return;
                TransactionGrid.DataSource = new Commons().SqlExecuteToDataSet("SELECT * FROM BankTransaction WHERE  TransactionRemarks like '%" + sFilter + "%' ORDER BY TransactionDate DESC");
                
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

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            new Commons().ExportToExcel(TransactionGrid);
        }

        private void TranGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if ((e.Column.Name == "colAmount"))
            {
                e.DisplayText = Indianformat.ConvertString(e.Value.ToString());
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
 
            int index = TranGridView.GetFocusedDataSourceRowIndex();
            DataTable dt = TranGridView.GridControl.DataSource as DataTable;

            ModifyTransaction mod = new ModifyTransaction(dt.Rows[index]["id_num"].ToString());
            if (mod.ShowDialog() == DialogResult.OK)
            {
                mod.Enabled = false;
                onLoadGrid();
            }
        }
    }
}
