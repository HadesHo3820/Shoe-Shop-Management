using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string role { get; set; }
        public string IDShop { get; set; }
        public string Address { get; set; }
        public string Supervisor { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }



        public DTO_Employee(string username, string password, string fullname,string idShop, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Fullname = fullname;
            this.IDShop = idShop;
            this.role = role;
        }

        public DTO_Employee(string username, string password, string fullname, string phone, string address, string idShop, string supervisor, string role , string status)
        {
            this.Username = username;
            this.Password = password;
            this.Fullname = fullname;
            this.Phone = phone;
            this.Address = address;
            this.IDShop = idShop;
            this.Supervisor = supervisor;
            this.role = role;
            this.Status = status;
        }

        public DTO_Employee()
        {

        }
    }
}
