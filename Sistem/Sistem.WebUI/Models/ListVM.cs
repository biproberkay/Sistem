using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistem.WebUI.Models
{
    public class ListVM
    {
        public List<Post> Posts { get; set; }
        public List<Yer> Yers { get; set; }
    }
}
