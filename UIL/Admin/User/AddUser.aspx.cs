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

    }
}