using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.Admin;


namespace BLL.Admin
{
    public class CategoryController
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public bool AddCategory(string name, int maincategory_id, int quantity = 0, string details = "")
        {
            try
            {
                return categoryRepository.AddCategory(name, maincategory_id, quantity, details);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : AddCategory() in CategoryController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public List<Category> GetAll()
        {
            try
            {
                return categoryRepository.GetAll();
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : GetAll() in CategoryController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public List<MainCategory> GetMainCategory()
        {
            try
            {
                return categoryRepository.GetMainCategory();
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : GetMainCategory() in CategoryController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public Category GetCategory(int id)
        {
            try
            {
                return categoryRepository.GetCategory(id);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : GetCategory() in CategoryController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public MainCategory GetMainCategoryById(int category_id)
        {
            try
            {
                return categoryRepository.GetMainCategoryById(category_id);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : GetMainCategoryById() in CategoryController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public bool EditCategory(int id, int maincategory_id, string name, string details)
        {
            try
            {
                return categoryRepository.EditCategory(id, maincategory_id, name, details);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : EditCategory() in CategoryController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public bool DeleteCategory(int id)
        {
            try
            {
                return categoryRepository.DeleteCategory(id);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : DeleteCategory() in CategoryController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public int GetManiCategoryIdByName(string name)
        {
            try
            {
                return categoryRepository.GetManiCategoryIdByName(name);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : GetManiCategoryIdByName() in CategoryController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }
    }
}
