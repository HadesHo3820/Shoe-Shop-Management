using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Shop
    {
        public string IDShop { get; set; }
        public string NameShop { get; set; }
        public string Address { get; set; }

        public DTO_Shop(string IDShop, string nameShop, string address)
        {
            this.IDShop = IDShop;
            this.NameShop = nameShop;
            this.Address = address;
        }

        public DTO_Shop(string nameShop)
        {
            this.NameShop = nameShop;
        }

        public DTO_Shop()
        {

        }
    }
}
