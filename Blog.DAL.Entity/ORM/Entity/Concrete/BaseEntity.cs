using Blog.DAL.Entity.ORM.Entity.Abstract;
using Blog.DAL.Entity.ORM.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Entity.ORM.Entity.Concrete
{
    public class BaseEntity : ICore
    {

        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        private Status _status = Status.Active;
        public Status status { get { return _status; } set { _status = value; } }
    }
}
