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
    public partial class ModifyDeal : Form
    {

        string sType = "";
        string sLocation = "";
        string sTenentId = "";
        string sEffectiveFrom = "";
        string sEffectiveTo = "";
        string sAddress = "";
        string sPhone = "";
        string sEmail = "";
        string sRent = "";
        string sName = "";
        string sID = "";
        string sRenualDate = "";
        string sRenualPerOrAmount = "";
        string sPropertyID = "";
        string sDealType = "";

        public ModifyDeal(string sID)
        {
            this.sID = sID;
            InitializeComponent();
            loadDataFields();
            onLoadDropDown();
            
        }

        private void loadDataFields()
        {
            try
            {
                DataTable dt = new Commons().SqlExecuteToDataSet("SELECT * FROM TenentInfo where ID='" + sID + "'");

                sType = dt.Rows[0]["Type"].ToString();
                sLocation = dt.Rows[0]["Location"].ToString();
                sTenentId = dt.Rows[0]["TenentID"].ToString();
                sEffectiveFrom = Commons.getStringDate(dt.Rows[0]["EffectiveFrom"]);
                sEffectiveTo = Commons.getStringDate(dt.Rows[0]["EffectiveTo"]);
                sAddress = dt.Rows[0]["Address"].ToString();
                sPhone = dt.Rows[0]["Phone"].ToString();
                sEmail = dt.Rows[0]["Email"].ToString();
                sRent = dt.Rows[0]["Rent"].ToString();
                sName = dt.Rows[0]["Name"].ToString();
                sRenualDate = Commons.getStringDate(dt.Rows[0]["RenualDate"]);
                sRenualPerOrAmount = dt.Rows[0]["RenualPerOrAmount"].ToString();
                sPropertyID= dt.Rows[0]["PropertyID"].ToString();
                sDealType = dt.Rows[0]["DealType"].ToString();

                TenentId.Text = sID;
                Type.Text = sType;
                Location.Text = sLocation;
                Address.Text = sAddress;
                Name.Text = sName;
                Description.Text = sTenentId;
                EffectiveFrom.Text = sEffectiveFrom;
                EffectiveTo.Text = sEffectiveTo;
                Phone.Text = sPhone;
                Email.Text = sEmail;
                Rent.Text = sRent;
                RenualDate.Text = sRenualDate;
                RenualRate.Text = sRenualPerOrAmount;
                PropertyId.Text = sPropertyID;
                DealType.Text = sDealType;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

       

        private void onLoadDropDown()
        {
            new Commons().loadDropDown("select distinct Type from TenentInfo", Type);
            new Commons().loadDropDown("select distinct Location from TenentInfo", Location);
            new Commons().loadDropDown("select distinct PropertyID from ProperyInfo", PropertyId);
        }
        
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

            sType = Type.Text;
            sLocation = Location.Text;
            sTenentId = Description.Text;
            sEffectiveFrom = EffectiveFrom.Text;
            sEffectiveTo = EffectiveTo.Text;
            sAddress = Address.Text;
            sPhone = Phone.Text;
            sEmail = Email.Text;
            sRent = Rent.Text;
            sName = Name.Text;
            sID = TenentId.Text;
            sRenualDate = RenualDate.Text;
            sRenualPerOrAmount = RenualRate.Text;
            sPropertyID = PropertyId.Text;
            sDealType = DealType.Text;

            try
            {

                SqlParameter sqlParameter = new SqlParameter();
                List<SqlParameter> list = new List<SqlParameter>();

                SqlParameter param = new SqlParameter();

                list.Add(new Commons().getParam("@psType", sType));
                list.Add(new Commons().getParam("@psLocation", sLocation));
                list.Add(new Commons().getParam("@psTenentId", sTenentId));
                list.Add(new Commons().getParam("@psEffectiveFrom", sEffectiveFrom));
                list.Add(new Commons().getParam("@psEffectiveTo", sEffectiveTo));
                list.Add(new Commons().getParam("@psAddress", sAddress));
                list.Add(new Commons().getParam("@psPhone", sPhone));
                list.Add(new Commons().getParam("@psEmail", sEmail));
                list.Add(new Commons().getParam("@psRent", sRent));
                list.Add(new Commons().getParam("@psName", sName));
                list.Add(new Commons().getParam("@psRenualDate", sRenualDate));
                list.Add(new Commons().getParam("@psRenualPerOrAmount", sRenualPerOrAmount));
                list.Add(new Commons().getParam("@psID", sID));
                list.Add(new Commons().getParam("@psOperation", "UPDATE"));
                list.Add(new Commons().getParam("@psPropertyID", sPropertyID));
                list.Add(new Commons().getParam("@psDealType", sDealType));
                bool bFlag = new Commons().UpdateToTable("usp_AddUpdateTenentDeal", list);
                if (bFlag)
                    DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
