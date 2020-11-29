using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection ConnectData()
        {
            try
            {
                string strcnn = "Server=.;database=ShoeShopManager;uid=sa;pwd=123456";
                SqlConnection cnn = new SqlConnection(strcnn);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
  
        public static DataTable Load_database(string strSql, SqlConnection cnn)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, cnn);
            da.Fill(dt);
            return dt;
        }

        
        public static void Execute(SqlConnection cnn, string strMysql)
        {
            SqlCommand cmd = new SqlCommand(strMysql, cnn);
            cmd.ExecuteNonQuery();
        }
    }
}
