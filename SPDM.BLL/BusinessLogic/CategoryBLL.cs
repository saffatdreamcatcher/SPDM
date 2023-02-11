using SPDM.DLL.Entities;
using SPDM.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.BLL.BusinessLogic
{
    public class CategoryBLL
    {
        public int Save(Category category)
        {
            try
            {
                CategoryDLL categoryDLL = new CategoryDLL();
                return categoryDLL.Save(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Category> GetAll()
        {
            try
            {
                CategoryDLL categoryDLL = new CategoryDLL();
                return categoryDLL.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Category GetById()
        {
            try
            {
                CategoryDLL categoryDLL = new CategoryDLL();
                return categoryDLL.GetById(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetCount(Category category)
        {
            try
            {
                var categoryDLL = new CategoryDLL();
                return categoryDLL.GetCount();
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
                var categoryDLL = new CategoryDLL();
                //int d = categoriesDLL.Delete(id);
                //return d;
                return categoryDLL.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
