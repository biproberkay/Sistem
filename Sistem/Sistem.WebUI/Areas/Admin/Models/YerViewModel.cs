using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistem.WebUI.Areas.Admin.Models
{
    public class YerViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Level { get; set; }
        public int? ParentId { get; set; }
    }
}
