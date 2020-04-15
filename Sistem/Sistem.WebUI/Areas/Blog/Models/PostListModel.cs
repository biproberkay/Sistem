using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistem.WebUI.Areas.Blog.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int CurrentYerId { get; set; }

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
    }
    public class PostListModel
    {
        public PagingInfo PagingInfo { get; set; }
        public List<Post> Posts { get; set; }
        public int YerId { get; set; }  
    }
}
