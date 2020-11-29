using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Revenue
    { 
        public string nameProduct { get; set; }
        public int totalQuantity { get; set; }
        public int totalRevenue { get; set; }
        public int month { get; set; }
        public int year { get; set; }


        public DTO_Revenue(string nameProduct, int totalQuantity, int totalRevenue)
        {
            this.nameProduct = nameProduct;
            this.totalQuantity = totalQuantity;
            this.totalRevenue = totalRevenue;
        }
        public DTO_Revenue(int month,int totalRevenue)
        {
            this.month = month;
            this.totalRevenue = totalRevenue;
        }
        public DTO_Revenue()
        {

        }
    }

    
}
