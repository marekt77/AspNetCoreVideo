using AspNetCoreVideo.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideo.ViewModels
{
    public class VideoEditViewModel
    {
        public int ID { get; set; }
        [Required, MinLength(1), MaxLength(80)]
        public string Title { get; set; }
        public Genres Genre { get; set; }
    }
}
