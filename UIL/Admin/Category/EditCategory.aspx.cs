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
    public partial class EditCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryController categoryController = new CategoryController();
            if (!Page.IsPostBack)
            {
                List<Entity.MainCategory> mainCategories = categoryController.GetMainCategory();

                category_lst.DataSource = mainCategories;
                category_lst.DataTextField = "name";
                category_lst.DataValueField = "id";
                category_lst.DataBind();
            }

            int id = int.Parse(Request.QueryString["id"]);

            Entity.Category category = categoryController.GetCategory(id);
            category = categoryController.GetCategory(id);

            if (category != null)
            {
                if (name_txt.Text == "")
                {
                    name_txt.Text = category.name;
                    details_txt.Text = category.details;
                    category_lst.SelectedIndex = category.maincategory_id-1;
                }
            }
            else
            {
                Response.Redirect("ShowCategory.aspx");
            }



        }

        protected void edit_category_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            CategoryController categoryControler = new CategoryController();
            bool result = categoryControler.EditCategory(id, int.Parse(category_lst.SelectedItem.Value), name_txt.Text.ToString(), details_txt.Text.ToString());

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