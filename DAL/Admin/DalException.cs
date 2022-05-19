using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Admin
{
    public class DalException : Exception
    {
        private string message;
        private string route;

        public DalException(string message, string route)
        {
            this.message = message;
            this.route = route;
        }

        public string GetMessage()
        {
            return message;
        }

        public string GetRoute()
        {
            return route;
        }
    }
}
