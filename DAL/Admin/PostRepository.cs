using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace DAL.Admin
{
    public class PostRepository
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public bool AddPost(string subject, string modifydate, int author_id, int category_id, string image, string context="", string summery="")
        {
            OpenConn();
            SetQuery("INSERT INTO Posts(subject,modifydate,author_id,category_id,image,context,summery) VALUES (\'" + subject + "\',\'" + modifydate + "\',\'" + author_id.ToString() + "\',\'" + category_id.ToString() + "\',\'" + image + "\',\'" + context + "\',\'" + summery + "\');");
            return CloseConn();
        }

        public List<Post> Get5Post()
        {
            OpenConn();
            SetQuery("SELECT TOP 5 * FROM Posts ORDER BY modifydate DESC;", 1);
            List<Post> posts = new List<Post>();
            while (dr.Read())
            {
                Post post = new Post();
                post.id = int.Parse(dr[0].ToString());
                post.subject = dr[1].ToString();
                post.modifydate = dr[2].ToString();
                post.author_id = int.Parse(dr[3].ToString());
                post.category_id = int.Parse(dr[4].ToString());
                post.image = dr[5].ToString();
                post.context = dr[6].ToString();
                post.summery = dr[7].ToString();

                posts.Add(post);
            }
            conn.Close();
            return posts;

        }

        public List<Post> GetAll()
        {
            OpenConn();
            SetQuery("SELECT * FROM Posts;", 1);
            List<Post> posts = new List<Post>();
            while (dr.Read())
            {
                Post post = new Post();
                post.id = int.Parse(dr[0].ToString());
                post.subject = dr[1].ToString();
                post.modifydate = dr[2].ToString();
                post.author_id = int.Parse(dr[3].ToString());
                post.category_id = int.Parse(dr[4].ToString());
                post.image = dr[5].ToString();
                post.context = dr[6].ToString();
                post.summery = dr[7].ToString();

                posts.Add(post);
            }
            conn.Close();
            return posts;

        }

        public Post GetPost(int id)
        {
            OpenConn();
            SetQuery("SELECT * FROM Posts WHERE id =\'" + id.ToString() + "\';", 1);
            dr.Read();

            Post post = new Post();
            post.id = int.Parse(dr[0].ToString());
            post.subject = dr[1].ToString();
            post.modifydate = dr[2].ToString();
            post.author_id = int.Parse(dr[3].ToString());
            post.category_id = int.Parse(dr[4].ToString());
            post.image = dr[5].ToString();
            post.context = dr[6].ToString();
            post.summery = dr[7].ToString();

            conn.Close();
            return post;
        }

        public bool EditPost(int id, string subject, string context = "", string summery = "")
        {
            OpenConn();
            SetQuery("UPDATE Posts SET subject=\'" + subject + "\', context=\'" + context + "\', summery=\'" + summery + "\' WHERE id=\'" + id + "\'");
            return CloseConn();
        }


        public bool DeletePost(int id)
        {
            OpenConn();
            SetQuery("DELETE FROM Posts WHERE id=\'" + id + "\';");
            return CloseConn();
        }

        private void OpenConn()
        {
            conn = new SqlConnection(Entity.ConnecectionString.connection1);
            conn.Open();
        }

        private void SetQuery(string query, int mode = 0)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            if (mode == 1)
            {
                dr = cmd.ExecuteReader();
            }


        }

        private bool CloseConn()
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }


    }
}
