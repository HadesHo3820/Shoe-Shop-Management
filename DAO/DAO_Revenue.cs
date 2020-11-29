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
    public class DAO_Revenue
    {
        public static DataTable loadTop5Revenue(string dateBegin, string dateEnd)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn = DataProvider.ConnectData();
            var cmd = new SqlCommand("printStatiscalOrderbyDate", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@dateBegin", SqlDbType.DateTime).Value = dateBegin;
            cmd.Parameters.Add("@dateEnd", SqlDbType.DateTime).Value = dateEnd;
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static List<DTO_Revenue> toList(DataTable dt)
        {
            List<DTO_Revenue> revenueList = new List<DTO_Revenue>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Revenue revenue = new DTO_Revenue();
                revenue.nameProduct = Convert.ToString(dt.Rows[i]["NameProduct"]);
                revenue.totalQuantity = Convert.ToInt32(dt.Rows[i]["TotalQuantity"]);
                revenue.totalRevenue = Convert.ToInt32(dt.Rows[i]["TotalPrice"]);
                revenueList.Add(revenue);
            }
            return revenueList;
        }

        public static List<DTO_Revenue> loadRevenuesByYear(string dateBegin, string dateEnd)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn = DataProvider.ConnectData();
            var cmd = new SqlCommand("printPriceTotal", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@dateBegin", SqlDbType.DateTime).Value = dateBegin;
            cmd.Parameters.Add("@dateEnd", SqlDbType.DateTime).Value = dateEnd;
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            List<DTO_Revenue> revenueList = new List<DTO_Revenue>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Revenue revenue = new DTO_Revenue();
                revenue.month = Convert.ToInt32(dt.Rows[i]["month"]);
                revenue.totalRevenue = Convert.ToInt32(dt.Rows[i]["price"]);
                revenueList.Add(revenue);
            }
            return revenueList;
        }
    }
}
