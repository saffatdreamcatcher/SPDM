using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class PartyBLL
    {
        public int Save(Party party)
        {
            try
            {
                PartyDLL partyDLL = new PartyDLL();
                return partyDLL.Save(party);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Party> GetAll(string whereclause = "")
        {
            try
            {
                PartyDLL partyDLL = new PartyDLL();
                return partyDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Party GetById(int id)
        {
            try
            {
                PartyDLL partyDLL = new PartyDLL();
                return partyDLL.GetById(id);
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
                PartyDLL partyDLL = new PartyDLL();
                return partyDLL.GetCount(whereclause);
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
                PartyDLL partyDLL = new PartyDLL();
                //int d = partyDLL.Delete(id);
                //return d;
                return partyDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
