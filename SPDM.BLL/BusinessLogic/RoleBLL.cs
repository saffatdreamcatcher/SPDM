using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class RoleBLL
    {
        public int Save(Role role)
        {
            try
            {
                RoleDLL roleDLL = new RoleDLL();
                return roleDLL.Save(role);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Role> GetAll(string whereclause = "")
        {
            try
            {
                RoleDLL roleDLL = new RoleDLL();
                return roleDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Role GetById(int id)
        {
            try
            {
                RoleDLL roleDLL = new RoleDLL();
                return roleDLL.GetById(id);
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
                RoleDLL roleDLL = new RoleDLL();
                return roleDLL.GetCount(whereclause);
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
                RoleDLL roleDLL = new RoleDLL();
                return roleDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       


    }
}
