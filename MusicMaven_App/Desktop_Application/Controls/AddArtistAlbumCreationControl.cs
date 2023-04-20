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
    public partial class AddArtistAlbumCreationControl : UserControl
    {
        public AddArtistAlbumCreationControl()
        {
            InitializeComponent();
        }
        public AddArtistAlbumCreationControl(string name)
        {
            InitializeComponent();
            this.cmBoxArtist.Text = name;
        }
        public string GetSelectedArtistName()
        {
            return this.cmBoxArtist.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
