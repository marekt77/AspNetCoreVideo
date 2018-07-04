using System.Collections.Generic;
using AspNetCoreVideo.Entities;

namespace AspNetCoreVideo.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();

        Video Get(int id);

        void Add(Video newVideo);
    }
}
