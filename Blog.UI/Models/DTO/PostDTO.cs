using Blog.DAL.Entity.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.UI.Models.DTO
{
    public class PostDTO : BaseEtnityDTO
    {

        public string Header { get; set; }

        public string Content { get; set; }

        public string Picture { get; set; }


        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }


    }
}