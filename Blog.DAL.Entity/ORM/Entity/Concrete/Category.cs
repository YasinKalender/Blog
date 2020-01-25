using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Entity.ORM.Entity.Concrete
{
    public class Category : BaseEntity
    {

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<Post> Posts { get; set; }
    }
}
