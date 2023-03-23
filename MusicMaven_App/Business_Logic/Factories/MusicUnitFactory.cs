using Business_Logic.Enums;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Factories
{
    public class MusicUnitFactory
    {
        private ArtistFactory artistFactory;
        private AlbumFactory albumFactory;
        private SongFactory songFactory;

        public MusicUnitFactory()
        {
            this.artistFactory = new ArtistFactory();
            this.albumFactory = new AlbumFactory();
            this.songFactory = new SongFactory();
        }

        public MusicUnit CreateMusicUnit(MUSIC_UNIT_TYPE type, string name, string img, double avgRating, GENRE_TYPE albumGenre = GENRE_TYPE.UNKNOWN, List<Artist> albumCreators = null, ARTIST_TYPE artistType = ARTIST_TYPE.UNKNOWN, int durationInSeconds = 0, Album songAlbum = null, DateTime albumReleaseDate = new DateTime())
        {
            switch (type)
            {
                case MUSIC_UNIT_TYPE.ALBUM: 
                    return albumFactory.CreateAlbum(name, img, avgRating, type, albumGenre, albumCreators, albumReleaseDate);
                case MUSIC_UNIT_TYPE.ARTIST: 
                    return artistFactory.CreateArtist(name, img, avgRating, type, artistType);
                case MUSIC_UNIT_TYPE.SONG:
                    return songFactory.CreateSong(name, img, avgRating, type, durationInSeconds, songAlbum);
                default:
                    throw new ArgumentException("Invalid type specified.");
            }
        }
    }
}
