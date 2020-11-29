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
    public class BUS_ProductType
    {
        private DAO_ProductType dao = new DAO_ProductType();
        public DataTable loadProType()
        {
            return dao.loadProType();
        }

        public bool addProType(DTO_ProductType proType)
        {
            return dao.addProType(proType);
        }
        public bool updateProType(DTO_ProductType proType)
        {
            return dao.updateProType(proType);
        }
        public bool deleteProType(String idProType)
        {
            return dao.deleteProType(idProType);
        }

        public bool checkProType(string idProType)
        {
            return dao.checkProType(idProType);
        }
    }
}
