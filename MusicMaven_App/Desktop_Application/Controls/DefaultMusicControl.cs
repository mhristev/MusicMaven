using Business_Logic.Enums;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;
using Desktop_Application.MusicSection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class DefaultMusicControl : UserControl
    {
        private MusicUnit _musicUnit;
        private IMusicUnitService musicUnitService;
        public DefaultMusicControl(IMusicUnitService musicUnitService, MusicUnit musicUnit)
        {
            InitializeComponent();
            _musicUnit = musicUnit;
            this.musicUnitService = musicUnitService;
            lblName.Text = _musicUnit.Name;
            lblType.Text = _musicUnit.Type.ToString();
            lblRating.Text = _musicUnit.AvrgRating.ToString();
        }

        private void DefaultMusicControl_Click(object sender, EventArgs e)
        {
            MusicForm? parent = this.FindForm() as MusicForm;
            if (parent != null)
            {
                switch (_musicUnit.Type)
                {
                    case MUSIC_UNIT_TYPE.ARTIST:
                        parent.OpenChildForm(new MusicArtist(musicUnitService, (Artist)_musicUnit), sender);
                        break;
                    case MUSIC_UNIT_TYPE.ALBUM:
                        parent.OpenChildForm(new MusicAlbum(musicUnitService, (Album)_musicUnit), sender);
                        break;
                    case MUSIC_UNIT_TYPE.SONG:
                        parent.OpenChildForm(new MusicSong(musicUnitService, (Song)_musicUnit), sender);
                        break;
                    default:
                        MessageBox.Show("Error while loading object.");
                        break;
                }
            }
        }
    }
}
