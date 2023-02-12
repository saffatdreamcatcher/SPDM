using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class ProfileBLL
    {
        public int Save(Profile profile)
        {
            try
            {
                ProfileDLL profileDLL = new ProfileDLL();
                return profileDLL.Save(profile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Profile> GetAll(string whereclause = "")
        {
            try
            {
                ProfileDLL profileDLL = new ProfileDLL();
                return profileDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Profile GetById(int id)
        {
            try
            {
                ProfileDLL profileDLL = new ProfileDLL();
                return profileDLL.GetById(id);
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
                ProfileDLL profileDLL = new ProfileDLL();
                return profileDLL.GetCount(whereclause);
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
                ProfileDLL profileDLL = new ProfileDLL();
                return profileDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
