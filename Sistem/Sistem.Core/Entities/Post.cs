using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; } 

        //sonraki aşamada eklenecek özellikler
        /*
        public Int64? ArticleViewCount { get; set; }
        
        public Int64? ArticleViewCount { get; set; }

        public string ArticleStatus { get; set; }

        public bool IsOpenForComment { get; set; }

         */

        //alan ilişkisi için
        public Yer Yer { get; set; }
        public int YerId { get; set; } 
    }
}
