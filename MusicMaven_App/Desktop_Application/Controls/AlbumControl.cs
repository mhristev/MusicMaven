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
        public AlbumControl()
        {
            InitializeComponent();
        }

        private void AlbumControl_Click(object sender, EventArgs e)
        {
            MusicArtist parent = this.FindForm() as MusicArtist;
            if (parent != null)
            {
                parent.OpenChildForm(new MusicAlbum(), sender);
            }

            MusicArtist grandParent = this.Parent as MusicArtist;

            if (grandParent != null)
            {
                grandParent.OpenChildForm(new MusicAlbum(), sender);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
