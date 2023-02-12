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

        public List<Sale> GetAll(string whereclause = "")
        {
            try
            {
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Sale GetById(int id)
        {
            try
            {
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.GetById(id);
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
                SaleDLL saleDLL = new SaleDLL();
                return saleDLL.GetCount(whereclause);
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
