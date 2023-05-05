using Business_Logic.Enums;
using Business_Logic.Factories;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;
using Desktop_Application.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application
{
    public partial class MusicArtist : Form
    {
        private Form? _activeForm;
        private IMusicUnitService musicUnitService;
        private Artist artist;
        public MusicArtist(IMusicUnitService musicUnitService, Artist artist)
        {
            InitializeComponent();
            this.musicUnitService = musicUnitService;
            this.artist = artist;
            lblName.Text = artist.Name;
            lblArtistType.Text = artist.ArtistType.ToString();
            lblImage.Text = artist.Image;
            lblRating.Text = artist.AvrgRating.ToString();
            fillUsers();
            textBox2.Hide();
            cmBoxArtistType.Hide();
            txtBoxImage.Hide();
            cmBoxArtistType.DataSource = Enum.GetValues(typeof(ARTIST_TYPE));
            cmbBoxCreateAlbumGenre.DataSource = Enum.GetValues(typeof(GENRE_TYPE));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {

            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.RightToLeft = RightToLeft.No;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void fillUsers()
        {
            List<Album> albums = musicUnitService.GetAlbumsForArtist(artist);
            flowLayoutPanel1.Controls.Clear();

            List<AlbumControl> components = new List<AlbumControl>();

            foreach (Album album in albums)
            {
                components.Add(new AlbumControl(musicUnitService, album));
            }

            foreach (AlbumControl auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Replace the label with a textbox containing the same text
            textBox2.Location = lblName.Location;
            textBox2.Text = lblName.Text;
            float fontSize = lblName.Font.Size;
            textBox2.Font = new Font(lblName.Font.FontFamily, fontSize, lblName.Font.Style);
            textBox2.Size = lblName.Size;
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Show();
            textBox2.BringToFront();

            txtBoxImage.Location = lblImage.Location;
            txtBoxImage.Text = lblImage.Text;
            txtBoxImage.Size = lblImage.Size * 2;
            txtBoxImage.RightToLeft = RightToLeft.No;
            txtBoxImage.Show();
            txtBoxImage.BringToFront();

            cmBoxArtistType.Location = lblArtistType.Location;
            cmBoxArtistType.Text = lblArtistType.Text;
            cmBoxArtistType.Size = lblArtistType.Size * 2;
            cmBoxArtistType.RightToLeft = RightToLeft.No;
            cmBoxArtistType.Show();
            cmBoxArtistType.BringToFront();

            lblName.Hide();
            lblImage.Hide();
            lblArtistType.Hide();
        }

        private void MusicArtist_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBoxImage.Visible)
                {
                    this.lblName.Text = textBox2.Text;
                    lblName.Size = textBox2.Size;
                    artist.Name = textBox2.Text;
                    textBox2.Hide();
                    lblName.Show();

                    lblImage.Text = txtBoxImage.Text;
                    lblImage.Size = txtBoxImage.Size;
                    artist.Image = txtBoxImage.Text;
                    txtBoxImage.Hide();
                    lblImage.Show();

                    lblArtistType.Text = cmBoxArtistType.Text;
                    lblArtistType.Size = cmBoxArtistType.Size;
                    artist.ArtistType = (ARTIST_TYPE)Enum.Parse(typeof(ARTIST_TYPE), cmBoxArtistType.Text);
                    cmBoxArtistType.Hide();
                    lblArtistType.Show();
                    musicUnitService.UpdateMusicUnit(artist);
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                MusicArtist_PreviewKeyDown(this, new PreviewKeyDownEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if (flowPanelAddArtists.Controls.Count < 3)
            {
                List<Artist> artists = musicUnitService.GetArtists();
                foreach (Artist a in artists)
                {
                    if (a.Id == artist.Id)
                    {
                        artists.Remove(a);
                        break;
                    }
                }
                flowPanelAddArtists.Controls.Add(new AddArtistAlbumCreationControl(artists));
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            musicUnitService.DeleteMusicUnit(artist);
            this.Close();
        }

        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            string? name = txtBoxCreateAlbumName.Text;
            string? image = txtBoxCreateAlbumImageURL.Text;
            GENRE_TYPE genre = (GENRE_TYPE)Enum.Parse(typeof(GENRE_TYPE), cmbBoxCreateAlbumGenre.Text);
            DateTime creationDate = dtPickerCreateAlbumReleaseDate.Value;

            List<Artist> artists = new List<Artist>();
            artists.Add(artist);

            foreach (AddArtistAlbumCreationControl control in flowPanelAddArtists.Controls)
            {
                artists.Add(control.GetSelectedArtist());
            }
            bool hasDuplicateId = false;
            for (int i = 0; i < artists.Count - 1; i++)
            {
                for (int j = i + 1; j < artists.Count; j++)
                {
                    if (artists[i].Id == artists[j].Id)
                    {
                        hasDuplicateId = true;
                        break;
                    }
                }

                if (hasDuplicateId)
                {
                    break;
                }
            }

            if (hasDuplicateId)
            {
                MessageBox.Show("You have duplicated artists in this album.");
                return;
            }

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(image) && genre != null && creationDate != null)
            {
                Album album = (Album)MusicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ALBUM, name, image, 0, albumGenre: genre, albumCreators: artists, albumReleaseDate: creationDate);
                musicUnitService.CreateMusicUnit(album);
            }

        }
    }
}
