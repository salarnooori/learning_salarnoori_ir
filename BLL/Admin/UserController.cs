using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL.Admin;


namespace BLL.Admin
{
    public class UserController
    {
        UserRepository userRepository = new UserRepository();

        public bool AddUser(string username, string password, string email, string name, string family, string image, string bio)
        {
            return userRepository.AddUser(username, password, email, name, family, image, bio);
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetUser(int id)
        {
            return userRepository.GetUser(id);
        }

        public bool EditUser(int id, string password, string name, string family, string image, string bio)
        {
            return userRepository.EditUser(id, password, name, family, image, bio);
        }

        public bool DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

    }
}
