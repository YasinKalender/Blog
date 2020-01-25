using Blog.DAL.Entity.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Map.Option
{
    public class CategoryMap : CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");

            Property(i => i.CategoryName).HasMaxLength(20).IsRequired();
            Property(i => i.CategoryDescription).IsRequired();

            HasMany(i => i.Posts)
                .WithRequired(i => i.Category)
                .HasForeignKey(i => i.CategoryID)
                .WillCascadeOnDelete(false);



        }


    }
}
