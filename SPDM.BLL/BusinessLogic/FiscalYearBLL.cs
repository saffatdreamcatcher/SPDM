using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class FiscalYearBLL
    {
        public int Save(FiscalYear fiscalYear)
        {
            try
            {
                FiscalYearDLL fiscalYearDLL = new FiscalYearDLL();
                return fiscalYearDLL.Save(fiscalYear);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FiscalYear> GetAll(string whereclause = "")
        {
            try
            {
                FiscalYearDLL fiscalYearDLL = new FiscalYearDLL();
                return fiscalYearDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public FiscalYear GetById(int id)
        {
            try
            {
                FiscalYearDLL fiscalYearDLL = new FiscalYearDLL();
                return fiscalYearDLL.GetById(id);
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
                FiscalYearDLL fiscalYearDLL = new FiscalYearDLL();
                return fiscalYearDLL.GetCount(whereclause);
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
                FiscalYearDLL fiscalYearDLL = new FiscalYearDLL();
                return fiscalYearDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
