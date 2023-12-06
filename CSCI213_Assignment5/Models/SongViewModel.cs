using Microsoft.AspNetCore.Mvc.Rendering;

namespace CSCI213_Assignment5.Models
{
    public class SongViewModel
    {
        public List<Song>? Songs { get; set; }
        public SelectList? Genres { get; set; }
        public SelectList? Artists { get; set; }
        public string? SearchGenre { get; set; }
        public string? SearchArtist { get; set; }
    }
}
