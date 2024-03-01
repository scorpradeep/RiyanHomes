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
    public partial class FirmIncome : Form
    {
        public FirmIncome()
        {
            InitializeComponent();
            Prathusha.Checked = true;
            Father.Checked = true;
            Pradeep.Checked = true;
            Receivables.Checked = false;
            
            //onLoadGrid();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            onLoadGrid();
        }
 
        private void onLoadGrid()
        {
            string sFrom = FromDate.Text;
            string sTo = ToDate.Text;
            bool bNet = NetGross.IsOn;
            
            
            try
            {
                List<SqlParameter> list = new List<SqlParameter>();


                string filterString = "";
                if (Pradeep.Checked)
                    filterString = filterString + "Pradeep,";
                if (Prathusha.Checked)
                    filterString = filterString + "Prathusha,";
                if (Father.Checked)
                    filterString = filterString + "Father,";
                if (Receivables.Checked)
                    filterString = filterString + "Receivable,";

                filterString = filterString + "";

                list.Add(new Commons().getParam("@ldFromDate", sFrom));
                list.Add(new Commons().getParam("@ldToDate", sTo));
                list.Add(new Commons().getParam("@boNet", bNet.ToString()));
                list.Add(new Commons().getParam("@ldProperty", filterString.ToString()));

                DataTable dds = new Commons().StoredProcedureExecuteToDataTable("usp_GetFirmRentForRange", list);

                DashBoardGrid.DataSource = dds;
                DashBoardView.PopulateColumns();



                GridColumnSummaryItem item2 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Paid", "Sum={0:n0}");
                item2.Format = new MyFormat();



                  DashBoardView.Columns["Paid"].Summary.Add(item2);


                DashBoardView.OptionsView.ShowFooter = true;
            
               
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
            if (e.Column.Name == "colPaid")
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
