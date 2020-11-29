using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_OrderDetail
    {
       public int IDOrther { get; set; }
        public string IDProduct { get; set; }
        public float Price { get; set; }
        public string Discount { get; set; }
        public int Quantity { get; set; }

        public DTO_OrderDetail(int IDOrther, string IDProduct, float Price, string Discount, int Quantity)
        {
            this.IDOrther = IDOrther;
            this.IDProduct = IDProduct;
            this.Price = Price;
            this.Discount = Discount;
            this.Quantity = Quantity;

           
        }
        public DTO_OrderDetail()
        {
        }
    }
}
