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

namespace Desktop_Application.Controls
{
    public partial class SongControl : UserControl
    {
        private Song song;
        private IMusicUnitService musicUnitService;
        public SongControl(IMusicUnitService musicUnitService, Song song)
        {
            InitializeComponent();
            this.musicUnitService = musicUnitService;
            this.song = song;
            this.label1.Text = song.Name;
        }

        private void SongControl_Click(object sender, EventArgs e)
        {
            MusicAlbum parent = this.FindForm() as MusicAlbum;
            if (parent != null)
            {
                parent.OpenChildForm(new MusicSong(), sender);
            }
        }
    }
}
