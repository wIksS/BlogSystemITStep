using BlogSystem.Common.Mapping;
using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSystem.ViewModels
{
    public class ApplicationUserViewModel : IMapFrom<ApplicationUser>
    {
        public string UserName { get; set; }

        public string Email { get; set; }    
    }
}