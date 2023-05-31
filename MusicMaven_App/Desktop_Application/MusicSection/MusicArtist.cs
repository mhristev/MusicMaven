using Business_Logic.Enums;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;
using Desktop_Application.Controls;

namespace Desktop_Application
{
    public partial class MusicArtist : Form, IMusicForm
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
            fillAlbums();
            textBox2.Hide();
            cmBoxArtistType.Hide();
            txtBoxImage.Hide();
            cmBoxArtistType.DataSource = Enum.GetValues(typeof(ARTIST_TYPE));
            cmbBoxCreateAlbumGenre.DataSource = Enum.GetValues(typeof(GENRE_TYPE));
            lblCreateAlbumArtist.Text = "Artist: " + artist.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RefreshParentMusicForm();
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

        public void fillAlbums()
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
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtBoxImage.Visible)
                    {
                        this.lblName.Text = textBox2.Text;
                        lblName.Size = textBox2.Size;
                        artist.Name = textBox2.Text;


                        lblImage.Text = txtBoxImage.Text;
                        lblImage.Size = txtBoxImage.Size;
                        artist.Image = txtBoxImage.Text;


                        lblArtistType.Text = cmBoxArtistType.Text;
                        lblArtistType.Size = cmBoxArtistType.Size;
                        artist.ArtistType = (ARTIST_TYPE)Enum.Parse(typeof(ARTIST_TYPE), cmBoxArtistType.Text);

                        musicUnitService.UpdateMusicUnit(artist);

                        textBox2.Hide();
                        lblName.Show();

                        txtBoxImage.Hide();
                        lblImage.Show();

                        cmBoxArtistType.Hide();
                        lblArtistType.Show();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
            DialogResult result =
                MessageBox.Show("Are you sure you want to delete this artist (this action will delete all solo albums and songs of this artist)?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                musicUnitService.DeleteMusicUnit(artist);
                this.RefreshParentMusicForm();
                this.Close();
            }

        }

        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            try
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

                Album album = new Album(Guid.NewGuid().ToString(), name, image, MUSIC_UNIT_TYPE.ALBUM, genre, artists, 0, creationDate);
                musicUnitService.CreateMusicUnit(album);
                flowLayoutPanel1.Controls.Add(new AlbumControl(musicUnitService, album));
                txtBoxCreateAlbumName.Text = String.Empty;
                txtBoxCreateAlbumImageURL.Text = String.Empty;
                cmbBoxCreateAlbumGenre.SelectedItem = 0;
                dtPickerCreateAlbumReleaseDate.Value = DateTime.Today;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void RefreshMusicForm()
        {
            this.fillAlbums();
        }

        public void RefreshParentMusicForm()
        {
            if (this.ParentForm is IMusicForm)
            {
                IMusicForm underneathForm = (IMusicForm)this.ParentForm;
                // Do something with the underneathForm
                underneathForm.RefreshMusicForm();
            }

        }
    }
}
