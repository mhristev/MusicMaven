﻿using System;
using System.Data;using Business_Logic.Enums;using Business_Logic.Interfaces;
using Business_Logic.Models.MusicUnits;using Microsoft.Data.SqlClient;
namespace Data_Access_Layer.Repositories
{
	public class MusicUnitRepository : BaseRepository, IMusicUnitRepository
	{        IAlbumRepository albumRepository;        IArtistRepository artistRepository;        public MusicUnitRepository(IAlbumRepository albumRepository, IArtistRepository artistRepository)        {            this.albumRepository = albumRepository;            this.artistRepository = artistRepository;        }        public void Delete(string id)        {            var sql = "DELETE FROM MusicUnit WHERE id = @Id";            ExecuteNonQuery(sql, command => {                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar) { Value = id });            });        }        public List<MusicUnit> GetAll()        {            string sql = @"SELECT m.*, 
                          a.genre, 
                          a.releaseDate,
                          s.durationInSeconds,
                          s.albumId,
                          ar.artistType
                   FROM MusicUnit m
                   LEFT JOIN Album a ON m.id = a.id
                   LEFT JOIN Artist ar ON m.id= ar.id
                   LEFT JOIN Song s ON m.id = s.id";            return ExecuteQuery(sql, MapMusicUnit2);        }        public MusicUnit? GetById(string id)        {            string sql = @"SELECT m.*, 
                          a.genre, 
                          a.releaseDate,
                          s.durationInSeconds,
                          s.albumId,
                          ar.artistType
                   FROM MusicUnit m 
                   LEFT JOIN Album a ON m.id = a.id
                   LEFT JOIN Artist ar ON m.id= ar.id
                   LEFT JOIN Song s ON m.id = s.id                   WHERE m.id = @Id";            List<MusicUnit> result = ExecuteQuery(sql, MapMusicUnit2, command => {                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar) { Value = id });            });            return result.FirstOrDefault();        }        public List<MusicUnit> GetHighestRatedUnits(int unitCount)        {            List<MusicUnit> result = new List<MusicUnit>();            string sql = string.Empty;            if (unitCount < 0)            {                sql = "SELECT * FROM MusicUnit ORDER BY avgRating DESC";                result = ExecuteQuery(sql, MapMusicUnit);            }            else            {                sql = "SELECT TOP(@unitCount) * FROM MusicUnit ORDER BY avgRating DESC";                result = ExecuteQuery(sql, MapMusicUnit, command =>                {                    command.Parameters.Add(new SqlParameter("@unitCount", SqlDbType.Int) { Value = unitCount });                });            }            return result;        }        public List<MusicUnit> GetMusicUnitsByKeywordInNameOrderedByHighestRated(string keyword)        {            string sql = @"SELECT m.*, 
                          a.genre, 
                          a.releaseDate,
                          s.durationInSeconds,
                          s.albumId,
                          ar.artistType
                   FROM MusicUnit m
                   LEFT JOIN Album a ON m.id = a.id
                   LEFT JOIN Artist ar ON m.id= ar.id
                   LEFT JOIN Song s ON m.id = s.id                    WHERE LOWER(m.name) LIKE '%' + LOWER(@Keyword) + '%' ORDER BY avgRating DESC";            List<MusicUnit> result = ExecuteQuery(sql, MapMusicUnit2, command => {                command.Parameters.Add(new SqlParameter("@Keyword", SqlDbType.NVarChar) { Value = "%" + keyword + "%" });            });            return result;        }        public List<MusicUnit> GetUnratedUnits(string userId)        {            string sql = @"
                    SELECT mu.id, mu.name, mu.image, mu.avgRating, mu.type
                    FROM MusicUnit mu
                    LEFT JOIN Review r ON mu.id = r.musicUnitId AND r.creatorId = @userId
                    WHERE r.id IS NULL";            return ExecuteQuery(sql, MapMusicUnit, command => {                command.Parameters.Add(new SqlParameter("@userId", SqlDbType.NVarChar) { Value = userId });            });        }        public void Insert(MusicUnit entity)        {            var sql = @"INSERT INTO MusicUnit (id, name, image, avgRating, type) 
                VALUES (@Id, @Name, @Image, @AvgRating, @Type)";            ExecuteNonQuery(sql, command =>            {                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar) { Value = entity.Id });                command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = entity.Name });                command.Parameters.Add(new SqlParameter("@Image", SqlDbType.NVarChar) { Value = entity.Image });                command.Parameters.Add(new SqlParameter("@AvgRating", SqlDbType.Float) { Value = entity.AvrgRating });                command.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar) { Value = entity.Type.ToString() });            });        }        public void Update(MusicUnit entity)        {            var sql = "UPDATE MusicUnit SET name = @Name, image = @Image, avgRating = @AvgRating, type = @Type WHERE id = @Id";            ExecuteNonQuery(sql, command => {                command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = entity.Name });                command.Parameters.Add(new SqlParameter("@Image", SqlDbType.NVarChar) { Value = entity.Image });                command.Parameters.Add(new SqlParameter("@AvgRating", SqlDbType.Float) { Value = entity.AvrgRating });                command.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar) { Value = entity.Type.ToString() });                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar) { Value = entity.Id });            });        }        private MusicUnit MapMusicUnit(IDataReader reader)        {            return new MusicUnit()
            {
                Id = reader.GetString(reader.GetOrdinal("id")),
                Name = reader.GetString(reader.GetOrdinal("name")),
                Image = reader.GetString(reader.GetOrdinal("image")),                AvrgRating = (double)reader.GetDouble(reader.GetOrdinal("avgRating")),                Type = (MUSIC_UNIT_TYPE)Enum.Parse(typeof(MUSIC_UNIT_TYPE), reader.GetString(reader.GetOrdinal("type")))            };        }        private MusicUnit MapMusicUnit2(IDataReader reader)        {            string id = reader.GetString(reader.GetOrdinal("id"));            string name = reader.GetString(reader.GetOrdinal("name"));            string image = reader.GetString(reader.GetOrdinal("image"));            double avgRating = (double)reader.GetDouble(reader.GetOrdinal("avgRating"));            MUSIC_UNIT_TYPE type = (MUSIC_UNIT_TYPE)Enum.Parse(typeof(MUSIC_UNIT_TYPE), reader.GetString(reader.GetOrdinal("type")));            MusicUnit musicUnit = new MusicUnit() { Id = id, Name = name, Image = image, AvrgRating = avgRating, Type = type};            switch (type)            {                case MUSIC_UNIT_TYPE.ALBUM:                    GENRE_TYPE genre = (GENRE_TYPE)Enum.Parse(typeof(GENRE_TYPE), reader.GetString(reader.GetOrdinal("genre")));                    DateTime releaseDate = reader.GetDateTime(reader.GetOrdinal("releaseDate"));                    List<Artist> artists = artistRepository.GetArtistsForAlbumId(id);                    musicUnit = new Album(id, name, image, type, genre, artists, avgRating, releaseDate);                    break;                case MUSIC_UNIT_TYPE.ARTIST:                    ARTIST_TYPE artistType = (ARTIST_TYPE)Enum.Parse(typeof(ARTIST_TYPE), reader.GetString(reader.GetOrdinal("artistType")));                    musicUnit = new Artist(id, name, image, type, artistType, avgRating);                    break;                case MUSIC_UNIT_TYPE.SONG:                    int durationInSeconds = reader.GetInt32(reader.GetOrdinal("durationInSeconds"));                    string albumId = reader.GetString(reader.GetOrdinal("albumId"));                    Album? album = albumRepository.GetById(albumId);                    if (albumId != null)                    {                        musicUnit = new Song(id, name, image, type, durationInSeconds, album, avgRating);                    }                    break;            }            return musicUnit;        }    }
}

