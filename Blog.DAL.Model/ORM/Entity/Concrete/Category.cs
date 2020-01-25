using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DAL.Model.ORM.Entity.Concrete
{
    public class Category : BaseEntity
    {

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<Post> Posts { get; set; }
    }
}
