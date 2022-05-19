using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BLL.Admin;
using System.IO;

namespace UIL.Admin.User
{
    public partial class ShowUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UserController userController = new UserController();

                List<Entity.User> users = userController.GetAll();

                for (int i = 0; i < users.Count; i++)
                {
                    users[i].image = "~\\assets\\uploads\\profiles\\" + users[i].image.ToString();
                }

                users_gv.DataSource = users;
                users_gv.DataBind();
            }
            catch (BllException err)
            {
                ErrorController errorController = new ErrorController();
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "UIL : Page_Load() in ShowUser.aspx.cs";
                string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                string values = "No input value from user";
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

        protected void users_gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int id = int.Parse(users_gv.DataKeys[e.RowIndex].Value.ToString());
                UserController userController = new UserController();

                Entity.User u = userController.GetUser(id);
                if (u.image.ToString() != "defult.png")
                    File.Delete(Server.MapPath("~\\assets\\uploads\\profiles\\") + u.image.ToString());

                bool result = userController.DeleteUser(id);

                if (result)
                {
                    Response.Redirect("ShowUser.aspx");
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
                route += "UIL : users_gv_RowDeleting() in ShowUser.aspx.cs";
                string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                string values = "No input value from user";
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
        protected void users_gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                int id = int.Parse(users_gv.DataKeys[e.NewEditIndex].Value.ToString());

                Response.Redirect("EditUser.aspx?id=" + id.ToString());
            }
            catch (BllException err)
            {
                ErrorController errorController = new ErrorController();
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "UIL : users_gv_RowEditing() in ShowUser.aspx.cs";
                string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                string values = "No input value from user";
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