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
    public partial class AlbumControl : UserControl
    {
        private Album album;
        private IMusicUnitService musicUnitService;
        public AlbumControl(IMusicUnitService musicUnitService, Album album)
        {
            InitializeComponent();
            this.album = album;
            this.musicUnitService = musicUnitService;
            lblAlbumName.Text = album.Name;
        }

        private void AlbumControl_Click(object sender, EventArgs e)
        {
            MusicArtist parent = this.FindForm() as MusicArtist;
            if (parent != null)
            {
                parent.OpenChildForm(new MusicAlbum(musicUnitService, album), sender);
            }

            MusicArtist grandParent = this.Parent as MusicArtist;

            if (grandParent != null)
            {
                grandParent.OpenChildForm(new MusicAlbum(musicUnitService, album), sender);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            musicUnitService.DeleteMusicUnit(this.album);
            this.Dispose();
        }
    }
}
