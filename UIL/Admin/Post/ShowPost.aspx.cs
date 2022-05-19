using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BLL.Admin;
using System.IO;

namespace UIL.Admin.Post
{
    public partial class ShowPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PostController PostController = new PostController();

                List<Entity.Post> posts = PostController.GetAll();

                UserController userController = new UserController();
                CategoryController categoryController = new CategoryController();

                for (int i = 0; i < posts.Count; i++)
                {
                    if (posts[i].category_id <= 4)
                    {
                        posts[i].category_name = categoryController.GetMainCategoryById(posts[i].category_id).name;
                    }
                    else
                    {
                        posts[i].category_name = categoryController.GetCategory(posts[i].category_id).name;
                    }

                    posts[i].author_name = userController.GetUser(posts[i].author_id).name;

                    posts[i].image = "~\\assets\\uploads\\posts\\" + posts[i].image.ToString();

                }



                posts_gv.DataSource = posts;
                posts_gv.DataBind();
            }
            catch (BllException err)
            {
                ErrorController errorController = new ErrorController();
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "UIL : Page_Load() in ShowPost.aspx.cs";
                string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                string values = "No input value from user.";
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

        protected void posts_gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = int.Parse(posts_gv.DataKeys[e.RowIndex].Value.ToString());
                PostController PostController = new PostController();

                Entity.Post u = PostController.GetPost(id);
                if (u.image.ToString() != "defult1.jpg" && u.image.ToLower() != "defult2.jpg")
                    File.Delete(Server.MapPath("~\\assets\\uploads\\posts\\") + u.image.ToString());

                bool result = PostController.DeletePost(id);

                if (result)
                {
                    Response.Redirect("ShowPost.aspx");
                }
                else
                {
                    Response.Write("<script>alert('خطا در ثبت اطلاعات در پایگاه داده.')</script>");
                }
            }
            catch (BllException err)
            {
                ErrorController errorController = new ErrorController();
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "UIL : posts_gv_RowDeleting() in ShowPost.aspx.cs";
                string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                string values = "No input value from user.";
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
        protected void posts_gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                int id = int.Parse(posts_gv.DataKeys[e.NewEditIndex].Value.ToString());

                Response.Redirect("EditPost.aspx?id=" + id.ToString());
            }
            catch (BllException err)
            {
                ErrorController errorController = new ErrorController();
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "UIL : posts_gv_RowEditing() in ShowPost.aspx.cs";
                string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                string values = "No input value from user.";
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
    }
}