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

        public List<Item> GetAll()
        {
            try
            {
                ItemDLL itemDLL = new ItemDLL();
                return itemDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Item GetById()
        {
            try
            {
                ItemDLL itemDLL = new ItemDLL();
                return itemDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Item item)
        {
            try
            {
                ItemDLL itemDLL = new ItemDLL();
                return itemDLL.GetCount();
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
