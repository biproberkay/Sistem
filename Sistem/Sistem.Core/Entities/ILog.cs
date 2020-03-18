using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Entities
{
    public interface ILog
    {
        public User? Logger { get; set; }
        public DateTime CreateDT { get; set; }
        public DateTime? ModifyDT { get; set; }
        public DateTime? DeleteDT { get; set; } 

    }
}
