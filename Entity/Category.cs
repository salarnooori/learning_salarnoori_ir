using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Category
    {
        public int id { get; set; }
        public int maincategory_id { get; set; }
        public string maincategory_name { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string details { get; set; }
    }

    public class MainCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int quantity { get; set; }
    }

    public class AllCategory
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
