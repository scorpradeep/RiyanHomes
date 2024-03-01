using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiyanHomes
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            Prathusha.Checked = true;
            Father.Checked = true;
            Pradeep.Checked = true;
            Receivables.Checked = false;
            onLoadDropDown();
            onLoadGrid();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            onLoadGrid();
        }

        private void onLoadDropDown()
        {
            try
            {
                DataTable dt = new Commons().SqlExecuteToDataSet("SELECT DISTINCT FORMAT(MonthYear,'yyyy-MM') FROM BankTransaction order by FORMAT(MonthYear,'yyyy-MM') DESC");

                YearMonth.Text =dt.Rows[0][0].ToString();
                foreach (DataRow row in dt.Rows)
                    YearMonth.Items.Add(row[0].ToString());
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void onLoadGrid()
        {
            string sFilter = YearMonth.Text;
            sFilter = sFilter.Replace("-", "") + "01";
            bool bNet = NetGross.IsOn;
            
            DateTime sDate = DateTime.ParseExact(sFilter, "yyyyMMdd",  CultureInfo.InvariantCulture);

            string sMonth = sDate.Month.ToString();
            string sYear = sDate.Year.ToString();
            
            try
            {
                List<SqlParameter> list = new List<SqlParameter>();

                list.Add(new Commons().getParam("@piMonth", sMonth));
                list.Add(new Commons().getParam("@piYear", sYear));
                list.Add(new Commons().getParam("@boDisplay", "1"));
                list.Add(new Commons().getParam("@boNet", bNet.ToString()));

                DashBoardGrid.DataSource = new Commons().StoredProcedureExecuteToDataTable("usp_GetRentStatus", list);
                DashBoardView.PopulateColumns();
            

                GridColumnSummaryItem item1 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Rent", "Sum={0:n0}");
                item1.Format = new MyFormat();
                GridColumnSummaryItem item2 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RentPaid", "Sum={0:n0}");
                item2.Format = new MyFormat();
                GridColumnSummaryItem item3 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Diff", "Diff={0:n0}");
                item3.Format = new MyFormat();

            
                DashBoardView.Columns["Rent"].Summary.Add(item1);
                DashBoardView.Columns["RentPaid"].Summary.Add(item2);
                DashBoardView.Columns["Diff"].Summary.Add(item3);

                DashBoardView.OptionsView.ShowFooter = true;
            
                string filterString = "";
                if (Pradeep.Checked)
                    filterString = filterString + "[Property] = 'Pradeep' OR ";
                if (Prathusha.Checked)
                    filterString = filterString + "[Property] = 'Prathusha' OR ";
                if (Father.Checked)
                    filterString = filterString + "[Property] = 'Father' OR ";
                if (Receivables.Checked)
                    filterString = filterString + "[Property] = 'Receivable' OR ";
            
                filterString = filterString + "[Property] = '' ";
            
                DashBoardView.Columns["Property"].FilterInfo = new ColumnFilterInfo(filterString);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            new Commons().ExportToExcel(DashBoardGrid);
        }

        private void DashBoardView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if ((e.Column.Name == "colRent")||(e.Column.Name == "colRentPaid") || (e.Column.Name == "colDiff"))
            {
                e.DisplayText = Indianformat.ConvertString(e.Value.ToString());
            }
        }

        private void DashBoardView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string sStatus = DashBoardView.GetRowCellValue(e.RowHandle, "Status")!=null? (DashBoardView.GetRowCellValue(e.RowHandle, "Status")).ToString():"";

            if (sStatus == "Paid")
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
            else if (sStatus == "Over Paid")
            {
                e.Appearance.BackColor = Color.DarkGreen;
                e.Appearance.ForeColor = Color.White;
            }
            else if (sStatus == "Partial Pay")
            {
                e.Appearance.BackColor = Color.Yellow;
                
            }
            else
            {
                e.Appearance.BackColor = Color.Ivory;
            }
            //Override any other formatting  
            e.HighPriority = true;
        }
    }
}
