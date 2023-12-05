namespace CSCI213_Assignment5.Models
{
    public class Song
    {
        public required int SongID { get; set; }
        public required string Title { get; set; }
        public required string Artist { get; set; }
        public required decimal Price { get; set; }
        public required int Inventory { get; set; }
        public required string Genre { get; set; }
        public required Boolean Instrumental { get; set; }
    }
}
