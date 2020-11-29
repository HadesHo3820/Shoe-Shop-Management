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
    public class DAO_Orderdetail
    {
        private static SqlConnection cnn = null;
        public static int createOrderDetail(DTO_OrderDetail orderDetail )
        {
            SqlConnection cnn = DataProvider.ConnectData();
            var cmd = new SqlCommand("createoderdetail", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IDOrther", SqlDbType.Int).Value = orderDetail.IDOrther;
            cmd.Parameters.Add("@IDProduct", SqlDbType.NVarChar).Value = orderDetail.IDProduct;
            cmd.Parameters.Add("@Price", SqlDbType.Float).Value = orderDetail.Price;
            cmd.Parameters.Add("@Discount", SqlDbType.NVarChar).Value = orderDetail.Discount;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = orderDetail.Quantity;
            int count = cmd.ExecuteNonQuery();
            return count;
        }


        public static DataTable searchDetailByIdOrder(string idOrder)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = string.Format("select ot.IDProduct, p.NameProduct, p.Size, ot.Price, ot.Quantity from Orderproduct od, Oderdetail ot, Products p where p.IDProduct = ot.IDProduct and od.IDOrther = ot.IDOrther and od.IDOrther like '%{0}%'", idOrder);
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
