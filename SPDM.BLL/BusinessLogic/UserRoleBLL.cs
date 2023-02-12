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

        public List<UserRole> GetAll(string whereclause = "")
        {
            try
            {
                UserRoleDLL userroleDLL = new UserRoleDLL();
                return userroleDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public UserRole GetById(int id)
        {
            try
            {
                UserRoleDLL userroleDLL = new UserRoleDLL();
                return userroleDLL.GetById(id);
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
                UserRoleDLL userroleDLL = new UserRoleDLL();
                return userroleDLL.GetCount(whereclause);
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
