using System.Collections.Generic;
using System.Linq;
using AspNetCoreVideo.Entities;

namespace AspNetCoreVideo.Services
{
    public class MockVideoData : IVideoData
    {
        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video {ID=1, Genre = Models.Genres.Comedy, Title = "Shreck"},
                new Video {ID=2, Genre = Models.Genres.Comedy, Title = "Despicable Me"},
                new Video {ID=3, Genre = Models.Genres.Comedy, Title = "Megamind"}
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

        public void Add(Video newVideo)
        {
            newVideo.ID = _videos.Max(v => v.ID) + 1;
            _videos.Add(newVideo);
        }

        public int Commit()
        {
            return 0;
        }

        private List<Video> _videos;
    }
}
