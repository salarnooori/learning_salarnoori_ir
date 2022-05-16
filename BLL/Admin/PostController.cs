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
            return postRepository.AddPost(subject, modifydate, author_id, category_id, image, context, summery);
        }

        public List<Post> GetAll()
        {
            return postRepository.GetAll();
        }

        public List<Post> Get5Post()
        {
            return postRepository.Get5Post();
        }

        public Post GetPost(int id)
        {
            return postRepository.GetPost(id);
        }

        public bool EditPost(int id, string subject, string context = "", string summery = "")
        {
            return postRepository.EditPost(id, subject, context, summery);
        }

        public bool DeletePost(int id)
        {
            return postRepository.DeletePost(id);
        }

    }
}
