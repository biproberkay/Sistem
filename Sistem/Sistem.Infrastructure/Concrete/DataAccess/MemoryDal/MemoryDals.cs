using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.MemoryDal
{
    public class YerMemoryDal : MemoryDalRepository<Yer>
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
    }
    public class TLogMemoryDal : MemoryDalRepository<TextLog>
    {
        /* eğer(ezilecek-se)
         */
        public override List<TextLog> GetAll()
        {
            List<TextLog> TLogs = new List<TextLog>()
            {
                new TextLog() { Id=1, Title="Text1", Description="Description 1 ", CreateDT = DateTime.Now, } ,
                new TextLog() { Id=2, Title="Text2", Description="Description 2 ", CreateDT = DateTime.Now, } ,
                new TextLog() { Id=3, Title="Text3", Description="Description 3 ", CreateDT = DateTime.Now, } ,
                new TextLog() { Id=4, Title="Text4", Description="Description 4 ", CreateDT = DateTime.Now, } ,
                new TextLog() { Id=5, Title="Text5", Description="Description 5 ", CreateDT = DateTime.Now, } ,
            };

            return TLogs;
        }
    }
    public class PLogMemoryDal : MemoryDalRepository<PictureLog> {/**
        public override List<PictureLog> GetAll()
        {
            var plogs = mediaLogs;
            return plogs;
        }
         **/}
    public class VLogMemoryDal : MemoryDalRepository<VideoLog> { }
    public class SLogMemoryDal : MemoryDalRepository<SoundLog> { }
}
