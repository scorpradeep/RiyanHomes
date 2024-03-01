using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiyanHomes
{
    public partial class Status : Form
    {

        DataNavigator dataNav;
        DataView dvMain;
        DataView dvDropDown;

        public Status()
        {
            InitializeComponent();

            gridLookup.Bounds = new Rectangle(10, 40, 200, 20);
            this.Controls.Add(gridLookup);

            dataNav = new DataNavigator();
            dataNav.Bounds = new Rectangle(10, 10, 250, 20);
            this.Controls.Add(dataNav);

            dropdown();
            InitLookUp();
            //progressBar1
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
                dt.TableName = "History";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                DataViewManager dvm = new DataViewManager(ds);
                dvMain = dvm.CreateDataView(ds.Tables["History"]);
                dvDropDown = dvm.CreateDataView(ds.Tables["History"]);

            }
            catch (Exception e)
            {
            }
            finally
            {
            }
        }
    }
}
