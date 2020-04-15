using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistem.WebUI.Areas.Blog.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        [StringLength(maximumLength:5000,ErrorMessage ="Bişeyler Ters Gitti", MinimumLength = 500)]
        public string Body { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        /*/sonraki aşamada eklenecek özellikler
        public Int64? ArticleViewCount { get; set; }

        public Int64? ArticleViewCount { get; set; }

        public string ArticleStatus { get; set; }

        public bool IsOpenForComment { get; set; }
        */

        //alan ilişkisi için

        public Yer Yer { get; set;  }

    }
}
