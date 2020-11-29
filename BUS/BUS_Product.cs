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
    public class BUS_Product
    {
        public DataTable loadProduct()
        {
            return DAO_Product.loadProduct();
        }
        public DataTable loadProByName(string proName)
        {
            return DAO_Product.loadProByName(proName);
        }

        public DataTable loadProByType(string proType)
        {
            return DAO_Product.loadProByType(proType);
        }

        public  bool addProduct(DTO_Product pro)
        {
            return DAO_Product.addProduct(pro);
        }
        public bool updateProduct(DTO_Product pro)
        {
            return DAO_Product.updateProduct(pro);
        }

        public bool deleteProduct(string id)
        {
            return DAO_Product.delete(id);
        }

        public  bool updateQuantityPro(int quantity, string IDpro)
        {
            return DAO_Product.updateQuantityPro(quantity, IDpro);
        }
        public bool checkID(string id)
        {
            return DAO_Product.checkID(id);
        }
    }
}
