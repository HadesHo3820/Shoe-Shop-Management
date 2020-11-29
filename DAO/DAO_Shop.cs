using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Shop
    {
        SqlConnection cnn = null;

        public DataTable loadShop()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "Select Address from Shops where Status = 'On' ";
                cnn = DataProvider.ConnectData();
                dt = DataProvider.Load_database(sql, cnn);
                cnn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
