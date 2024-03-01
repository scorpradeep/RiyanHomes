using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Microsoft.Office;
using System.IO;
using DevExpress.XtraGrid;

namespace RiyanHomes
{
    public partial class Terminated : Form
    {

        DataNavigator dataNav;
        DataView dvMain;
        DataView dvDropDown;

        public Terminated()
        {
            InitializeComponent();


            gridLookup.Bounds = new Rectangle(10, 40, 200, 20);
            this.Controls.Add(gridLookup);

            dataNav = new DataNavigator();
            dataNav.Bounds = new Rectangle(10, 10, 250, 20);
            this.Controls.Add(dataNav);

            dropdown();
             InitLookUp();


            onLoadGrid();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Constants.DBConnString);
            DialogResult = DialogResult.OK;
        }

        private void InitLookUp()
        {

            gridLookup.DataBindings.Add("EditValue", dvMain, "TenentID");


            gridLookup.Properties.PopupView.OptionsBehavior.AutoPopulateColumns = false;
            gridLookup.Properties.DataSource = dvDropDown;
            gridLookup.Properties.DisplayMember = "TenentID";

            gridLookup.Properties.ValueMember = "TenentID";

            //GridColumn col1 = gridLookup.Properties.PopupView.Columns.AddField("ID");
            //col1.VisibleIndex = 0;
            //col1.Caption = "ID";
            // A column to display the values of the ProductName field.
            GridColumn col2 = gridLookup.Properties.PopupView.Columns.AddField("TenentID");
            col2.VisibleIndex = 1;
            col2.Caption = "TenentID";

            // Set column widths according to their contents.
            //gridLookup.Properties.PopupView.CalcColumnBestWidth();
            // Specify the total dropdown width.
            gridLookup.Properties.PopupFormWidth = 300;
        }

        public void dropdown()
        {
            try
            {

                List<SqlParameter> list = new List<SqlParameter>();

                //DataTable dt = new Commons().StoredProcedureExecuteToDataTable("usp_GetTenentInfo", list);
                DataTable dt = new Commons().StoredProcedureExecuteToDataTable("usp_GetTerminatedTenentInfo", list);
                dt.TableName = "Terminated";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                DataViewManager dvm = new DataViewManager(ds);
                dvMain = dvm.CreateDataView(ds.Tables["Terminated"]);
                dvDropDown = dvm.CreateDataView(ds.Tables["Terminated"]);

            }
            catch (Exception e)
            {
            }
            finally
            {
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

            try
            {
                onLoadGrid();
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

                DevExpress.XtraGrid.Views.Grid.GridView view = gridLookup.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
                string descrip = view.GetRowCellValue(view.FocusedRowHandle, "TenentID").ToString();


                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new Commons().getParam("@psTenentID", descrip));

                DataTable dt = new Commons().StoredProcedureExecuteToDataTable("usp_GetPaymentDeatilsByTenentID", list);
                dt.TableName = "Terminated";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                DealGridControl.DataSource = dt;
                DealGridView.PopulateColumns();

                GridColumnSummaryItem item1 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Rent", "Sum={0:n0}");
                item1.Format = new MyFormat();
                GridColumnSummaryItem item2 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Paid", "Sum={0:n0}");
                item2.Format = new MyFormat();

                DealGridView.Columns["Rent"].Summary.Add(item1);
                DealGridView.Columns["Paid"].Summary.Add(item2);

                DealGridView.OptionsView.ShowFooter = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            new Commons().ExportToExcel(DealGridControl);
        }

        private void DealGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if ((e.Column.Name == "colRent" || e.Column.Name == "colPaid"))
            {
                e.DisplayText = Indianformat.ConvertString(e.Value.ToString());
            }
        }

        private void DealGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string sStatus = DealGridView.GetRowCellValue(e.RowHandle, "Status") != null ? (DealGridView.GetRowCellValue(e.RowHandle, "Status")).ToString() : "";

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

        private void gridLookup_MouseClick(object sender, MouseEventArgs e)
        {
            InitLookUp();
        }
    }
}
