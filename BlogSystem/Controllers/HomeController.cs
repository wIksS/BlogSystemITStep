using BlogSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using BlogSystem.Models;
using static BlogSystem.App_Start.NinjectWebCommon;
using BlogSystem.Data;
using BlogSystem.Services.Contracts;
using BlogSystem.Common.Caching;

namespace BlogSystem.Controllers
{
    public class HomeController : BaseController
    {
        private IPostService postsService;
        private ICacheService cache;
        public HomeController(IPostService service, ICacheService cache)
        {
            this.cache = cache;
            this.postsService = service;
        }

        public ActionResult Index()
        {
            var dbPosts = this.cache.Get<ICollection<Post>>("allPosts", () =>
             {
                 return postsService.GetAll().ToList();
             }, 60); 

            var posts = Mapper.Map<ICollection<Post>,
                ICollection<PostViewModel>>(dbPosts);

            return View(posts);
        }

        public ActionResult Info(int id)
        {
            var post = Mapper.Map<PostViewModel>(this.postsService.Find(id));
            if (post.Content.Length > 30)
            {
                post.SubHeader = post.Content.Substring(0, 30);
            }
            else
            {
                post.SubHeader = post.Content;
            }

            return View(post);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}