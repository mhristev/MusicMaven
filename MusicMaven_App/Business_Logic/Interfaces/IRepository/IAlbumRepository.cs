﻿using System;
using Business_Logic.Models.MusicUnits;
{
	public interface IAlbumRepository : IRepository<Album>
	{
        List<Album> GetNewReleasedAlbums(int albumCount);
}
