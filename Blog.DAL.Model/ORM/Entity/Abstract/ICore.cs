using Blog.DAL.Model.ORM.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DAL.Model.ORM
{
    interface ICore
    {
        int ID { get; set; }

        DateTime AddDate { get; set; }

        DateTime? DeleteDate { get; set; }

        DateTime? UpdateDate { get; set; }

        Status status { get; set; }


    }
}
