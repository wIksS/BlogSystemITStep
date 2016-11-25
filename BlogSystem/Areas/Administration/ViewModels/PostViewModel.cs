using BlogSystem.Common.Mapping;
using BlogSystem.Models;
using BlogSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSystem.Areas.Administration.ViewModels
{
    public class PostViewModel : IMapFrom<Post>, IMapTo<Post>
    {
        public int Id { get; set; }

        [Display(Name ="Title content")]
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        public string Content { get; set; }

        public ApplicationUserViewModel Author { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public SelectList Users { get; set; }
    }
}