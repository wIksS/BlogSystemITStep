using AutoMapper;
using BlogSystem.Common.Mapping;
using BlogSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSystem.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController()
            :this(new BlogSystemData())
        { }

        public BaseController(IBlogSystemData data)
        {
            this.Data = data;
        }

        protected IBlogSystemData Data{ get; private set; }

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}