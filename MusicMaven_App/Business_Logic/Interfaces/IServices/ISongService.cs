﻿using System;
using Business_Logic.Models.MusicUnits;
{
	public interface ISongService
	{
        List<Song> GetHighestRatedSongsForArtist(Artist artist, int songCount);
}
