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
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CategoryController categoryController = new CategoryController();
                List<Entity.MainCategory> mainCategories = categoryController.GetMainCategory();


                category_lst.DataSource = mainCategories;
                category_lst.DataTextField = "name";
                category_lst.DataValueField = "id";
                category_lst.DataBind();
            }
        }

        protected void add_category_btn_Click(object sender, EventArgs e)
        {

            CategoryController categoryController = new CategoryController();

            bool result = categoryController.AddCategory(name_txt.Text.ToString(), int.Parse(category_lst.SelectedItem.Value), 0, details_txt.Text.ToString());

            if (result)
            {
                Response.Redirect("ShowCategory.aspx");
            }
            else
            {
                Response.Write("<script>alert('خطا در ثبت اطلاعات در پایگاه داده.')</script>");
            }

        }
    }
}