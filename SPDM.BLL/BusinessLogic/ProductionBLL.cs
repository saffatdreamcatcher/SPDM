using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class ProductionBLL
    {
        public int Save(Production production)
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.Save(production);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Production> GetAll(string whereclause = "")
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Production GetById(int id)
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(string whereclause = "")
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.GetCount(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int Delete(int id)
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
