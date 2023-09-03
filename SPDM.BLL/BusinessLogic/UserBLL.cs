using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class UserBLL
    {
        public int Save(User user)
        {
            try
            {
                UserDLL userDLL = new UserDLL();
                return userDLL.Save(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<User> GetAll(string whereClause = "")
        {
            if (!string.IsNullOrEmpty(whereClause))
            {
                whereClause = " Where " + whereClause;
            }
            try
            {
                UserDLL userDLL = new UserDLL();
                return userDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetById(int id)
        {
            try
            {
                UserDLL userDLL = new UserDLL();
                return userDLL.GetById(id);
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
                UserDLL userDLL = new UserDLL();
                return userDLL.GetCount(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Exist(string whereClause = "")
        {
            try
            {
                UserDLL userDLL = new UserDLL();
                return userDLL.Exist(whereClause);
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
                UserDLL userDLL = new UserDLL();
                return userDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int MarkAsInactive(int id)
        {
            try
            {
                UserDLL userDLL = new UserDLL();
                return userDLL.MarkAsInactive(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UserExist(string userName,string password)
        {
            try
            {
                UserDLL userDLL = new UserDLL();
                return userDLL.UserExist(userName, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetByName(string name)
        {
            try
            {
                UserDLL userDLL = new UserDLL();
                return userDLL.GetByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ChangePassword(int userid, string password)
        {
            try
            {
                UserDLL userDLL = new UserDLL();
                userDLL.ChangePassword(userid, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
