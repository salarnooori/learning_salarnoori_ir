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

            PostController PostController = new PostController();

            List<Entity.Post> posts = PostController.GetAll();

            UserController userController = new UserController();
            CategoryController categoryController = new CategoryController();

            for(int i = 0; i < posts.Count; i++)
            {
                if(posts[i].category_id <= 4)
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

        protected void posts_gv_RowDeleting(object sender, GridViewDeleteEventArgs e)
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
        protected void posts_gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(posts_gv.DataKeys[e.NewEditIndex].Value.ToString());

            Response.Redirect("EditPost.aspx?id=" + id.ToString());
        }
    }
}