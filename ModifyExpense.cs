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
    public partial class ModifyExpense : Form
    {
        string sExpenseDate = "";
        string sExpenseRemarks = "";
        string iAmount = "";
        string sMarkTenent = "";
        string sNoteDesc = "";
        string sMonthYear = "";
        string sID = "";

        public ModifyExpense(string sID)
        {
            this.sID = sID;
            InitializeComponent();
            loadDataFields();
            
            new Commons().loadDropDown("select distinct TenentID from TenentInfo where  COALESCE(EffectiveTo, '') = '' ", MarkTenent);
            new Commons().loadDropDown("SELECT DISTINCT top 10 test = FORMAT(DATEADD(month, 1, MonthYear), 'yyyy-MM') FROM BankTransaction order by FORMAT(DATEADD(month, 1, MonthYear), 'yyyy-MM') DESC", MonthYear);
          
                

            
             
        }

        private void loadDataFields()
        {
            try
            {
                DataTable dt = new Commons().SqlExecuteToDataSet("SELECT * FROM Expense where id_num='" + sID + "'");

                sExpenseDate = Convert.ToDateTime(dt.Rows[0]["ExpenseDate"]).ToString("MM/dd/yyyy");
                //dt.Rows[0]["TransactionDate"]
                sExpenseRemarks = dt.Rows[0]["ExpenseRemarks"].ToString();
                iAmount = dt.Rows[0]["Amount"].ToString();
                sMarkTenent = dt.Rows[0]["TenentMarker"].ToString();
                sNoteDesc = dt.Rows[0]["Note"].ToString();
                sMonthYear = Convert.ToDateTime(dt.Rows[0]["MonthYear"]).ToString("yyyy-MM");

                TransactionId.Text = sID;
                TransactionDate.Text = sExpenseDate;
                Description.Text = sExpenseRemarks;
                
                Amount.Text = iAmount;
                MarkTenent.Text = sMarkTenent;
                NoteDesc.Text = sNoteDesc;
                MonthYear.Text = sMonthYear;


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
            string sExpenseDate = TransactionDate.Text;
            string sExpenseRemarks = Description.Text;
            string iAmount = Amount.Value.ToString();
            string sMarkTenent = MarkTenent.SelectedItem == null ? "" : MarkTenent.SelectedItem.ToString();
            string sNoteDesc = NoteDesc.Text;
            string sMonthYear = MonthYear.SelectedItem.ToString();
            string sId = TransactionId.Text;


            try
            {

                SqlParameter sqlParameter =  new SqlParameter();
                List<SqlParameter> list = new List<SqlParameter>();

                SqlParameter param = new SqlParameter();

                list.Add(new Commons().getParam("@psExpenseDate", sExpenseDate));
                list.Add(new Commons().getParam("@psExpenseRemarks", sExpenseRemarks));
                list.Add(new Commons().getParam("@psPropertyID", ""));
                list.Add(new Commons().getParam("@psAmount", iAmount));
                list.Add(new Commons().getParam("@psTenentMarker", sMarkTenent));
                list.Add(new Commons().getParam("@psNote", sNoteDesc));
                list.Add(new Commons().getParam("@psMonthYear", sMonthYear));
                list.Add(new Commons().getParam("@psAddUpdate", sId));
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
