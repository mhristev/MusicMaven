﻿using System;
using System.Data;
using Business_Logic.Models.MusicUnits;
namespace Data_Access_Layer.Repositories
{
	public class MusicUnitRepository : BaseRepository, IMusicUnitRepository
	{
                          a.genre, 
                          a.releaseDate,
                          s.durationInSeconds,
                          s.albumId,
                          ar.artistType
                   FROM MusicUnit m
                   LEFT JOIN Album a ON m.id = a.id
                   LEFT JOIN Artist ar ON m.id= ar.id
                   LEFT JOIN Song s ON m.id = s.id";
                          a.genre, 
                          a.releaseDate,
                          s.durationInSeconds,
                          s.albumId,
                          ar.artistType
                   FROM MusicUnit m 
                   LEFT JOIN Album a ON m.id = a.id
                   LEFT JOIN Artist ar ON m.id= ar.id
                   LEFT JOIN Song s ON m.id = s.id
                    SELECT mu.id, mu.name, mu.image, mu.avgRating, mu.type
                    FROM MusicUnit mu
                    LEFT JOIN Review r ON mu.id = r.musicUnitId AND r.creatorId = @userId
                    WHERE r.id IS NULL";
                VALUES (@Id, @Name, @Image, @AvgRating, @Type)";
            {
                Id = reader.GetString(reader.GetOrdinal("id")),
                Name = reader.GetString(reader.GetOrdinal("name")),
                Image = reader.GetString(reader.GetOrdinal("image")),
}
