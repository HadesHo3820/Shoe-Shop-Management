using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Order
    {
        
        public int createOrder(DTO_Order order)
        {
            return DAO_Order.createOrder(order);
        }

        public DataTable searchOrderByPhone(string cusPhone)
        {
            return DAO_Order.searchOrderByPhone(cusPhone);
        }

        public DataTable searchOrderByIdOrder(string idOrder)
        {
            return DAO_Order.searchOrderByIdOrder(idOrder);
        }

       
    }
}
