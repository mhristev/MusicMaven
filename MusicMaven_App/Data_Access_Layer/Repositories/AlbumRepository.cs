using System;
using System.Data;using Business_Logic.Enums;using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;
using Microsoft.Data.SqlClient;namespace Data_Access_Layer.Repositories
{
	public class AlbumRepository : BaseRepository, IAlbumRepository
	{
		public AlbumRepository()
		{
		}        private Album MapAlbum(IDataReader reader)        {            string albumId = reader.GetString(reader.GetOrdinal("id"));            // Create new album object            Album album = new Album(                albumId,                reader.GetString(reader.GetOrdinal("name")),                reader.GetString(reader.GetOrdinal("image")),                (MUSIC_UNIT_TYPE)Enum.Parse(typeof(MUSIC_UNIT_TYPE), reader.GetString(reader.GetOrdinal("type"))),                (GENRE_TYPE)Enum.Parse(typeof(GENRE_TYPE), reader.GetString(reader.GetOrdinal("genre"))),                new List<Artist>(),                reader.GetDouble(reader.GetOrdinal("avgRating")),                reader.GetDateTime(reader.GetOrdinal("releaseDate"))            );            // Add artist to album's list of artists            Artist artist = new Artist(                reader.GetString(reader.GetOrdinal("artistId")),                reader.GetString(reader.GetOrdinal("artistName")),                reader.GetString(reader.GetOrdinal("artistImage")),                (MUSIC_UNIT_TYPE)Enum.Parse(typeof(MUSIC_UNIT_TYPE), reader.GetString(reader.GetOrdinal("artistType"))),                (ARTIST_TYPE)reader.GetInt32(reader.GetOrdinal("artistArtistType")),                reader.GetFloat(reader.GetOrdinal("artistAvgRating"))            );            album.Artists.Add(artist);            return album;        }        public Album? GetById(string id)        {            string sql = @"
        SELECT a.id, a.name, a.image, a.type, a.genre, a.avgRating, a.releaseDate, 
               ar.id AS artistId, ar.name AS artistName, ar.image AS artistImage, 
               ar.type AS artistType, ar.artistType AS artistArtistType, ar.avgRating AS artistAvgRating
        FROM Album a
        JOIN AlbumArtists aa ON a.id = aa.albumId
        JOIN Artist ar ON aa.artistId = ar.id
        WHERE a.id = @Id";            return ExecuteQuery(sql, MapAlbum, (command) =>            {                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar) { Value = id });            }).FirstOrDefault();        }        public List<Album> GetAlbumsForArtistId(string id)        {            throw new NotImplementedException();        }        public List<Album> GetNewReleasedAlbums(int albumCount)        {            throw new NotImplementedException();        }        public List<Album> GetAlbumsWithKeywordInName(string keyword)        {            throw new NotImplementedException();        }        public List<Album> GetAll()        {            throw new NotImplementedException();        }        public void Insert(Album entity)        {            throw new NotImplementedException();        }        public void Update(Album entity)        {            throw new NotImplementedException();        }        public void Delete(string id)        {            throw new NotImplementedException();        }    }
}

