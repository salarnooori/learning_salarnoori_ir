using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BLL.Admin;

namespace UIL.Admin.User
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_user_btn_Click(object sender, EventArgs e)
        {
            try
            {
                UserController UserController = new UserController();

                bool result;

                if (FileUpLoad1.HasFile)
                {
                    FileUpLoad1.SaveAs(Server.MapPath("~\\assets\\uploads\\profiles\\") + FileUpLoad1.FileName);
                    result = UserController.AddUser(username_txt.Text.ToString(), password_txt.Text.ToString(), email_txt.Text.ToString(), name_txt.Text.ToString(), family_txt.Text.ToString(), FileUpLoad1.FileName, bio_txt.Text.ToString());
                }
                else
                {
                    result = UserController.AddUser(username_txt.Text.ToString(), password_txt.Text.ToString(), email_txt.Text.ToString(), name_txt.Text.ToString(), family_txt.Text.ToString(), "defult.png", bio_txt.Text.ToString());
                }

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
                route += "UIL : add_user_btn_Click() in AddUser.aspx.cs";
                string ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = Request.ServerVariables["REMOTE_ADDR"];
                }
                string values = "Username = " + username_txt.Text.ToString() +
                    " & Password = " + password_txt.Text.ToString() +
                    " & Email = " + email_txt.Text +
                    " & Name = " + name_txt.Text +
                    " & Family = " + family_txt.Text +
                    " & FileName = " + FileUpLoad1.FileName +
                    " & Bio = " + bio_txt.Text.ToString();
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