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
    public class DAO_Product
    { 
        private static SqlConnection cnn = null;


        public static DataTable loadProduct()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select p.IDProduct,pt.NameProductType,p.NameProduct,p.Size,p.Quantity,p.Price,p.Discount from Products p, ProductTypes pt where p.IDProductType = pt.IDProductType and p.Status = 'On' ";
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

        public static bool checkID(string id)
        {
            bool check = false;
            string sql = string.Format("Select s.IDProduct from Products s where Status = 'On' and s.IDProduct = '{0}'", id);
            cnn = DataProvider.ConnectData();
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                check = true;
            }
            return check;
        }

        public static DataTable loadProByName(string proName)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = string.Format("select p.IDProduct,pt.NameProductType,p.NameProduct,p.Size,p.Quantity,p.Price,p.Discount from ProductTypes pt, Products p where p.IDProductType = pt.IDProductType and p.NameProduct like '%{0}%'", proName);
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

        public static DataTable loadProByType(string proType)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = string.Format("select p.IDProduct,pt.NameProductType,p.NameProduct,p.Size,p.Quantity,p.Price,p.Discount from ProductTypes pt, Products p where p.IDProductType = pt.IDProductType and pt.NameProductType like '%{0}%'", proType);
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

        public static bool addProduct(DTO_Product pro)
        {
            string sql = string.Format("insert into Products values (  dbo.countProductbyIDshop(), (select IDProductType from ProductTypes where NameProductType= '{0}'),'{1}' ,'{2}','{3}','{4}','{5}','On')", pro.proIdType, pro.proName, pro.proSize, pro.proPrice, pro.proQuantity,pro.discount);
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

        public static bool updateProduct(DTO_Product pro)
        {
            string sql = string.Format("Update Products set IDProductType = (select IDProductType from ProductTypes where NameProductType= '{0}'), NameProduct = '{1}', Size = '{2}', Price = '{3}', Quantity = '{4}' , Discount = '{5}' where IDProduct = '{6}' ", pro.proIdType, pro.proName, pro.proSize,pro.proPrice,pro.proQuantity,pro.discount,pro.proID);
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

        public static bool updateQuantityPro(int quantity,string IDpro)
        {
            string sql = string.Format("Update Products set  Quantity = ((select Quantity from Products where IDProduct = '{0}')+'{1}') where IDProduct = '{0}' ", IDpro, quantity);
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

        public static bool delete(string id)
        {
            string sql = string.Format("Update Products set Status = 'Off' where IDProduct = '{0}' ",id);
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

    }
}
