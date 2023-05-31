﻿using System;
using Business_Logic.Models;
{
	public interface IMusicUnitService
	{
        List<Album> GetAlbumsForArtist(Artist artist);
        List<Song> GetSongsInAlbum(Album album);
}
