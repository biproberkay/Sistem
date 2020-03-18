using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Entities
{
    public class MediaLog : ILog, IMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Logger { get; set; }
        public DateTime CreateDT { get; set; }
        public DateTime? ModifyDT { get; set; }
        public DateTime? DeleteDT { get; set; }
    }
}
