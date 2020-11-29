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
    public class DAO_Customer
    {
        private SqlConnection cnn;
        private DTO_Customer cus = new DTO_Customer();
        public  DTO_Customer searchPhone(string phone)
        {
            try
            {
                cus = null;
                DataTable dt = new DataTable();
                cnn = DataProvider.ConnectData();
                string load = string.Format("Select CusPhone, Fullname , Address From Customer where CusPhone = {0}", phone);
                SqlCommand cmd = new SqlCommand(load, cnn);

                SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        phone = dataReader["CusPhone"].ToString();
                        string Fullname = dataReader["Fullname"].ToString();
                        string Address = dataReader["Address"].ToString();
                        cus = new DTO_Customer(phone,Fullname, Address);
                        return cus;
                    }
                }
                cnn.Close();
                return cus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int createCustomer(DTO_Customer cus)
        {
            SqlConnection cnn = DataProvider.ConnectData();
            var cmd = new SqlCommand("createCustomer", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CusPhone", SqlDbType.Char).Value = cus.cusPhonenumber;
            cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = cus.cusName;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = cus.cusAddress;
            int count = cmd.ExecuteNonQuery();
            return count;
        }
       
    }
}
