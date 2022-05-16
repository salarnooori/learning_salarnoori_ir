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
            UserController userController = new UserController();

            List<Entity.User> users = userController.GetAll();

            for(int i = 0; i < users.Count; i++)
            {
                users[i].image = "~\\assets\\uploads\\profiles\\" + users[i].image.ToString();
            }

            users_gv.DataSource = users;
            users_gv.DataBind();
        }

        protected void users_gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
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
        protected void users_gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(users_gv.DataKeys[e.NewEditIndex].Value.ToString());

            Response.Redirect("EditUser.aspx?id=" + id.ToString());
        }
    }
}