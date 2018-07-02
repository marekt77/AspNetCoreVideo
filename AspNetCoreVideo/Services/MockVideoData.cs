using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Etities;

namespace AspNetCoreVideo.Services
{
    public class MockVideoData : IVideoData
    {
        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video {ID=1, GenreID = 1, Title = "Shreck"},
                new Video {ID=2, GenreID = 1, Title = "Despicable Me"},
                new Video {ID=3, GenreID = 1, Title = "Megamind"}
            };
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }

        public Video Get(int id)
        {
            return _videos.FirstOrDefault(v => v.ID.Equals(id));
        }

        private IEnumerable<Video> _videos;
    }
}
