﻿using System;
using Business_Logic.Models.MusicUnits;
{
	public interface IMusicUnitRepository
	{
		MusicUnit? GetById(string id);

	}
}
