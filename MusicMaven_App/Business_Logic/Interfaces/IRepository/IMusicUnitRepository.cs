using System;
using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces.IRepository
{
	public interface IMusicUnitRepository
	{
		MusicUnit? GetById(string id);

	}
}

