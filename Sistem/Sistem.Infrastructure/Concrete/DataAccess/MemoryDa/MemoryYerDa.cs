using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.MemoryDa
{
    public class MemoryYerDa : MemoryDaRepository<Yer>
    {
        public override List<Yer> GetAll()
        {

            var yerler = new List<Yer>()
            {
                new Yer{Id=1, Level=0, Title="Bilgisayar Programcılığı"},
                new Yer{Id=2, Level=1, ParentId=1, Title="Yazılım"},
                new Yer{Id=3, Level=1, ParentId=1, Title="Donanım"},
                new Yer{Id=4, Level=1, ParentId=1, Title="Grafik"}
            };
            return yerler;
        }

        public override Yer GetById(int id)
        {
            var yerler = new List<Yer>()
            {
                new Yer{Id=1, Level=0, Title="Bilgisayar Programcılığı"},
                new Yer{Id=2, Level=1, ParentId=1, Title="Yazılım"},
                new Yer{Id=3, Level=1, ParentId=1, Title="Donanım"},
                new Yer{Id=4, Level=1, ParentId=1, Title="Grafik"}
            };
            return yerler.Find(y=>y.Id==id);
        }
    }
}
