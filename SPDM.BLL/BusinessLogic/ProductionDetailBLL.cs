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

        public List<ProductionDetail> GetAll()
        {
            try
            {
                ProductionDetailDLL productiondetailDLL = new ProductionDetailDLL();
                return productiondetailDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductionDetail GetById()
        {
            try
            {
                ProductionDetailDLL productiondetailDLL = new ProductionDetailDLL();
                return productiondetailDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(ProductionDetail productiondetail)
        {
            try
            {
                ProductionDetailDLL productiondetailDLL = new ProductionDetailDLL();
                return productiondetailDLL.GetCount();
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
