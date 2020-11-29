using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_Employee
    {
        DAO_Employee daoEmp = new DAO_Employee();

        public DTO_Employee Login(String username, String password)
        {
            return daoEmp.Login(username,password);
        }

        public DataTable loadEmployee()
        {
            return daoEmp.loadEmployees();
        }

        public DTO_Employee getDetail(String username)
        {
            return daoEmp.getDetail(username);
        }

        public bool checkEmployee(string id)
        {
            return daoEmp.checkEmployee(id);
        }

        public bool addEmployee(DTO_Employee emp)
        {
            return daoEmp.addEmployee(emp);
        }
        public bool updateEmployee(DTO_Employee emp)
        {
            return daoEmp.updateEmployee(emp);
        }
        public bool deleteEmployee(string id)
        {
            return daoEmp.deleteEmployee(id);
        }
    }
}
