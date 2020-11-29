using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product
    {
        public string proID { get; set; }
        public string proIdType { get; set; }
        public string proName { get; set; }
        public float proSize { get; set; }
        public int proPrice { get; set; }
        public int proQuantity { get; set; }
        public string discount { get; set; }
        public string proStatus { get; set; }

        public DTO_Product(string proID,string proIdtype, string proName, float proSize, int proPrice, int proQuantity, string discount)
        {
            this.proID = proID;
            this.proIdType = proIdtype;
            this.proName = proName;
            this.proSize = proSize;
            this.proPrice = proPrice;
            this.proQuantity = proQuantity;
            this.discount = discount;
        }


        public DTO_Product(string idProType, string name, float size, int price, int quantity, string discount)
        {
            this.proIdType = idProType;
            this.proName = name;
            this.proSize = size;
            this.proPrice = price;
            this.proQuantity = quantity;
            this.discount = discount;
        }

        public DTO_Product()
        {

        }
    }
}
