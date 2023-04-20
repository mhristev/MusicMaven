using System;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.Interfaces
{
	public interface IMusicUnitRepository
	{
		MusicUnit? GetMusicUnitByid(string id);
		List<MusicUnit> GetHighestRatedUnits(int unitCount);
    }
}

