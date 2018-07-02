using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Etities
{
    public class Video
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int GenreID { get; set; }
    }
}
