using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using DTO;
using System.Drawing;

namespace DAO
{

    public class DAO_Employee
    {
        private SqlConnection cnn = null;
        private DTO_Employee emp = null;
        public DTO_Employee Login(String username, String password)
        {
            
            cnn = DataProvider.ConnectData();
            string sqlQuery = string.Format("select Role, NameEmployee, IDShops from Employee where IdEmployee = '{0}' and Password = '{1}' and Status = 'On'", username,password);
            SqlCommand command = new SqlCommand(sqlQuery, cnn);


            SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);

            if (dataReader.HasRows)
            {
                if (dataReader.Read())
                {
                    string role = dataReader["Role"].ToString();
                    string name = dataReader["NameEmployee"].ToString();
                    string idShop = dataReader["IDShops"].ToString();
                    emp = new DTO_Employee(username, password, name, idShop, role);
                    return emp;
                }
            }
            cnn.Close();
            return emp;
        }

        public DTO_Employee getDetail(String username)
        {
            cnn = DataProvider.ConnectData();
            string sqlQuery = string.Format("select IdEmployee, Password, NameEmployee, NumberPhoneEmployee, AddressEmployee, sp.Address, SupervisorEmployee, Role, emp.Status from Employee emp, Shops sp where emp.IDShops = sp.IDShops and emp.IdEmployee = '{0}'", username);
            SqlCommand command = new SqlCommand(sqlQuery, cnn);
            SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);

            if (dataReader.HasRows)
            {
                if (dataReader.Read())
                {
                    string Username = dataReader["IdEmployee"].ToString();
                    string Password = dataReader["Password"].ToString();
                    string Fullname = dataReader["NameEmployee"].ToString();
                    string role = dataReader["Role"].ToString();
                    string Shop = dataReader["Address"].ToString();
                    string Address = dataReader["AddressEmployee"].ToString();
                    string Supervisor = dataReader["SupervisorEmployee"].ToString();
                    string Phone = dataReader["NumberPhoneEmployee"].ToString();
                    string Status = dataReader["Status"].ToString();
                    emp = new DTO_Employee(Username, Password, Fullname, Phone, Address, Shop, Supervisor, role, Status);
                    return emp;
                }
            }
            cnn.Close();
            return emp;
        }

        public DataTable loadEmployees()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select IdEmployee, NameEmployee, Role, Status from Employee where Role between  'Cashier' and  'Manager'";
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

        public bool checkEmployee(string id)
        {
            bool result = false;
            string sql = string.Format("select IdEmployee from Employee where IdEmployee = '{0}' ", id);
            cnn = DataProvider.ConnectData();
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (dataReader.HasRows)
            {
                return true;
            }
            return result;
        }

        public bool addEmployee(DTO_Employee emp)
        {
            string sql = string.Format(" insert into Employee  values( '{0}' , '{1}' , '{2}' ,(select IDShops from Shops  where Address = '{3}' ), '{4}' , '{5}' , '{6}' , '{7}' ,'On') ", emp.Username, emp.Password, emp.Fullname, emp.IDShop, emp.Address,emp.Supervisor,emp.Phone,emp.role);
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

        public bool updateEmployee(DTO_Employee emp)
        {
            string sql = string.Format("update Employee set Password = '{0}', NameEmployee = '{1}', IDShops = (select IDShops from Shops  where Address = '{2}'), AddressEmployee = '{3}', SupervisorEmployee = '{4}',  NumberPhoneEmployee = '{5}', Role = '{6}', Status = '{7}' where IdEmployee = '{8}' ", emp.Password, emp.Fullname, emp.IDShop, emp.Address, emp.Supervisor, emp.Phone, emp.role,emp.Status, emp.Username);
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



        public bool deleteEmployee(string id)
        {
            string sql = string.Format("Update Employee set Status = 'Off' where IdEmployee = '{0}' ", id);
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
