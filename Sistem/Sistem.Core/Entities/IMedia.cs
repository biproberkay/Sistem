using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Entities
{
    public interface IMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
    }
}
