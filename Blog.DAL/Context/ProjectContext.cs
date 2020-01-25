using Blog.DAL.Entity.ORM.Entity.Concrete;
using Blog.Map.Option;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=.; Database=Blogs; integrated security=true";
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new PostMap());

            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));


            base.OnModelCreating(modelBuilder);
        }

       
    }
}
