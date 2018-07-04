using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AspNetCoreVideo.Services;
using AspNetCoreVideo.ViewModels;
using AspNetCoreVideo.Entities;

namespace AspNetCoreVideo.Controllers
{
    public class HomeController : Controller
    {
        private IVideoData _videos;

        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }

        public ViewResult Index()
        {
            var model = _videos.GetAll().Select(video =>
                new VideoViewModel
                {
                    ID = video.ID,
                    Title = video.Title,
                    Genre = video.Genre.ToString()
                });

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _videos.Get(id);

            if (model == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(new VideoViewModel
                {
                    ID = model.ID,
                    Title = model.Title,
                    Genre = model.Genre.ToString()
                });
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VideoEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var video = new Video
                {
                    Title = model.Title,
                    Genre = model.Genre
                };

                _videos.Add(video);

                return RedirectToAction("Details", new { id = video.ID });
            }
            return View();
        }
    }
}
