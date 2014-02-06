using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Baze_de_Date.DMA_DataLayer
{
  public  class DMA_DatalayerClass
    {
        string ConString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
     //string  connStudent = new SqlConnection(ConfigurationManager.AppSettings["connectstring"].ToString());
        DataTable dt = new DataTable();

        SqlDataAdapter myAdapter = new SqlDataAdapter();
        SqlConnection con = new SqlConnection();

        public SqlConnection openConnection()
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConString;
            if (connection.State == ConnectionState.Closed || connection.State ==
                        ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public bool closeConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return true;
        }

        public DataTable Accounts()
        {
            con = openConnection();

            SqlCommand cmd = new SqlCommand("select * from dbo.Accounts", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                return null;
            }
        }


        public bool Login(string username, string password)
        {
            con = openConnection();
            SqlCommand cmd = new SqlCommand("select * from dbo.Accounts where (Username= '" + username + "' and Password= '" + password + "')", con);
           
                SqlDataReader rd = cmd.ExecuteReader();
                  dt.Load(rd);
                if(dt.Rows.Count>0)
               {
                 
                   
                  
                    string a = dt.Rows[0][0].ToString().Trim();
                    string b = dt.Rows[0][1].ToString().Trim();



                    if (a == username && b == password)
                    {
                        MessageBox.Show("Login Succesful!");
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                        return false;
                    }
               }
                    else
               {
                   MessageBox.Show("Invalid Username or Password");
                   return false;
               }

         }


        private bool executeAddNewAccount(string procedure_name, SqlParameter[] SqlParameter)
        {
            SqlCommand comm = new SqlCommand();
            con = openConnection();
            try
            {
                comm.Connection =con;
                comm.CommandText = procedure_name;
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddRange(SqlParameter);
                myAdapter.InsertCommand = comm;
                comm.ExecuteNonQuery();
                //con.Close();
                MessageBox.Show("Registration Succesfull!");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error - Connection unavailable or Insert failed! \nException: ", e.StackTrace.ToString());

                return false;
            }
            finally
            {

            }
            return false;
        }

        public bool RegisterAccount(String data_username, String data_password, string pass2)
        {
            if (data_password != pass2)
            {
                MessageBox.Show("The passwords do not match!");
                return false;
            }
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@username", data_username);
            sqlParameters[1] = new SqlParameter("@password", data_password);
           


            return executeAddNewAccount("RegisterAccount", sqlParameters);
        }

      }//end class
  
}//end namespace
