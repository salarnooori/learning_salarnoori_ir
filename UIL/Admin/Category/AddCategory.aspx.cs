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
            try
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
            catch (BllException err)
            {
                ErrorController errorController = new ErrorController();
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "UIL : Page_Load() in AddCategory.aspx.cs";
                string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                string values = "Name = " + name_txt.Text.ToString() +
                    " & MainCategory = " + category_lst.SelectedItem.Text +
                    " & Details = " + details_txt.Text.ToString();
                if (errorController.AddError(message, route, ip, values))
                {
                    //write in Errors Table
                }
                else
                {
                    //cant write in Database
                }

                Response.Write("<script>alert('خطا در ثبت اطلاعات .')</script>");

            }

        }

        protected void add_category_btn_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryController categoryController = new CategoryController();

                bool result = categoryController.AddCategory(name_txt.Text.ToString(), int.Parse(category_lst.SelectedItem.Value), 0, details_txt.Text.ToString());

                if (result)
                {
                    Response.Redirect("ShowCategory.aspx");
                }
                else
                {
                    Response.Write("<script>alert('در پایگاه داده خطا در ثبت اطلاعات .')</script>");
                }

            }
            catch (BllException err)
            {
                ErrorController errorController = new ErrorController();
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "UIL : add_category_btn_Click() in AddCategory.aspx.cs";
                string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                string values = "Name = " + name_txt.Text.ToString() +
                    " & MainCategory = " + category_lst.SelectedItem.Text +
                    " & Details = " + details_txt.Text.ToString();
                if(errorController.AddError(message, route, ip, values))
                {
                    //write in Errors Table
                }
                else
                {
                    //cant write in Database
                }

                Response.Write("<script>alert('خطا در ثبت اطلاعات .')</script>");

            }

            
        }
    }
}