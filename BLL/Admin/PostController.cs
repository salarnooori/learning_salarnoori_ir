using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.Admin;


namespace BLL.Admin
{
    public class PostController
    {
        PostRepository postRepository = new PostRepository();

        public bool AddPost(string subject, string modifydate, int author_id, int category_id, string image, string context = "", string summery = "")
        {
            try
            {
                return postRepository.AddPost(subject, modifydate, author_id, category_id, image, context, summery);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : AddPost() in PostController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public List<Post> GetAll()
        {
            try
            {
                return postRepository.GetAll();
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : GetAll() in PostController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public List<Post> Get5Post()
        {
            try
            {
                return postRepository.Get5Post();
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : Get5Post() in PostController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public Post GetPost(int id)
        {
            try
            {
                return postRepository.GetPost(id);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : GetPost() in PostController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public bool EditPost(int id, string subject, string context = "", string summery = "")
        {
            try
            {
                return postRepository.EditPost(id, subject, context, summery);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : EditPost() in PostController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public bool DeletePost(int id)
        {
            try
            {
                return postRepository.DeletePost(id);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : DeletePost() in PostController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

    }
}
