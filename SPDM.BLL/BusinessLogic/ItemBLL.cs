using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class ItemBLL
    {
        public int Save(Item item)
        {
            try
            {
                ItemDLL itemDLL = new ItemDLL();
                return itemDLL.Save(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Item> GetAll(string whereclause = "")
        {
            try
            {
                ItemDLL itemDLL = new ItemDLL();
                return itemDLL.GetAll(whereclause);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Item GetById(int id)
        {
            try
            {
                ItemDLL itemDLL = new ItemDLL();
                return itemDLL.GetById(id);
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
                ItemDLL itemDLL = new ItemDLL();
                return itemDLL.GetCount(whereclause);
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
                ItemDLL itemDLL = new ItemDLL();
                //int d = itemDLL.Delete(id);
                //return d;
                return itemDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
