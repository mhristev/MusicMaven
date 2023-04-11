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
        public SongControl()
        {
            InitializeComponent();
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
