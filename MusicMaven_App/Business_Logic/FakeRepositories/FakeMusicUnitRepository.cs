﻿using System;
using Business_Logic.Interfaces;
{
	public class FakeMusicUnitRepository : IMusicUnitRepository
	{
		private IRepository<Album> _albumRepository;
		private IRepository<Artist> _artistRepository;
		private IRepository<Song> _songRepository;

		public FakeMusicUnitRepository(IRepository<Album> albumRepo, IRepository<Artist> artistRepo, IRepository<Song> songRepo)
		{
			_albumRepository = albumRepo;
			_artistRepository = artistRepo;
			_songRepository = songRepo;
		}
}
