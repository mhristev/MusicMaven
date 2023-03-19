using Business_Logic.Enums;
using Business_Logic.Factories;
using Business_Logic.Models.MusicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Services
{
    public class MusicUnitService
    {
        private static MusicUnitService instance;
        private MusicUnitFactory musicUnitFactory;
        private List<MusicUnit> musicUnits;

        private MusicUnitService() 
        { 
            musicUnitFactory = new MusicUnitFactory();
            
            var unit1 = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, "Tyler, The Creator", "images/artist.png", 7, artistType: ARTIST_TYPE.SOLO);
            var unit2 = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, "Kendrick Lamar", "images/artist.png", 8, artistType: ARTIST_TYPE.SOLO);
            var unit3 = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, "Joeyy Bada$$", "images/artist.png", 8, artistType: ARTIST_TYPE.SOLO);
            var unit4 = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, "Joeyy Bada$$", "images/artist.png", 8, artistType: ARTIST_TYPE.SOLO);

            #region IgorAlbum
            var album1 = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ALBUM, "IGOR", "images/album.png", 8, albumGenre: GENRE_TYPE.UNKNOWN, albumCreators: new List<Artist>() { (Artist)unit1 });

            var igorsTheme = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "IGOR'S THEME", "images/song.png", 8, durationInSeconds: 120, songAlbum: (Album)album1);

            var earfquake = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "EARFQUAKE", "images/song.png", 9, durationInSeconds: 218, songAlbum: (Album)album1);

            var iThink = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "I THINK", "images/song.png", 10, durationInSeconds: 213, songAlbum: (Album)album1);

            var exactlyWhatYouRunFrom = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "EXACTLY WHAT YOU RUN FROM", "images/song.png", 8, durationInSeconds: 150, songAlbum: (Album)album1);

            var runningOutOfTime = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "RUNNING OUT OF TIME", "images/song.png", 6, durationInSeconds: 158, songAlbum: (Album)album1);

            var newMagicWand = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "NEW MAGIC WAND", "images/song.png", 9, durationInSeconds: 193, songAlbum: (Album)album1);

            var aBoyIsAGun = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "A BOY IS A GUN", "images/song.png", 9, durationInSeconds: 207, songAlbum: (Album)album1);

            var puppet = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "PUPPET", "images/song.png", 9, durationInSeconds: 210, songAlbum: (Album)album1);

            var whatSGood = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "WHAT'S GOOD", "images/song.png", 9, durationInSeconds: 155, songAlbum: (Album)album1);

            var goneGoneThankYou = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "GONE, GONE / THANK YOU", "images/song.png", 17, durationInSeconds: 344, songAlbum: (Album)album1);

            #endregion

            #region FlowerBoyAlbum
            var album2 = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ALBUM, "Flower boy", "images/album.png", 8, albumGenre: GENRE_TYPE.UNKNOWN, albumCreators: new List<Artist>() { (Artist)unit1 });
            var foreword = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Foreword", "images/song.png", 1, durationInSeconds: 180, songAlbum: (Album)album2);

            var whereThisFlowerBlooms = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Where This Flower Blooms", "images/song.png", 2, durationInSeconds: 213, songAlbum: (Album)album2);

            var sometimes = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Sometimes...", "images/song.png", 3, durationInSeconds: 188, songAlbum: (Album)album2);

            var seeYouAgain = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "See You Again", "images/song.png", 4, durationInSeconds: 219, songAlbum: (Album)album2);

            var whoDatBoy = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Who Dat Boy", "images/song.png", 5, durationInSeconds: 156, songAlbum: (Album)album2);

            var pocket = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Pothole", "images/song.png", 6, durationInSeconds: 208, songAlbum: (Album)album2);

            var gardenShed = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Garden Shed", "images/song.png", 7, durationInSeconds: 239, songAlbum: (Album)album2);

            var boredom = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Boredom", "images/song.png", 8, durationInSeconds: 234, songAlbum: (Album)album2);

            var iAintGotTime = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "I Ain't Got Time!", "images/song.png", 9, durationInSeconds: 153, songAlbum: (Album)album2);

            var s911MrLonely = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "911 / Mr. Lonely", "images/song.png", 10, durationInSeconds: 228, songAlbum: (Album)album2);

            var droppinSeeds = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Droppin' Seeds", "images/song.png", 11, durationInSeconds: 74, songAlbum: (Album)album2);

            var november = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "November", "images/song.png", 12, durationInSeconds: 203, songAlbum: (Album)album2);

            var glitter = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Glitter", "images/song.png", 13, durationInSeconds: 243, songAlbum: (Album)album2);
            #endregion

            #region GKMC
            var album3 = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ALBUM, "IGOR", "images/album.png", 8, albumGenre: GENRE_TYPE.UNKNOWN, albumCreators: new List<Artist>() { (Artist)unit1 });
            var sherane = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Sherane a.k.a Master Splinter's Daughter", "images/song.png", 1, durationInSeconds: 294, songAlbum: (Album)album3);

            var bIgPoWeR = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Bitch, Don't Kill My Vibe", "images/song.png", 2, durationInSeconds: 336, songAlbum: (Album)album3);

            var bAcKsEaTfReEsTyLe = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Backseat Freestyle", "images/song.png", 3, durationInSeconds: 212, songAlbum: (Album)album3);

            var tHeArT = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "The Art of Peer Pressure", "images/song.png", 4, durationInSeconds: 386, songAlbum: (Album)album3);

            var mOnEyTrEe = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Money Trees", "images/song.png", 5, durationInSeconds: 391, songAlbum: (Album)album3);

            var pOiSiOnTrEeS = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Poetic Justice", "images/song.png", 6, durationInSeconds: 342, songAlbum: (Album)album3);

            var gOoDkId = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "good kid", "images/song.png", 7, durationInSeconds: 233, songAlbum: (Album)album3);

            var maadCiTy = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "m.A.A.d city", "images/song.png", 8, durationInSeconds: 345, songAlbum: (Album)album3);

            var sWiMmInGpOoLs = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Swimming Pools (Drank)", "images/song.png", 9, durationInSeconds: 334, songAlbum: (Album)album3);

            var sInSiDeOuT = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Sing About Me, I'm Dying of Thirst", "images/song.png", 10, durationInSeconds: 780, songAlbum: (Album)album3);

            var rEaLiTy = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Real", "images/song.png", 11, durationInSeconds: 312, songAlbum: (Album)album3);

            var cOmPtOn = musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.SONG, "Compton", "images/song.png", 12, durationInSeconds: 290, songAlbum: (Album)album3);

            #endregion

            musicUnits = new List<MusicUnit>()
            {
                unit1, unit2, unit3, unit4, album1, album2, album3,
                igorsTheme, earfquake, iThink, exactlyWhatYouRunFrom, runningOutOfTime, newMagicWand, aBoyIsAGun, puppet, whatSGood, goneGoneThankYou,
                foreword, whereThisFlowerBlooms, sometimes, seeYouAgain, whoDatBoy, pocket, gardenShed, boredom, iAintGotTime, s911MrLonely, droppinSeeds, november, glitter,
                sherane, bIgPoWeR, bAcKsEaTfReEsTyLe, tHeArT, mOnEyTrEe, pOiSiOnTrEeS, gOoDkId, maadCiTy, sWiMmInGpOoLs, sInSiDeOuT, rEaLiTy, cOmPtOn

            };

        }

        public static MusicUnitService Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (typeof(MusicUnitService))
                    {
                        if (instance == null)
                        {
                            instance = new MusicUnitService();
                        }
                    }
                }
                return instance;
            }
        }

        public List<MusicUnit> GetAllMusicUnits()
        {
            return musicUnits;
        }

        public MusicUnit GetMusicUnitWithId(string id)
        {
            MusicUnit musicUnit = musicUnits.FirstOrDefault(u => u.Id == id);

            if (musicUnit == null)
            {
                throw new ArgumentException("Music unit not found", nameof(id));
            }

            return musicUnit;
        }

        public List<Album> GetAlbumsForArtistId(string id)
        {
            return musicUnits
                    .Where(u => u.Type == MUSIC_UNIT_TYPE.ALBUM)
                    .Cast<Album>()
                    .Where(a => a.Artists.Any(artist => artist.Id == id))
                    .ToList();

        }

        public List<Song> GetSongsInAlbumId(string id)
        {
            return musicUnits
                    .Where(u => u.Type == MUSIC_UNIT_TYPE.SONG)
                    .Cast<Song>()
                    .Where(s => s.Album.Id == id)
                    .ToList();
        }

        public List<Artist> GetArtists()
        {
            return musicUnits.Where(u => u.Type == MUSIC_UNIT_TYPE.ARTIST).Cast<Artist>().ToList();
        }

    }
}
