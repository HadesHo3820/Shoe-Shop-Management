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
    
    public class DAO_ProductType
    {
        private SqlConnection cnn = null;

        public  DataTable loadProType()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select pt.IDProductType,  pt.NameProductType, pl.NameProductlines , pt.Quantity from ProductTypes pt, Productlines pl where pt.IDProductlines = pl.IDProductlines and pt.Status = 'On'";
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

        public bool addProType(DTO_ProductType proType)
        {
            string sql = string.Format("Insert into ProductTypes values('{0}', (select IDProductlines from Productlines  where NameProductlines = '{1}' ), '{2}', '{3}', 'On')", proType.IDProductType, proType.IDProductlines,proType.NameProductType,proType.Quantity);
            cnn = DataProvider.ConnectData();
            SqlCommand command = new SqlCommand(sql, cnn);
            int row = command.ExecuteNonQuery();
            cnn.Close();
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        public bool updateProType(DTO_ProductType proType)
        {
            string sql = string.Format("Update ProductTypes set IDProductlines = (select IDProductlines from Productlines  where NameProductlines = '{0}') , NameProductType = '{1}' where IDProductType = '{2}'", proType.IDProductlines, proType.NameProductType, proType.IDProductType);
            cnn = DataProvider.ConnectData();
            SqlCommand command = new SqlCommand(sql, cnn);
            int row = command.ExecuteNonQuery();
            cnn.Close();
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        public bool deleteProType(String idProType)
        {
            string sql = string.Format("Update ProductTypes set Status = 'On' where IDProductType = '{0}'", idProType);
            cnn = DataProvider.ConnectData();
            SqlCommand command = new SqlCommand(sql, cnn);
            int row = command.ExecuteNonQuery();
            cnn.Close();
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        public bool checkProType(string idProType)
        {
            bool result = false;
            string sql = string.Format("select IDProductType from ProductTypes where IDProductType = '{0}' ", idProType);
            cnn = DataProvider.ConnectData();
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                return true;
            }
            return result;
        }
    }
}
