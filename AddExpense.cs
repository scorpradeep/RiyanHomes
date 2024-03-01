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
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
            onLoadTenentDropDown();
            onLoadMonthDropDown();
            
        }
        private void onLoadTenentDropDown()
        {
            try
            {
                DataTable dt = new Commons().SqlExecuteToDataSet("select distinct TenentId from TenentInfo where  COALESCE(EffectiveTo, '') = '' ");

                
                MarkTenent.Properties.Items.Add("");
                foreach (DataRow row in dt.Rows)
                    MarkTenent.Properties.Items.Add(row[0].ToString());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private void onLoadMonthDropDown()
        {
            try
            {
                DataTable dt = new Commons().SqlExecuteToDataSet("SELECT DISTINCT top 10 test =FORMAT(DATEADD(month,1,MonthYear),'yyyy-MM') FROM BankTransaction order by FORMAT(DATEADD(month,1,MonthYear),'yyyy-MM') DESC");

                foreach (DataRow row in dt.Rows)
                MonthYear.Properties.Items.Add(row[0].ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string sExpenseDate = ExpenseDate.Text;
            string sExpenseRemarks = ExpenseRemarks.Text;
            
            string iAmount = Amount.Value.ToString();
            string sMarkTenent = MarkTenent.SelectedItem==null?"":MarkTenent.SelectedItem.ToString();
            string sNoteDesc = NoteDesc.Text;
            string sMonthYear = MonthYear.SelectedItem.ToString();

            
            try
            {

                SqlParameter sqlParameter =  new SqlParameter();
                List<SqlParameter> list = new List<SqlParameter>();

                SqlParameter param = new SqlParameter();
                //param.ParameterName = "@psTransactionDate";
                //param.SqlDbType = SqlDbType.VarChar;
                //param.Value = sTransactionDate;

                list.Add(new Commons().getParam("@psExpenseDate", sExpenseDate));
                list.Add(new Commons().getParam("@psExpenseRemarks", sExpenseRemarks));
                list.Add(new Commons().getParam("@psPropertyID", ""));
                list.Add(new Commons().getParam("@psAmount", iAmount));
                list.Add(new Commons().getParam("@psTenentMarker", sMarkTenent));
                list.Add(new Commons().getParam("@psNote", sNoteDesc));
                list.Add(new Commons().getParam("@psMonthYear", sMonthYear));
                list.Add(new Commons().getParam("@psAddUpdate", "0"));
                list.Add(new Commons().getParam("@psProperty", ""));

                bool bFlag=  new Commons().UpdateToTable("usp_AddUpdateExpense", list);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
