using MusicStore.WebAPI.Models.Entities;
using System.Collections.Generic;

namespace MusicStore.WebAPI.Models.Data
{

    // TODO - Implement all the below methods

    public class MusicStoreRepository : IMusicStoreRepository
    {
        public Album CreateAlbum(Album album)
        {
            throw new System.NotImplementedException();
        }

        public Artist CreateArtist(Artist artist)
        {
            throw new System.NotImplementedException();
        }

        public Genre CreateGenre()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAlbum(int id)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteArtist(int id)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteGenre(int id)
        {
            throw new System.NotImplementedException();
        }

        public Album GetAlbum(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Album> GetAlbums()
        {
            throw new System.NotImplementedException();
        }

        public List<Album> GetAlbumsWithGenreAndArtist()
        {
            throw new System.NotImplementedException();
        }

        public Artist GetArtist(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Artist> GetArtists()
        {
            throw new System.NotImplementedException();
        }

        public Genre GetGenre(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Genre> GetGenres()
        {
            throw new System.NotImplementedException();
        }

        public List<Album> GetTopSellingAlbums(int count)
        {
            throw new System.NotImplementedException();
        }

        public Album UpdateAlbum(int id, Album album)
        {
            throw new System.NotImplementedException();
        }

        public Artist UpdateArtist(int id, Artist artist)
        {
            throw new System.NotImplementedException();
        }

        public Genre UpdateGenre(int id, Genre genre)
        {
            throw new System.NotImplementedException();
        }
    }
}
