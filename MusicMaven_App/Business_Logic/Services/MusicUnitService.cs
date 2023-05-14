using Business_Logic.Enums;
using Business_Logic.Factories;
using Business_Logic.Interfaces;using Business_Logic.Models;using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic.Interfaces.IServices;

namespace Business_Logic.Services
{
    public class MusicUnitService : IMusicUnitService
    {

        private IArtistService artistService;
        private ISongService songService;
        private IAlbumService albumService;
        private IMusicUnitRepository musicUnitRepository;

        public MusicUnitService(IAlbumService albumService, ISongService songService, IArtistService artistService, IMusicUnitRepository unitRepository)        {
            this.albumService = albumService;
            this.artistService = artistService;
            this.songService = songService;
            this.musicUnitRepository = unitRepository;
        }


        public MusicUnit? GetMusicUnitWithId(string id)
        {
            return musicUnitRepository.GetById(id);
        }

        public List<Album> GetAlbumsForArtist(Artist artist)
        {
            return albumService.GetAlbumsForArtist(artist);
        }

        public List<Song> GetSongsInAlbum(Album album)
        {
            return songService.GetSongsInAlbum(album);
        }

        public List<Artist> GetArtists() // add artist count
        {
            return artistService.GetArtists();
        }

        public List<Song> GetHighestRatedSongsForArtist(Artist artist, int songCount)
        {
            return songService.GetHighestRatedSongsForArtist(artist, songCount);
        }

        public List<Album> GetNewReleasedAlbums(int albumCount)
        {
            return albumService.GetNewReleasedAlbums(albumCount);
        }

        public List<MusicUnit> GetLastReviewedMusicUnits(List<Review> reviews, int unitCount)        {
            List<MusicUnit> units = new List<MusicUnit>();

            List<Review> lastNReviews = reviews.OrderByDescending(r => r.CreationDate).Take(unitCount).ToList();            // Get the unique music units from the reviews            List<MusicUnit> uniqueMusicUnits = lastNReviews.Select(r => r.MusicUnit).Distinct().ToList();
            foreach (MusicUnit musicUnit in uniqueMusicUnits)            {                units.Add(musicUnit);            }

            return units;
        }

        public List<MusicUnit> GetHighestRatedMusicUnits(int unitCount)        {
            return musicUnitRepository.GetHighestRatedUnits(unitCount);
        }        public List<MusicUnit> FindMusicUnitsByKeywordOrderedByHighestRated(string keyword)        {            return musicUnitRepository.GetMusicUnitsByKeywordInNameOrderedByHighestRated(keyword);        }

        public List<MusicUnit> GetAllMusicUnits()
        {
            return musicUnitRepository.GetAll();
        }        public void CreateMusicUnit(MusicUnit unit)        {            switch (unit.Type)            {                case MUSIC_UNIT_TYPE.ARTIST:                    artistService.CreateArtist((Artist)unit);                    break;                case MUSIC_UNIT_TYPE.ALBUM:                    albumService.CreateAlbum((Album)unit);                    break;                case MUSIC_UNIT_TYPE.SONG:                    songService.CreateSong((Song)unit);                    break;            }        }

        public void UpdateMusicUnit(MusicUnit unit)
        {
            switch (unit.Type)
            {
                case MUSIC_UNIT_TYPE.ARTIST:
                    artistService.UpdateArtist((Artist)unit);
                    break;
                case MUSIC_UNIT_TYPE.ALBUM:
                    albumService.UpdateAlbum((Album)unit);
                    break;
                case MUSIC_UNIT_TYPE.SONG:
                    songService.UpdateSong((Song)unit);
                    break;
            }
        }

        public void DeleteMusicUnit(MusicUnit unit)
        {
            switch (unit.Type)
            {
                case MUSIC_UNIT_TYPE.ARTIST:
                    artistService.DeleteArtist((Artist)unit);
                    break;
                case MUSIC_UNIT_TYPE.ALBUM:
                    albumService.DeleteAlbum((Album)unit);
                    break;
                case MUSIC_UNIT_TYPE.SONG:
                    songService.DeleteSong((Song)unit);
                    break;
            };
        }

        public List<Album> GetAlbums()
        {
            return albumService.GetAllAlbums();
        }
    }
}
