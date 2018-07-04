using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Entities;

namespace AspNetCoreVideo.Services
{
    public interface IVideoData
    {
        List<Video> GetAll();

        Video Get(int id);

        void Add(Video newVideo);
    }
}
