﻿using System;
using Business_Logic.Models.MusicUnits;
{
	public interface ISongRepository
	{
		List<Song> GetSongsInAlbumId(string id);
}
