using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Post
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string modifydate { get; set; }
        public int author_id { get; set; }
        public int category_id { get; set; }
        public string author_name { get; set; }
        public string category_name { get; set; }
        public string image { get; set; }
        public string context { get; set; }
        public string summery { get; set; }
    }
}
