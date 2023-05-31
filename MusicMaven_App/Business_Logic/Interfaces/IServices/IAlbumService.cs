﻿using System;
using Business_Logic.Models.MusicUnits;
{
	public interface IAlbumService
	{
        List<Album> GetNewReleasedAlbums(int albumCount);

        List<Album> GetAllAlbums();
        void CreateAlbum(Album album);
}
