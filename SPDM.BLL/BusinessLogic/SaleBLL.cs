using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class SaleBLL
    {
        public int Save(Sale sale)
        {
            try
            {
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.Save(sale);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Sale> GetAll()
        {
            try
            {
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Sale GetById()
        {
            try
            {
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int GetCount(Sale sale)
        {
            try
            {
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.GetCount();
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
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
