using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Admin
{
    public class UserRepository
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        public bool AddUser(string username, string password, string email, string name, string family, string image, string bio)
        {
            OpenConn();
            SetQuery("INSERT INTO Users(username,password,email,name,family,image,bio) VALUES (\'" + username + "\',\'" + password + "\',\'" + email+ "\',\'" + name + "\',\'" + family + "\',\'" + image + "\',\'" + bio + "\');");
            return CloseConn();
        }

        public List<User> GetAll()
        {
            OpenConn();
            SetQuery("SELECT * FROM Users;",1);
            List<User> users = new List<User>();
            while (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr[0].ToString());
                user.username = dr[1].ToString();
                user.password = dr[2].ToString();
                user.email = dr[3].ToString();
                user.name = dr[4].ToString();
                user.family = dr[5].ToString();
                user.image = dr[6].ToString();
                user.bio = dr[7].ToString();

                users.Add(user);
            }
            conn.Close();
            return users;
        }

        public User GetUser(int id)
        {
            OpenConn();
            SetQuery("SELECT * FROM Users WHERE id =\'" + id.ToString() + "\';", 1);
            dr.Read();
            User user = new User();
            user.id = int.Parse(dr[0].ToString());
            user.name = dr[1].ToString();
            user.username = dr[1].ToString();
            user.password = dr[2].ToString();
            user.email = dr[3].ToString();
            user.name = dr[4].ToString();
            user.family = dr[5].ToString();
            user.image = dr[6].ToString();
            user.bio = dr[7].ToString();

            conn.Close();
            return user;
        }

        public bool EditUser(int id, string password, string name, string family, string image, string bio)
        {
            OpenConn();
            SetQuery("UPDATE Users SET password=\'" + password + "\', name=\'" + name + "\', family=\'" + family + "\', image=\'" + image + "\', bio=\'" + bio + "\' WHERE id=\'" + id + "\'");
            return CloseConn();
        }

        public bool DeleteUser(int id)
        {
            OpenConn();
            SetQuery("DELETE FROM Users WHERE id=\'" + id + "\';");
            return CloseConn();
        }

        private void OpenConn()
        {
            conn = new SqlConnection(Entity.ConnecectionString.connection1);
            conn.Open();
        }

        private void SetQuery(string query, int mode=0)
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
