using System;
using Business_Logic.Models.MusicUnits;
using Business_Logic.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;using Business_Logic.Enums;namespace Data_Access_Layer.Repositories
{
	public class ArtistRepository: BaseRepository, IArtistRepository
	{
        private Artist MapArtist(IDataReader reader)        {            return new Artist()
            {
                Id = reader.GetString(reader.GetOrdinal("id")),
                Name = reader.GetString(reader.GetOrdinal("name")),
                Image = reader.GetString(reader.GetOrdinal("image")),                AvrgRating = reader.GetDouble(reader.GetOrdinal("avgRating")),                Type = (MUSIC_UNIT_TYPE)Enum.Parse(typeof(MUSIC_UNIT_TYPE), reader.GetString(reader.GetOrdinal("type"))),                ArtistType = (ARTIST_TYPE)Enum.Parse(typeof(ARTIST_TYPE), reader.GetString(reader.GetOrdinal("artistType")))            };        }

        public void Delete(string id)
        {
            string sql = "DELETE FROM Artist WHERE id = @Id; ";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar) { Value = id });            });
        }

        

        public List<Artist> GetAll()
        {
            string sql = @"
            SELECT a.id, m.name, m.image, m.type, a.artistType, m.avgRating
            FROM Artist a
            JOIN MusicUnit m ON a.id = m.id";            return ExecuteQuery(sql, MapArtist);
        }        public List<Artist> GetArtistsWithKeywordInName(string keyword)        {            string sql = "SELECT * FROM MusicUnit INNER JOIN Artist ON MusicUnit.Id = Artist.Id WHERE MusicUnit.Name LIKE '%' + @Keyword + '%';";            List<Artist> result = ExecuteQuery(sql, MapArtist, command =>            {                command.Parameters.Add(new SqlParameter("@Keyword", SqlDbType.NVarChar) { Value = keyword });            });            return result;        }        public Artist? GetById(string id)
        {
            string sql = "SELECT * FROM MusicUnit INNER JOIN Artist ON MusicUnit.Id = Artist.Id WHERE MusicUnit.Id = @Id";            List<Artist> result = ExecuteQuery(sql, MapArtist, command =>            {                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar) { Value = id });            });            return result.FirstOrDefault();
        }

        public void Insert(Artist entity)
        {
            string sql = "INSERT INTO MusicUnit (id, name, image, avgRating, type) VALUES (@Id, @Name, @Image, @AvgRating, @Type); " +
                     "INSERT INTO Artist (Id, ArtistType) VALUES (@Id, @ArtistType);";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar) { Value = entity.Id });                command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = entity.Name });                command.Parameters.Add(new SqlParameter("@Image", SqlDbType.NVarChar) { Value = entity.Image });                command.Parameters.Add(new SqlParameter("@AvgRating", SqlDbType.Float) { Value = entity.AvrgRating });                command.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar) { Value = entity.Type.ToString() });                command.Parameters.Add(new SqlParameter("@ArtistType", SqlDbType.NVarChar) { Value = entity.ArtistType });            });
        }

        public void Update(Artist entity)
        {
            string sql = @"
            UPDATE MusicUnit
            SET name = @Name, image = @Image, type = @Type, avgRating = @AvgRating
            WHERE id = @Id;

            UPDATE Artist
            SET artistType = @ArtistType
            WHERE id = @Id;";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar) { Value = entity.Id });                command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = entity.Name });                command.Parameters.Add(new SqlParameter("@Image", SqlDbType.NVarChar) { Value = entity.Image });                command.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar) { Value = entity.Type.ToString() });                command.Parameters.Add(new SqlParameter("@AvgRating", SqlDbType.Float) { Value = entity.AvrgRating });                command.Parameters.Add(new SqlParameter("@ArtistType", SqlDbType.NVarChar) { Value = entity.ArtistType.ToString() });            });
        }        public List<Artist> GetArtistsForAlbumId(string id)        {            string sqlArtists = "SELECT mu.id, mu.name, mu.image, mu.type, mu.avgRating, ar.artistType " +                                    "FROM MusicUnit mu " +                                    "JOIN AlbumArtists aa ON mu.id = aa.artistId " +                                    "JOIN Artist ar ON mu.id = ar.id " +                                    "WHERE aa.albumId = @id";            List<Artist> artists = ExecuteQuery(sqlArtists, MapArtist, command =>            {                var parameter = command.CreateParameter();                parameter.ParameterName = "@id";                parameter.Value = id;                command.Parameters.Add(parameter);            }).ToList();            return artists;        }    }
}

