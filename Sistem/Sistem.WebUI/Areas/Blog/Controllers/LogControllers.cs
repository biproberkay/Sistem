using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;

namespace Sistem.WebUI.Areas.Blog.Controllers
{
    public class TLogController : MediaLogController<TextLog>
    {
        private IServiceRepository<TextLog> _tService;
        public TLogController(IServiceRepository<TextLog> tService) : base(tService)
        {
            _tService = tService;
        }

    }
    public class PLogController : MediaLogController<PictureLog>
    {
        private IServiceRepository<PictureLog> _tService;
        public PLogController(IServiceRepository<PictureLog> tService) : base(tService)
        {
            _tService = tService;
        }

    }
    public class VLogController : MediaLogController<VideoLog>
    {
        private IServiceRepository<VideoLog> _tService;
        public VLogController(IServiceRepository<VideoLog> tService) : base(tService)
        {
            _tService = tService;
        }

    }
    public class SLogController : MediaLogController<SoundLog>
    {
        private IServiceRepository<SoundLog> _tService;
        public SLogController(IServiceRepository<SoundLog> tService) : base(tService)
        {
            _tService = tService;
        }

    }
}