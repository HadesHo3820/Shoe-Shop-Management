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
    public class BUS_Shop
    {
        DAO_Shop dao = new DAO_Shop();
        public DataTable loadShop()
        {
            return dao.loadShop();
        }
    }
}
