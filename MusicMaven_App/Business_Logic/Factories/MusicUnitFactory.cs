using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Factories
{
    public static class MusicUnitFactory
    {
        public static MusicUnit CreateMusicUnit(MUSIC_UNIT_TYPE type, string name, string img, double avgRating, GENRE_TYPE albumGenre = GENRE_TYPE.UNKNOWN, List<Artist> albumCreators = null, ARTIST_TYPE artistType = ARTIST_TYPE.UNKNOWN, int durationInSeconds = 0, Album songAlbum = null, DateTime albumReleaseDate = new DateTime())
        {
            switch (type)
            {
                case MUSIC_UNIT_TYPE.ALBUM: 
                    return AlbumFactory.CreateAlbum(name, img, avgRating, type, albumGenre, albumCreators, albumReleaseDate);
                case MUSIC_UNIT_TYPE.ARTIST: 
                    return ArtistFactory.CreateArtist(name, img, avgRating, type, artistType);
                case MUSIC_UNIT_TYPE.SONG:
                    return SongFactory.CreateSong(name, img, avgRating, type, durationInSeconds, songAlbum);
                default:
                    throw new ArgumentException("Invalid type specified.");
            }
        }
    }
}
