using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin
{
    public class BllException: Exception
    {
        private string message;

        private string route;


        public BllException(string message,string route)
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
