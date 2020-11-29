using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        public string cusPhonenumber { get; set; }
        public string cusName { get; set; }
        public string cusAddress { get; set; }
        public DTO_Customer(string phone, string name, string address)
        {
            this.cusPhonenumber = phone;
            this.cusName = name;
            this.cusAddress = address;
        }

        public DTO_Customer()
        {

        }
    }
}
