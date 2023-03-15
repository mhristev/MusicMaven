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
            musicUnits = new List<MusicUnit>() 
            { 
                musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, "Tyler, The Creator", "images/tyler.jpeg", 7, artistType: ARTIST_TYPE.SOLO),
                musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, "Kendrick Lamar", "images/tyler.jpeg", 8, artistType: ARTIST_TYPE.SOLO),
                musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, "Joeyy Bada$$", "images/tyler.jpeg", 8, artistType: ARTIST_TYPE.SOLO),
                musicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, "Jay-Z", "images/tyler.jpeg", 9.1, artistType: ARTIST_TYPE.SOLO),
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


    }
}
