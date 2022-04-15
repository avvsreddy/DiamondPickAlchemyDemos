using MusicStore.WebAPI.Models.Entities;
using System.Collections.Generic;

namespace MusicStore.WebAPI.Models.Data
{
    public interface IMusicStoreRepository
    {
        List<Album> GetAlbums();
        Album GetAlbum(int id);
        List<Genre> GetGenres();
        Genre GetGenre(int id);
        List<Artist> GetArtists();
        Artist GetArtist(int id);

        List<Album> GetAlbumsByArtist(int artistId);
        List<Album> GetAlbumsByGenre(int genreId);

        List<Album> GetAlbumsWithGenreAndArtist();
        Album CreateAlbum(Album album);
        Album UpdateAlbum(int id, Album album);
        void DeleteAlbum(int id);
        Artist CreateArtist(Artist artist);
        Artist UpdateArtist(int id, Artist artist);
        void DeleteArtist(int id);
        Genre CreateGenre();
        Genre UpdateGenre(int id, Genre genre);
        void DeleteGenre(int id);
        
    }
}
