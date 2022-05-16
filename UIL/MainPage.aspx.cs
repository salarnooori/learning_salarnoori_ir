using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin;
using Entity;

namespace UIL
{
    public partial class MainPage : System.Web.UI.Page
    {
        public List<Post> carusel_posts = new List<Post>();
        public List<Post> all_posts = new List<Post>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            PostController postController = new PostController();

            carusel_posts = postController.Get5Post(); 
            all_posts = postController.GetAll();


        }
    }
}