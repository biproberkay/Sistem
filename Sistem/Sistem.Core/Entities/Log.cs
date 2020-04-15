using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateRemoved { get; set; } 
    }

    public class Text
    {
        public string Begining { get; set; }
        public string Develop { get; set; }
        public string Ending { get; set; } 
    }
    public class Picture
    {
        public string Url { get; set; }
        public string Name { get; set; }

    }
    public class Video
    {
        public string YoutubeLink { get; set; }

    }
    public class Sound
    {
        public string DriveLink { get; set; } 
    }

    public class PostDeneme 
    {
        public Text Makale { get; set; }
        public Picture PhotoLog { get; set; }
        public Video Vlog { get; set; }
        public Sound SesLog { get; set; }
    }
}
