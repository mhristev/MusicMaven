using System;
using Business_Logic.Models.MusicUnits;

namespace Business_Logic.Interfaces
{
	public interface IMusicUnitRepository : IRepository<MusicUnit>
	{
		List<MusicUnit> GetHighestRatedUnits(int unitCount);		List<MusicUnit> GetMusicUnitsByKeywordInNameOrderedByHighestRated(string keyword);    }
}

