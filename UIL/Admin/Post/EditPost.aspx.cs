using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BLL.Admin;

namespace UIL.Admin.Post
{
    public partial class EditPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);

            PostController postController = new PostController();

            Entity.Post post = postController.GetPost(id);
            post = postController.GetPost(id);

            if (post != null)
            {
                if (subject_txt.Text == "")
                {
                    subject_txt.Text =post.subject.ToString();
                    modifydate_txt.Text = post.modifydate.ToString();


                    UserController userController = new UserController();
                    CategoryController categoryController = new CategoryController();

                    if (post.category_id <= 4)
                    {
                        post.category_name = categoryController.GetMainCategoryById(post.category_id).name;
                    }
                    else
                    {
                        post.category_name = categoryController.GetCategory(post.category_id).name;
                    }

                    post.author_name = userController.GetUser(post.author_id).name;

                    
                    author_id_txt.Text = post.author_name.ToString();
                    category_id_txt.Text = post.category_name.ToString();


                    context_txt.Text = post.context.ToString();
                    summery_txt.Text = post.summery.ToString();

                    post_img.ImageUrl = "~\\assets\\uploads\\posts\\" + post.image.ToString();
                }
            }
            else
            {
                Response.Redirect("ShowPost.aspx");
            }

        }

        protected void edit_post_btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            PostController PostControler = new PostController();
            bool result = PostControler.EditPost(id, subject_txt.Text.ToString(), context_txt.Text.ToString(), summery_txt.Text.ToString());

            if (result)
            {
                Response.Redirect("ShowPost.aspx");
            }
            else
            {
                Response.Write("<script>alert('خطا در ثبت اطلاعات در پایگاه داده.')</script>");
            }
        }
    }
}