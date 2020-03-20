using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistem.WebUI.Models
{
    public class YerListVM
    {
        public List<Yer> Yerler { get; set; }
        public Yer SelectedYer { get; set; } 
    }
}
