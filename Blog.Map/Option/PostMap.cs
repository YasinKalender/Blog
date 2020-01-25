using Blog.DAL.Entity.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Map.Option
{
    public class PostMap : CoreMap<Post>
    {
        public PostMap()
        {
            ToTable("dbo.Posts");

            Property(i => i.Header).IsRequired();
            Property(i => i.Content).IsRequired();
            Property(i => i.Picture).IsRequired();
            Property(i => i.Onay).IsOptional();

            HasRequired(i => i.Category)
                .WithMany(i => i.Posts)
                .HasForeignKey(i => i.CategoryID)
                .WillCascadeOnDelete(false);

            HasRequired(i => i.User)
                .WithMany(i => i.Posts)
                .HasForeignKey(i => i.UserID)
                .WillCascadeOnDelete(false);



        }


    }
}
