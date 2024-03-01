using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraGrid;
using System.IO;
using System.Windows.Forms;

namespace RiyanHomes
{
    class Commons
    {

        public DataTable SqlExecuteToDataSet(string sql)
        {
            DataTable dt = new DataTable(); ;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Constants.DBConnString);
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataReader dRead = cmd.ExecuteReader();
                dt.Load(dRead);

            }
            catch (Exception ex)
            {
                connection.Close();
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable StoredProcedureExecuteToDataTable(string sp, List<SqlParameter> listParameter)
        {
            DataTable dt = new DataTable(); ;
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(Constants.DBConnString);
                connection.Open();

                SqlCommand cmd = new SqlCommand(sp, connection);
                cmd.CommandType = CommandType.StoredProcedure;


                foreach (SqlParameter par in listParameter)
                    cmd.Parameters.Add(par);

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

            }
            catch (Exception ex)
            {
                connection.Close();
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public bool UpdateToTable(string sSPName, List<SqlParameter> listParameter)
        {

            bool returnFlag = false;

            try
            {
                SqlConnection tSQLConn = new SqlConnection(Constants.DBConnString);
                tSQLConn.Open();

                SqlCommand lCmd = new SqlCommand(sSPName, tSQLConn);
                lCmd.CommandType = CommandType.StoredProcedure;


                foreach (SqlParameter par in listParameter)
                    lCmd.Parameters.Add(par);

                SqlParameter parameter = lCmd.Parameters.Add(new SqlParameter("@rdReturnFlag", SqlDbType.VarChar, 200));
                parameter.Direction = ParameterDirection.Output;
                lCmd.ExecuteNonQuery();
                string outResult = parameter.Value.ToString();

                if (outResult.Equals("SUCCESS"))
                {
                    returnFlag = true;
                }
                else
                {
                    MessageBox.Show(outResult);
                    returnFlag = false;
                }
                tSQLConn.Close();
            }


            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                returnFlag = false;
            }
            return returnFlag;
        }

        public SqlParameter getParam(string name, string value)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = name;
            param.SqlDbType = SqlDbType.VarChar;
            param.Value = value;
            return param;
        }
        public void ExportToExcel(DevExpress.XtraGrid.GridControl Grid)
        {
            string xlsExportFile =
               Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
               @"\Downloads\" +
               "output" +
               ".xlsx";
            Grid.ExportToXlsx(xlsExportFile);

            FileInfo fi = new FileInfo(xlsExportFile);
            if (fi.Exists)
            {
                System.Diagnostics.Process.Start(xlsExportFile);
            }
        }
        public void loadDropDown(string sql, DevExpress.XtraEditors.ComboBoxEdit cmb)
        {
            try
            {
                DataTable dt = new Commons().SqlExecuteToDataSet(sql);


                cmb.Properties.Items.Add("");
                foreach (DataRow row in dt.Rows)
                    cmb.Properties.Items.Add(row[0].ToString());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string getStringDate(object sRawDate)
        {

            string sDate = "";
            try
            {
                sDate = Convert.ToDateTime(sRawDate).ToString("MM/dd/yyyy");
            }
            catch (Exception ex) { }

            return sDate;
        }

    }
    }
