using Blog.DAL.Context;
using Blog.DAL.Entity.ORM.Entity.Concrete;
using Blog.UI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class HomeController : Controller
    {

        private ProjectContext db = new ProjectContext();

        // GET: Home
        public ActionResult Index()
        {
            var post = db.Posts.Where(i => i.status == DAL.Entity.ORM.Entity.Enum.Status.Active || i.status == DAL.Entity.ORM.Entity.Enum.Status.Update).Select(i => new PostDTO { Header=i.Header, Content=i.Content, Picture = i.Picture,CategoryID=i.CategoryID, UserID=i.UserID});

            return View(post.ToList());
        }

     






    }
}