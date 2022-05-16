using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BLL.Admin;

namespace UIL.Admin.Category
{
    public partial class ShowCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryController categoryController = new CategoryController();

            List<Entity.Category> categories = categoryController.GetAll();
            List<Entity.MainCategory> mainCategories = categoryController.GetMainCategory();

            GridView1.DataSource = mainCategories;
            GridView1.DataBind();

            for (int i = 0; i < categories.Count; i++)
            {
                categories[i].maincategory_name = mainCategories[categories[i].maincategory_id-1].name;
            }

            categories_gv.DataSource = categories;
            categories_gv.DataBind();
        }

        protected void categories_gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(categories_gv.DataKeys[e.RowIndex].Value.ToString());
            CategoryController categoryController = new CategoryController();   
            bool result = categoryController.DeleteCategory(id);

            if (result)
            {
                Response.Redirect("ShowCategory.aspx");
            }
            else
            {
                Response.Write("<script>alert('خطا در ثبت اطلاعات در پایگاه داده.')</script>");
            }

        }
        protected void categories_gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(categories_gv.DataKeys[e.NewEditIndex].Value.ToString());

            Response.Redirect("EditCategory.aspx?id=" + id.ToString());
        }
    }
}