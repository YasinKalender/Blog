using Blog.DAL.Entity.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Map.Option
{
    public class UserMap : CoreMap<User>
    {
        public UserMap()
        {

            ToTable("dbo.Users");

            Property(i => i.FirstName).HasMaxLength(20).IsRequired();
            Property(i => i.LastName).HasMaxLength(20).IsRequired();
            Property(i => i.UserName).HasMaxLength(20).IsRequired();
            Property(i => i.Password).HasMaxLength(10).IsRequired();

            HasMany(i => i.Posts)
                .WithRequired(i => i.User)
                .HasForeignKey(i => i.UserID)
                .WillCascadeOnDelete(false);


        }



    }
}
