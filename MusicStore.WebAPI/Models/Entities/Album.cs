namespace MusicStore.WebAPI.Models.Entities
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
    }
}
