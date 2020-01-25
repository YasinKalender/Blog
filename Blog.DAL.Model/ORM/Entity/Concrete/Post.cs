using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DAL.Model.ORM.Entity.Concrete
{
    public class Post : BaseEntity
    {
        public string Header { get; set; }

        public string Content { get; set; }

        public bool Onay { get; set; }

        public string Picture { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }


    }
}
