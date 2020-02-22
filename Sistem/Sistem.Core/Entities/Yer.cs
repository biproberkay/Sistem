using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Entities
{
    public class Yer
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Yer()
        {
            YerChilds = new HashSet<Yer>();
        }
        public int Level { get; set; }
        public int? ParentId { get; set; }
        public Yer Parent { get; set; }
        public virtual ICollection<Yer> YerChilds { get; set; }
    }
}
