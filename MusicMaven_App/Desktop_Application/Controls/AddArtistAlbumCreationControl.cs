using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;
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

        public AddArtistAlbumCreationControl(List<Artist> artists)
        {
            InitializeComponent();
            cmBoxArtist.DataSource = artists;
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

        public Artist GetSelectedArtist()
        {
            return (Artist)cmBoxArtist.SelectedItem;
        }
    }
}
