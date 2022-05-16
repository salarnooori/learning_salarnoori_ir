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
    public partial class AddPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CategoryController categoryController = new CategoryController();
                List<Entity.MainCategory> mainCategories = categoryController.GetMainCategory();
                List<Entity.Category> categories = categoryController.GetAll();

                List<Entity.AllCategory> allCategories = new List<Entity.AllCategory>();

                for (int i = 0; i < mainCategories.Count; i++)
                {
                    Entity.AllCategory c = new Entity.AllCategory();
                    c.name = mainCategories[i].name;
                    c.id = mainCategories[i].id;

                    allCategories.Add(c);
                }

                for (int i = 0; i < categories.Count; i++)
                {
                    Entity.AllCategory c = new Entity.AllCategory();
                    c.name = categories[i].name;
                    c.id = categories[i].id;

                    allCategories.Add(c);
                }

                category_id_txt.DataSource = allCategories; ;
                category_id_txt.DataTextField = "name";
                category_id_txt.DataValueField = "id";
                category_id_txt.DataBind();

                UserController userController = new UserController();
                List<Entity.User> users = userController.GetAll();

                author_id_txt.DataSource = users;
                author_id_txt.DataTextField = "username";
                author_id_txt.DataValueField = "id";
                author_id_txt.DataBind();
            }

        }

        protected void add_post_btn_Click(object sender, EventArgs e)
        {
            PostController PostController = new PostController();

            bool result;

            if (FileUpLoad1.HasFile)
            {
                FileUpLoad1.SaveAs(Server.MapPath("~\\assets\\uploads\\posts\\") + FileUpLoad1.FileName);
                result = PostController.AddPost(subject_txt.Text.ToString(), modifydate_txt.Text.ToString(), int.Parse(author_id_txt.SelectedItem.Value), int.Parse(category_id_txt.SelectedItem.Value), FileUpLoad1.FileName, context_txt.Text.ToString(), summery_txt.Text.ToString());
            }
            else
            {
                Random random = new Random();
                int rand = random.Next(2) + 1;
                result = PostController.AddPost(subject_txt.Text.ToString(), modifydate_txt.Text.ToString(), int.Parse(author_id_txt.SelectedItem.Value), int.Parse(category_id_txt.SelectedItem.Value), "defult" + rand.ToString() + ".jpg", context_txt.Text.ToString(), summery_txt.Text.ToString());
            }

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