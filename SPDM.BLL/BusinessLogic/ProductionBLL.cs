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

        public List<Production> GetAll()
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Production GetById()
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Production production)
        {
            try
            {
                ProductionDLL productionDLL = new ProductionDLL();
                return productionDLL.GetCount();
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
