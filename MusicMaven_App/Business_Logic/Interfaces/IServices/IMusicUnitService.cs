using System;
using Business_Logic.Models;using Business_Logic.Models.MusicUnits;namespace Business_Logic.Interfaces.IServices
{
	public interface IMusicUnitService
	{        MusicUnit? GetMusicUnitWithId(string id);
        List<Album> GetAlbumsForArtist(Artist artist);
        List<Song> GetSongsInAlbum(Album album);        List<Artist> GetArtists();        List<Album> GetAlbums();        List<Song> GetHighestRatedSongsForArtist(Artist artist, int songCount);        List<Album> GetNewReleasedAlbums(int albumCount);        List<MusicUnit> GetLastReviewedMusicUnits(List<Review> reviews, int unitCount);        List<MusicUnit> GetHighestRatedMusicUnits(int unitCount);        List<MusicUnit> FindMusicUnitsByKeywordOrderedByHighestRated(string keyword);        List<MusicUnit> GetAllMusicUnits();        void CreateMusicUnit(MusicUnit unit);        void UpdateMusicUnit(MusicUnit unit);        void DeleteMusicUnit(MusicUnit unit);    }
}

