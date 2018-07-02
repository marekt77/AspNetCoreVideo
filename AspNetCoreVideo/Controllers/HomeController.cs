using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Models;
using AspNetCoreVideo.Services;
using AspNetCoreVideo.ViewModels;

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
                    Genre = Enum.GetName(typeof(Genres), video.GenreID)
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
                    Genre = Enum.GetName(typeof(Genres), model.GenreID)
                });
            }
        }
    }
}
