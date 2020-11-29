using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Order
    {
        public string idEmp { get; set; }
        public string cusPhone { get; set; }
        public float total { get; set; }
        public int quantity { get; set; }

        public DTO_Order(string cusPhone, string idEmp, float total, int quantity)
        {
            this.cusPhone = cusPhone;
            this.idEmp = idEmp;
            this.total = total;
            this.quantity = quantity;
        }
        public DTO_Order()
        {
        }
    }
}
