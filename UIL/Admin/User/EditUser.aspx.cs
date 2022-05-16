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
    public partial class EditUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);

            UserController userController = new UserController();

            Entity.User user = userController.GetUser(id);
            user = userController.GetUser(id);

            if (user != null)
            {
                if (username_txt.Text == "")
                {
                    username_txt.Text = user.username.ToString();
                    password_txt.Text = user.password.ToString();
                    email_txt.Text = user.email.ToString();
                    name_txt.Text = user.name.ToString();
                    family_txt.Text = user.family.ToString();
                    profile_img.ImageUrl = "~\\assets\\uploads\\profiles\\" + user.image.ToString();
                    bio_txt.Text = user.bio.ToString();
                }
            }
            else
            {
                Response.Redirect("ShowUser.aspx");
            }



        }

        protected void edit_user_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            UserController userController = new UserController();

            bool result;

            Entity.User u = userController.GetUser(id);

            if (FileUpLoad1.HasFile)
            {
                File.Delete(Server.MapPath("~\\assets\\uploads\\profiles\\") + u.image.ToString());
                FileUpLoad1.SaveAs(Server.MapPath("~\\assets\\uploads\\profiles\\") + FileUpLoad1.FileName);
                result = userController.EditUser(id, password_txt.Text.ToString(), name_txt.Text.ToString(), family_txt.Text.ToString(), FileUpLoad1.FileName, bio_txt.Text.ToString());
            }
            else
            {
                result = userController.EditUser(id, password_txt.Text.ToString(), name_txt.Text.ToString(), family_txt.Text.ToString(), u.image.ToString(), bio_txt.Text.ToString());
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