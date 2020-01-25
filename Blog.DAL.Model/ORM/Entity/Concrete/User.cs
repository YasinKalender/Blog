using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DAL.Model.ORM.Entity.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public List<Post> Posts { get; set; }

    }
}
