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
            OpenConn();
            SetQuery("INSERT INTO Categories(name,quantity,details,maincategory_id) VALUES (\'" + name + "\',\'" + quantity.ToString() + "\',\'" + details + "\',\'" + maincategory_id + "\');");
            return CloseConn();
        }

        public List<MainCategory> GetMainCategory()
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

        public MainCategory GetMainCategoryById(int id)
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

        public int GetManiCategoryIdByName(string name)
        {
            //name = name.Replace('ی', '_');
            OpenConn();
            SetQuery("SELECT id FROM MainCategories WHERE name like N\'%" + name.ToString() + "%\';", 1);
            dr.Read();
            int id = int.Parse(dr[0].ToString());
            conn.Close();

            return id;
        }

        public List<Category> GetAll()
        {
            OpenConn();
            SetQuery("SELECT * FROM Categories;",1);
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

        public Category GetCategory(int id)
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

        public bool EditCategory(int id, int maincategory_id, string name, string details)
        {
            OpenConn();
            SetQuery("UPDATE Categories SET name=\'" + name + "\', maincategory_id=\'" + maincategory_id + "\', details=\'" + details + "\' WHERE id=\'" + id + "\'");
            return CloseConn();
        }

        public bool DeleteCategory(int id)
        {
            OpenConn();
            SetQuery("DELETE FROM Categories WHERE id=\'" + id + "\';");
            return CloseConn();
        }

        private void OpenConn()
        {
            conn = new SqlConnection(Entity.ConnecectionString.connection1);
            conn.Open();
        }

        private void SetQuery(string query, int mode=0)
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
