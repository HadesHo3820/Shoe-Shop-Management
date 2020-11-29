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
    public class DAO_Order
    {
        private static SqlConnection cnn = null;
        public static int createOrder(DTO_Order order)
        {
            SqlConnection cnn = DataProvider.ConnectData();
            var cmd = new SqlCommand("createordert", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CusPhone", SqlDbType.Char).Value = order.cusPhone;
            cmd.Parameters.Add("@IdEmployee", SqlDbType.NVarChar).Value = order.idEmp;
            cmd.Parameters.Add("@PriceFinal", SqlDbType.Float).Value = order.total;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = order.quantity;
            return (int)cmd.ExecuteScalar();
        }

        public static DataTable searchOrderByPhone(string cusPhone)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = string.Format("select op.IDOrther, c.FullName, c.CusPhone , op.DateTimeOrther, op.Quantity,  op.PriceFinal from Orderproduct op, Customer c where op.CusPhone like '%{0}%' and op.CusPhone = c.CusPhone", cusPhone);
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

        public static DataTable searchOrderByIdOrder(string idOrder)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = string.Format("select op.IDOrther, c.FullName, c.CusPhone , op.DateTimeOrther, op.Quantity,  op.PriceFinal from Orderproduct op, Customer c where op.IDOrther like '%{0}%' and op.CusPhone = c.CusPhone", idOrder);
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
