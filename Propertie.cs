using DevExpress.XtraEditors.Repository;
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
    public partial class Propertie : Form
    {
        public Propertie()
        {
            InitializeComponent();
            new Commons().loadDropDown("SELECT DISTINCT FORMAT(MonthYear,'yyyy-MM') FROM BankTransaction order by FORMAT(MonthYear,'yyyy-MM') DESC", YearMonth);
            loadGrid();
        }

        private void loadGrid()
        {
            DataTable dt = new DataTable();

            string sDate;

            if (YearMonth.Text == "")
            {
                sDate = DateTime.Now.ToShortDateString();
            }
            else
            {
                sDate = YearMonth.Text + "-01";
                sDate = sDate.Replace("-", "");
                sDate = DateTime.ParseExact(sDate, "yyyyMMdd", null).ToShortDateString();
            }
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new Commons().getParam("@ldFromDate", sDate));
            list.Add(new Commons().getParam("@psStatus", "ALL"));

            dt = new Commons().StoredProcedureExecuteToDataTable("usp_GetPropertyInfo", list);

            vGridControl1.DataSource = dt;
            vGridControl1.Rows[0].Appearance.BackColor = Color.Azure;

            //RepositoryItemProgressBar ritem = new RepositoryItemProgressBar();
            //ritem.Minimum = 0;
            //ritem.Maximum = 100;
            //vGridControl1.RepositoryItems.Add(ritem);

            ////var edit = new RepositoryItemProgressBar();
            ////gridControl.RepositoryItems.Add(edit);
            ////gridView.Columns["Progress"].ColumnEdit = edit;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void vGridControl1_CustomDrawRowValueCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e)
        {
            string s = e.CellText;
            int ind = e.RecordIndex;

            if (s.Contains("Rem-"))
            {
                int i = Int16.Parse(s.Replace("Rem-", ""));
                switch (i)
                {
                    case 0:
                        e.Appearance.BackColor = Color.MediumVioletRed;
                        break;
                    case 1:
                        e.Appearance.BackColor = Color.Crimson;
                        break;
                    case 2:
                        e.Appearance.BackColor = Color.DeepPink;
                        break;
                    case 3:
                        e.Appearance.BackColor = Color.Chocolate;
                        break;
                    case 4:
                        e.Appearance.BackColor = Color.Coral;
                        break;
                    case 5:
                        e.Appearance.BackColor = Color.Gold;
                        break;
                    case 6:
                        e.Appearance.BackColor = Color.Orange;
                        break;
                    case 7:
                        e.Appearance.BackColor = Color.Khaki;
                        break;
                    case 8:
                        e.Appearance.BackColor = Color.LightYellow;
                        break;
                    case 9:
                        e.Appearance.BackColor = Color.MintCream;
                        break;
                    case 10:
                        e.Appearance.BackColor = Color.Ivory;
                        break;
                    case 11:
                        e.Appearance.BackColor = Color.FloralWhite;
                        break;
                    case 12:
                        e.Appearance.BackColor = Color.LightSeaGreen;
                        break;
                    default:
                        e.Appearance.BackColor = Color.Black;
                        break;
                }


            }


            }
    }
}
