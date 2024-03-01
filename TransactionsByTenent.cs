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
    public partial class TransactionsByTenent : Form
    {
        public TransactionsByTenent()
        {
            InitializeComponent();
            new Commons().loadDropDown("select distinct TenentID from TenentInfo where  COALESCE(EffectiveTo, '') = ''", YearMonth);
            onLoadGrid();
        }

        private void Search_Click(object sender, EventArgs e)
        {

            string sFilter = YearMonth.Text;
            try
            {
                TransactionGrid.DataSource = new Commons().SqlExecuteToDataSet("SELECT * FROM BankTransaction WHERE TenentMarker = '" + sFilter + "' ORDER BY TransactionDate DESC");
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
                TransactionGrid.DataSource = new Commons().SqlExecuteToDataSet("select * from BankTransaction");
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
    }
}
