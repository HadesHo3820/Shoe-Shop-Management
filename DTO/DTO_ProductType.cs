using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ProductType
    {
        public string IDProductType { get; set; }
        public string IDProductlines { get; set; }
        public string NameProductType { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        public DTO_ProductType()
        {

        }

        public DTO_ProductType(string IDProductType, string IDProductlines, string NameProductType, int Quantity)
        {
            this.IDProductType = IDProductType;
            this.IDProductlines = IDProductlines;
            this.NameProductType = NameProductType;
            this.Quantity = Quantity;
        }

    }
}
