using System;
using Business_Logic.Models.MusicUnits;
using Business_Logic.Interfaces;using Business_Logic.Enums;using System.Data;using Microsoft.Data.SqlClient;namespace Data_Access_Layer.Repositories
{    public class SongRepository : BaseRepository, ISongRepository    {
        IAlbumRepository albumRepository;        public SongRepository(IAlbumRepository albumRepository)        {
            this.albumRepository = albumRepository;        }

        private Song MapSong(IDataReader reader)        {            var song = new Song();            song.Id = reader.GetString(reader.GetOrdinal("id"));            song.Name = reader.GetString(reader.GetOrdinal("name"));            song.Image = reader.GetString(reader.GetOrdinal("image"));            song.Type = (MUSIC_UNIT_TYPE)Enum.Parse(typeof(MUSIC_UNIT_TYPE), reader.GetString(reader.GetOrdinal("type")));            song.AvrgRating = reader.GetDouble(reader.GetOrdinal("avgRating"));            song.DurationInSeconds = reader.GetInt32(reader.GetOrdinal("durationInSeconds"));            song.Album = new Album { Id = reader.GetString(reader.GetOrdinal("albumId")) };            return song;        }

        public void Delete(string id)
        {
            string sql = "DELETE FROM Song WHERE id = @Id;";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = id }); ;            });
        }

        public List<Song> GetAll()
        {
            string sql = "SELECT mu.id, mu.name, mu.image, mu.type, mu.avgRating, s.durationInSeconds, s.albumId " +
                 "FROM MusicUnit mu " +
                 "JOIN Song s ON mu.id = s.id;";            var songs = ExecuteQuery(sql, MapSong, null);

            foreach (Song song in songs)            {                Album? album = albumRepository.GetById(song.Album.Id);                if (album != null)                {                    song.Album = album;                }            }            return songs;        }

        public Song? GetById(string id)
        {
            string sql = "SELECT mu.id, mu.name, mu.image, mu.type, mu.avgRating, s.durationInSeconds, s.albumId " +
                 "FROM MusicUnit mu " +
                 "JOIN Song s ON mu.id = s.id " +
                 "WHERE mu.id = @id";            var parameters = new { id };            var songs = ExecuteQuery(sql, MapSong, command =>            {                var parameter = command.CreateParameter();                parameter.ParameterName = "@id";                parameter.Value = id;                command.Parameters.Add(parameter);            });            if (songs.Count > 0)            {                var song = songs[0];                Album? album = albumRepository.GetById(song.Album.Id);                if (album != null)                {                    song.Album = album;                }                return song;            }            return null;
        }

        public void Insert(Song entity)
        {
            string sql = "INSERT INTO MusicUnit (id, name, image, type, avgRating) " +
                 "VALUES (@id, @name, @image, @type, @avgRating);" +
                 "INSERT INTO Song (id, durationInSeconds, albumId) " +
                 "VALUES (@id, @durationInSeconds, @albumId);";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = entity.Id });                command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar) { Value = entity.Name });                command.Parameters.Add(new SqlParameter("@image", SqlDbType.NVarChar) { Value = entity.Image });                command.Parameters.Add(new SqlParameter("@type", SqlDbType.NVarChar) { Value = entity.Type.ToString() });                command.Parameters.Add(new SqlParameter("@avgRating", SqlDbType.Float) { Value = entity.AvrgRating });                command.Parameters.Add(new SqlParameter("@durationInSeconds", SqlDbType.Int) { Value = entity.DurationInSeconds });                command.Parameters.Add(new SqlParameter("@albumId", SqlDbType.NVarChar) { Value = entity.Album.Id });            });
        }

        public void Update(Song entity)
        {
            string sql = "UPDATE MusicUnit SET name=@name, image=@image, type=@type, avgRating=@avgRating WHERE id=@id;" +
                 "UPDATE Song SET durationInSeconds=@durationInSeconds, albumId=@albumId WHERE id=@id;";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = entity.Id });                command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar) { Value = entity.Name });                command.Parameters.Add(new SqlParameter("@image", SqlDbType.NVarChar) { Value = entity.Image });                command.Parameters.Add(new SqlParameter("@type", SqlDbType.NVarChar) { Value = entity.Type.ToString() });                command.Parameters.Add(new SqlParameter("@avgRating", SqlDbType.Float) { Value = entity.AvrgRating });                command.Parameters.Add(new SqlParameter("@durationInSeconds", SqlDbType.Int) { Value = entity.DurationInSeconds });                command.Parameters.Add(new SqlParameter("@albumId", SqlDbType.NVarChar) { Value = entity.Album.Id });            });

        }        public List<Song> GetSongsInAlbumId(string id)        {            string sql = "SELECT mu.id, mu.name, mu.image, mu.type, mu.avgRating, s.durationInSeconds, s.albumId " +
                 "FROM MusicUnit mu " +
                 "JOIN Song s ON mu.id = s.id " +
                 "WHERE s.albumId = @albumId";            List<Song> songs = ExecuteQuery(sql, MapSong, command => {                command.Parameters.Add(new SqlParameter("@albumId", SqlDbType.NVarChar) { Value = id });            });            if (songs.Count > 0)            {                Album? album = albumRepository.GetById(songs.First().Album.Id);                if (album != null)                {                    foreach (Song song in songs)                    {                        song.Album = album;                    }                }            }            return songs;        }        public List<Song> GetHighestRatedSongsForArtistId(string id, int songCount)        {            string sql = string.Empty;            List<Song> songs = new List<Song>();            if (songCount < 0)            {                sql = @"SELECT s.id, s.durationInSeconds, s.albumId, m.name, m.image, m.avgRating, m.type
                            FROM Song s
                            JOIN MusicUnit m ON s.id = m.id
                            JOIN AlbumArtists aa ON s.albumId = aa.albumId
                            JOIN Artist a ON aa.artistId = a.id AND a.id = @id
                            ORDER BY m.avgRating DESC";                songs = ExecuteQuery(sql, MapSong, command => {                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = id });                });            }            else            {                 sql = @"SELECT TOP(@songCount) s.id, s.durationInSeconds, s.albumId, m.name, m.image, m.avgRating, m.type
                            FROM Song s
                            JOIN MusicUnit m ON s.id = m.id
                            JOIN AlbumArtists aa ON s.albumId = aa.albumId
                            JOIN Artist a ON aa.artistId = a.id AND a.id = @id
                            ORDER BY m.avgRating DESC";                songs = ExecuteQuery(sql, MapSong, command => {                    command.Parameters.Add(new SqlParameter("@songCount", SqlDbType.Int) { Value = songCount });                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar) { Value = id });                });            }            foreach (Song song in songs)            {                Album? album = albumRepository.GetById(song.Album.Id);                if (album != null)                {                    song.Album = album;                }            }            return songs;        }            public List<Song> GetSongsWithKeywordInName(string keyword)        {            string sql = "SELECT mu.id, mu.name, mu.image, mu.type, mu.avgRating, s.durationInSeconds, s.albumId " +
                 "FROM MusicUnit mu " +
                 "JOIN Song s ON mu.id = s.id " +
                 "WHERE mu.name LIKE '%' + @keyword + '%';";            var songs = ExecuteQuery(sql, MapSong, command => {                command.Parameters.Add(new SqlParameter("@keyword", SqlDbType.NVarChar) { Value = keyword });            });            foreach (Song song in songs)            {                Album? album = albumRepository.GetById(song.Album.Id);                if (album != null)                {                    song.Album = album;                }            }            return songs;        }    }
}

