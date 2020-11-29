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
    public class BUS_Orderdetail
    {
        
        public int createOrderDetail(DTO_OrderDetail orderDetail)
        {
            return DAO_Orderdetail.createOrderDetail(orderDetail);
        }

        public DataTable searchDetailByIdOrder(string idOrder)
        {
            return DAO_Orderdetail.searchDetailByIdOrder(idOrder);
        }
    }
}
