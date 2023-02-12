using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class SaleDetailBLL
    {
        public int Save(SaleDetail saledetail)
        {
            try
            {
                SaleDetailDLL saledetailDLL = new SaleDetailDLL();
                return saledetailDLL.Save(saledetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SaleDetail> GetAll(string whereclause = "")
        {
            try
            {
                SaleDetailDLL saledetailDLL = new SaleDetailDLL();
                return saledetailDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SaleDetail GetById(int id)
        {
            try
            {
                SaleDetailDLL saledetailDLL = new SaleDetailDLL();
                return saledetailDLL.GetById(id);
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
                SaleDetailDLL saledetailDLL = new SaleDetailDLL();
                return saledetailDLL.GetCount(whereclause);
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
                SaleDetailDLL saledetailDLL = new SaleDetailDLL();
                return saledetailDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
