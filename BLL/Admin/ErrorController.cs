using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Admin;

namespace BLL.Admin
{
    public class ErrorController
    {
        public bool AddError(string message,string route, string ip, string values)
        {
            ErrorRepository errorRepository = new ErrorRepository();
            DateTime date = DateTime.Now;
            return errorRepository.AddError(message, route, ip, values, date);
        }
    }
}
