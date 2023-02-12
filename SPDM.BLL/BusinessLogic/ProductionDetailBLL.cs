using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class ProductionDetailBLL
    {
        public int Save(ProductionDetail productiondetail)
        {
            try
            {
                ProductionDetailDLL productiondetailDLL = new ProductionDetailDLL();
                return productiondetailDLL.Save(productiondetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductionDetail> GetAll(string whereclause = "")
        {
            try
            {
                ProductionDetailDLL productiondetailDLL = new ProductionDetailDLL();
                return productiondetailDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductionDetail GetById(int id)
        {
            try
            {
                ProductionDetailDLL productiondetailDLL = new ProductionDetailDLL();
                return productiondetailDLL.GetById(id);
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
                ProductionDetailDLL productiondetailDLL = new ProductionDetailDLL();
                return productiondetailDLL.GetCount(whereclause);
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
                ProductionDetailDLL productiondetailDLL = new ProductionDetailDLL();
                return productiondetailDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
