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
    public class BUS_Revenue
    {
        public DataTable loadTop5Revenue(string dateBegin, string dateEnd)
        {
            return DAO_Revenue.loadTop5Revenue(dateBegin, dateEnd);
        }

        public List<DTO_Revenue> loadRevenueByYear(string dateBegin, string dateEnd)
        {
            return DAO_Revenue.loadRevenuesByYear(dateBegin, dateEnd);
        }

        public  List<DTO_Revenue> toList(DataTable dt)
        {
            return DAO_Revenue.toList(dt);
        }
    }
}
