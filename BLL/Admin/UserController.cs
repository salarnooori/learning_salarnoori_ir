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
            try
            {
                return userRepository.AddUser(username, password, email, name, family, image, bio);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : AddUser() in UserController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return userRepository.GetAll();
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : GetAll() in UserController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public User GetUser(int id)
        {
            try
            {
                return userRepository.GetUser(id);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : GetUser() in UserController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public bool EditUser(int id, string password, string name, string family, string image, string bio)
        {
            try
            {
                return userRepository.EditUser(id, password, name, family, image, bio);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : EditUser() in UserController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                return userRepository.DeleteUser(id);
            }
            catch (DalException err)
            {
                string message = err.GetMessage();
                string route = err.GetRoute();
                route += "BLL : DeleteUser() in UserController.cs -> ";
                BllException bllException = new BllException(message, route);
                throw bllException;
            }
        }

    }
}
