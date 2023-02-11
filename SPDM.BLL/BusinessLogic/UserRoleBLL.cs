using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class UserRoleBLL
    {
        public int Save(UserRole userrole)
        {
            try
            {
                UserRoleDLL userroleDLL = new UserRoleDLL();
                return userroleDLL.Save(userrole);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UserRole> GetAll()
        {
            try
            {
                UserRoleDLL userroleDLL = new UserRoleDLL();
                return userroleDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public UserRole GetById()
        {
            try
            {
                UserRoleDLL userroleDLL = new UserRoleDLL();
                return userroleDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int GetCount(UserRole userrole)
        {
            try
            {
                UserRoleDLL userroleDLL = new UserRoleDLL();
                return userroleDLL.GetCount();
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
                UserRoleDLL userroleDLL = new UserRoleDLL();
                return userroleDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
