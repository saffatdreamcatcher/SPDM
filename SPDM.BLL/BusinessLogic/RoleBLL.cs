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


        public List<Role> GetAll()
        {
            try
            {
                RoleDLL roleDLL = new RoleDLL();
                return roleDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Role GetById()
        {
            try
            {
                RoleDLL roleDLL = new RoleDLL();
                return roleDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Role role)
        {
            try
            {
                RoleDLL roleDLL = new RoleDLL();
                return roleDLL.GetCount();
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
