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

namespace RiyanHomes
{
    public partial class Deals : Form
    {
        
        DataNavigator dataNav;
        DataView dvMain;
        DataView dvDropDown;

        public Deals()
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
            // Bind the edit value to the ProductID field of the "Order Details" table;
            // the edit value matches the value of the ValueMember field.
            gridLookup.DataBindings.Add("EditValue", dvMain, "TenentID");

            // Prevent columns from being automatically created when a data source is assigned.
            gridLookup.Properties.PopupView.OptionsBehavior.AutoPopulateColumns = false;
            // The data source for the dropdown rows
            gridLookup.Properties.DataSource = dvDropDown;
            // The field for the editor's display text.
            gridLookup.Properties.DisplayMember = "TenentID";
            // The field matching the edit value.
            gridLookup.Properties.ValueMember = "TenentID";

            // Add two columns in the dropdown:
            // A column to display the values of the ProductID field;
            GridColumn col1 = gridLookup.Properties.PopupView.Columns.AddField("ID");
            col1.VisibleIndex = 0;
            col1.Caption = "ID";
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

                DataTable dt = new Commons().StoredProcedureExecuteToDataTable("usp_GetTenentInfo", list);
                dt.TableName = "Deals";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                DataViewManager dvm = new DataViewManager(ds);
                dvMain = dvm.CreateDataView(ds.Tables["Deals"]);
                dvDropDown = dvm.CreateDataView(ds.Tables["Deals"]);

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

                DataTable dt = new Commons().StoredProcedureExecuteToDataTable("usp_GetTenentInfo", list);
                dt.TableName = "Deals";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                DealGridControl.DataSource = dt;//new Commons().SqlExecuteToDataSet("select * from TenentInfoView where TenentID='" + descrip + "'");
                DealGridView.PopulateColumns();

                //DealGridView.Columns["Rent"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                //DealGridView.Columns["Rent"].DisplayFormat.FormatString =  "c2";


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

        private void Modify_Click(object sender, EventArgs e)
        {

            int index = DealGridView.GetFocusedDataSourceRowIndex();
            DataTable dt = DealGridView.GridControl.DataSource as DataTable;
            
            ModifyDeal mod = new ModifyDeal(dt.Rows[index]["ID"].ToString());
            if (mod.ShowDialog() == DialogResult.OK)
            {
                mod.Enabled = false;
                onLoadGrid();
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            int index = DealGridView.GetFocusedDataSourceRowIndex();
            DataTable dt = DealGridView.GridControl.DataSource as DataTable;

            CopyDeal cop = new CopyDeal(dt.Rows[index]["ID"].ToString());
            if (cop.ShowDialog() == DialogResult.OK)
            {
                cop.Enabled = false;
                onLoadGrid();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddDeal mod = new AddDeal();
            if (mod.ShowDialog() == DialogResult.OK)
            {
                mod.Enabled = false;
                onLoadGrid();
            }
        }

        private void DealGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if ((e.Column.Name == "colRent"))
            {
                e.DisplayText = Indianformat.ConvertString(e.Value.ToString());
            }
        }
    }
}
