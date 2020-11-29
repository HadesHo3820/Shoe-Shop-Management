using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Customer
    {
        private DAO_Customer dao = new DAO_Customer();
        public DTO_Customer searchPhone(string phone)
        {
            return dao.searchPhone(phone);
        }

        public  int creatCustomer(DTO_Customer cus)
        {
            return dao.createCustomer(cus);
        }
    }
}
