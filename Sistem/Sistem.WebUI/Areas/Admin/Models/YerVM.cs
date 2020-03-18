using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistem.WebUI.Areas.Admin.Models
{
    public class YerVM
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //public Yer()
        //{
        //    YerChilds = new HashSet<Yer>();
        //}
        public int Level { get; set; }
        public int? ParentId { get; set; }
        public Yer Parent { get; set; }
        public List<Yer> YerChilds { get; set; }
        public List<Post> Posts { get; set; }
    }
}
