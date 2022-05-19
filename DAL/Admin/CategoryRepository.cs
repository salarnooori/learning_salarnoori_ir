using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace DAL.Admin
{
    public class CategoryRepository
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public bool AddCategory(string name, int maincategory_id, int quantity = 0, string details = "")
        {
            try
            {
                OpenConn();
                //int b = 0;
                //float a = 10 / b;
                SetQuery("INSERT INTO Categories(name,quantity,details,maincategory_id) VALUES (\'" + name + "\',\'" + quantity.ToString() + "\',\'" + details + "\',\'" + maincategory_id + "\');");
                return CloseConn();
            }
            catch (Exception err)
            {
                DalException dalException = new DalException(err.Message, "DAL : AddCategory() in CategoryRepository.cs -> ");
                throw dalException;
            }
        }

        public List<MainCategory> GetMainCategory()
        {
            try
            {
                OpenConn();
                SetQuery("SELECT * FROM MainCategories;", 1);
                List<MainCategory> mainCategories = new List<MainCategory>();
                while (dr.Read())
                {
                    MainCategory mainCategory = new MainCategory();
                    mainCategory.id = int.Parse(dr[0].ToString());
                    mainCategory.name = dr[1].ToString();
                    mainCategory.description = dr[2].ToString();
                    mainCategory.image = dr[3].ToString();
                    mainCategory.quantity = int.Parse(dr[4].ToString());

                    mainCategories.Add(mainCategory);
                }
                conn.Close();
                return mainCategories;
            }
            catch (Exception err)
            {
                DalException dalException = new DalException(err.Message, "DAL : GetMainCategory() in CategoryRepository.cs -> ");
                throw dalException;
            }

        }

        public MainCategory GetMainCategoryById(int id)
        {
            try
            {
                OpenConn();
                SetQuery("SELECT * FROM MainCategories WHERE id =\'" + id.ToString() + "\';", 1);

                dr.Read();
                MainCategory mainCategory = new MainCategory();
                mainCategory.id = int.Parse(dr[0].ToString());
                mainCategory.name = dr[1].ToString();
                mainCategory.description = dr[2].ToString();
                mainCategory.image = dr[3].ToString();
                mainCategory.quantity = int.Parse(dr[4].ToString());

                conn.Close();
                return mainCategory;
            }
            catch (Exception err)
            {
                DalException dalException = new DalException(err.Message, "DAL : GetMainCategoryById() in CategoryRepository.cs -> ");
                throw dalException;
            }
        }

        public int GetManiCategoryIdByName(string name)
        {
            try
            {
                //name = name.Replace('ی', '_');
                OpenConn();
                SetQuery("SELECT id FROM MainCategories WHERE name like N\'%" + name.ToString() + "%\';", 1);
                dr.Read();
                int id = int.Parse(dr[0].ToString());
                conn.Close();

                return id;
            }
            catch (Exception err)
            {
                DalException dalException = new DalException(err.Message, "DAL : GetManiCategoryIdByName() in CategoryRepository.cs -> ");
                throw dalException;
            }
        }

        public List<Category> GetAll()
        {
            try
            {
                OpenConn();
                SetQuery("SELECT * FROM Categories;", 1);
                List<Category> categories = new List<Category>();
                while (dr.Read())
                {
                    Category category = new Category();
                    category.id = int.Parse(dr[0].ToString());
                    category.maincategory_id = int.Parse(dr[1].ToString());
                    category.name = dr[2].ToString();
                    category.quantity = int.Parse(dr[3].ToString());
                    category.details = dr[4].ToString();

                    categories.Add(category);
                }
                conn.Close();
                return categories;
            }
            catch (Exception err)
            {
                DalException dalException = new DalException(err.Message, "DAL : GetAll() in CategoryRepository.cs -> ");
                throw dalException;
            }
        }

        public Category GetCategory(int id)
        {
            try
            {
                OpenConn();
                SetQuery("SELECT * FROM Categories WHERE id =\'" + id.ToString() + "\';", 1);
                dr.Read();
                Category category = new Category();
                category.id = int.Parse(dr[0].ToString());
                category.maincategory_id = int.Parse(dr[1].ToString());
                category.name = dr[2].ToString();
                category.quantity = int.Parse(dr[3].ToString());
                category.details = dr[4].ToString();

                conn.Close();
                return category;
            }
            catch (Exception err)
            {
                DalException dalException = new DalException(err.Message, "DAL : GetCategory() in CategoryRepository.cs -> ");
                throw dalException;
            }
        }

        public bool EditCategory(int id, int maincategory_id, string name, string details)
        {
            try
            {
                OpenConn();
                SetQuery("UPDATE Categories SET name=\'" + name + "\', maincategory_id=\'" + maincategory_id + "\', details=\'" + details + "\' WHERE id=\'" + id + "\'");
                return CloseConn();
            }
            catch (Exception err)
            {
                DalException dalException = new DalException(err.Message, "DAL : EditCategory() in CategoryRepository.cs -> ");
                throw dalException;
            }
        }

        public bool DeleteCategory(int id)
        {
            try
            {
                OpenConn();
                SetQuery("DELETE FROM Categories WHERE id=\'" + id + "\';");
                return CloseConn();
            }
            catch (Exception err)
            {
                DalException dalException = new DalException(err.Message, "DAL : DeleteCategory() in CategoryRepository.cs -> ");
                throw dalException;
            }
        }

        private void OpenConn()
        {
            conn = new SqlConnection(Entity.ConnecectionString.connection1);
            conn.Open();
        }

        private void SetQuery(string query, int mode = 0)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            if (mode == 1)
            {
                dr = cmd.ExecuteReader();
            }


        }

        private bool CloseConn()
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
    }
}
