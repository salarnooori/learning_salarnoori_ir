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

        public bool AddCategory(string name, int maincategory_id, int quantity=0, string details="")
        {
            return categoryRepository.AddCategory(name, maincategory_id, quantity, details);
        }

        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public List<MainCategory> GetMainCategory()
        {
            return categoryRepository.GetMainCategory();
        }

        public Category GetCategory(int id)
        {
            return categoryRepository.GetCategory(id);
        }

        public MainCategory GetMainCategoryById(int category_id)
        {
            return categoryRepository.GetMainCategoryById(category_id);
        }

        public bool EditCategory(int id, int maincategory_id, string name, string details)
        {
            return categoryRepository.EditCategory(id, maincategory_id, name, details);
        }

        public bool DeleteCategory(int id)
        {
            return categoryRepository.DeleteCategory(id);
        }

        public int GetManiCategoryIdByName(string name)
        {
            return categoryRepository.GetManiCategoryIdByName(name);
        }
    }
}
