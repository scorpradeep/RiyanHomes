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

namespace RiyanHomes
{
    public partial class Rerun : Form
    {
        public Rerun()
        {
            InitializeComponent();

            onLoadProgressBar();
        }


        private void onLoadProgressBar()
        {

            Boolean returnFlag = false;
            try
            {
                SqlConnection tSQLConn = new SqlConnection(Constants.DBConnString);
                tSQLConn.Open();
                
                    string sSPName = "usp_RerunRentStatus";
                    SqlCommand lCmd = new SqlCommand(sSPName, tSQLConn);
                    lCmd.CommandType = CommandType.StoredProcedure;

                    lCmd.ExecuteNonQuery();
               
                tSQLConn.Close();

                Status.Text = "Completed";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                returnFlag = false;
            }
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
