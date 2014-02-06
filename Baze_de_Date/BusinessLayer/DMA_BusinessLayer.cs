using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using Baze_de_Date.DMA_DataLayer;


namespace Baze_de_Date.DMA_BusinessLayer
{
    class DMA_BusinessLayerClass
    {

        public bool ModifyAbout(string user, string birth, string gender, string interest, string city, string religion, string relationship)
        {
            DMA_DatalayerClass objdata = new DMA_DatalayerClass();
            return objdata.ModifyAbout(user, birth, gender, interest, city, religion, relationship);
        }

        public DataTable About(string username)
        {
            DMA_DatalayerClass objdata = new DMA_DatalayerClass();
            return objdata.About(username);
        }

        public bool LoginUser(string username, string password)
        {


            DMA_DatalayerClass objdata = new DMA_DatalayerClass();
            return objdata.Login(username, password);

        }

        public bool AddNewAccount_BL(String username, String password, string pass2)
        {

            DMA_DatalayerClass objdata = new DMA_DatalayerClass();
            DataTable dt = objdata.Accounts();
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    string _user = row[0].ToString().Trim();
                    if (_user == username)
                        throw new DataException("Error");
                }
            }
            catch
            {
                MessageBox.Show("That username is already in the database!");
                return false;
            }

            return objdata.RegisterAccount(username, password, pass2);
        }



    }
}
