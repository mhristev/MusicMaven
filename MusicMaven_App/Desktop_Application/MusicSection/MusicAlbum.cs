using Business_Logic.Enums;
using Business_Logic.Factories;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;
using Desktop_Application.Controls;
using System.Globalization;

namespace Desktop_Application.MusicSection
{
    public partial class MusicAlbum : Form, IMusicForm
    {
        private Form? _activeForm;
        private Album album;
        private IMusicUnitService musicUnitService;
        public MusicAlbum(IMusicUnitService musicUnitService, Album album)
        {
            InitializeComponent();
            this.musicUnitService = musicUnitService;
            this.album = album;
            this.lblName.Text = album.Name;
            this.lblGenre.Text = album.Genre.ToString();
            this.lblRating.Text = album.AvrgRating.ToString();
            this.lblReleaseDate.Text = album.ReleaseDate.ToString("dd-MM-yyyy");
            List<Artist> artists = musicUnitService.GetArtists();
            foreach (Artist artist in album.Artists)
            {
                AddArtistAlbumCreationControl control = new AddArtistAlbumCreationControl(artists, artist);
                control.HideDeleteAndDisableComboBox();
                flowPanelArtists.Controls.Add(control);
            }
            cmBoxGenre.DataSource = Enum.GetValues(typeof(GENRE_TYPE));
            fillSongs();
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

        public void fillSongs()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Song> songList = musicUnitService.GetSongsInAlbum(album);
            List<SongControl> components = new List<SongControl>();
            foreach (Song song in songList)
            {
                components.Add(new SongControl(musicUnitService, song));
            }

            foreach (SongControl auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.RefreshParentMusicForm();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Replace the label with a textbox containing the same text
            txtBoxName.Location = lblName.Location;
            txtBoxName.Text = lblName.Text;
            float fontSize = lblName.Font.Size;
            txtBoxName.Font = new Font(lblName.Font.FontFamily, fontSize, lblName.Font.Style);
            txtBoxName.Size = lblName.Size;
            txtBoxName.RightToLeft = RightToLeft.No;
            txtBoxName.TextAlign = HorizontalAlignment.Center;
            txtBoxName.Show();
            txtBoxName.BringToFront();


            foreach (AddArtistAlbumCreationControl control in flowPanelArtists.Controls)
            {
                control.ShowDeleteAndEnableComboBox();
            }

            btnAddArtist.Show();

            cmBoxGenre.Location = lblGenre.Location;
            cmBoxGenre.Text = lblGenre.Text;
            cmBoxGenre.Size = lblGenre.Size * 2;
            cmBoxGenre.RightToLeft = RightToLeft.No;
            cmBoxGenre.Show();
            cmBoxGenre.BringToFront();

            dtpReleaseDate.Location = lblReleaseDate.Location;
            DateTime dateValue = DateTime.ParseExact(lblReleaseDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture); // Convert the date string to a DateTime value
            dtpReleaseDate.Value = dateValue;
            dtpReleaseDate.Size = lblReleaseDate.Size * 2;
            dtpReleaseDate.RightToLeft = RightToLeft.No;
            dtpReleaseDate.Show();
            dtpReleaseDate.BringToFront();

            lblName.Hide();
            lblGenre.Hide();
            lblReleaseDate.Hide();
        }


        private void MusicAlbum_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBoxName.Visible)
                {
                    lblName.Text = txtBoxName.Text;
                    lblName.Size = txtBoxName.Size;
                    txtBoxName.Hide();
                    lblName.Show();

                    lblGenre.Text = cmBoxGenre.Text;
                    lblGenre.Size = cmBoxGenre.Size;
                    cmBoxGenre.Hide();
                    lblGenre.Show();

                    lblReleaseDate.Text = dtpReleaseDate.Value.ToString("dd-MM-yyyy");
                    lblReleaseDate.Size = dtpReleaseDate.Size;
                    dtpReleaseDate.Hide();
                    lblReleaseDate.Show();

                    List<Artist> newArtists = new List<Artist>();
                    foreach (AddArtistAlbumCreationControl c in flowPanelArtists.Controls)
                    {
                        c.HideDeleteAndDisableComboBox();
                        newArtists.Add(c.GetSelectedArtist());
                    }
                    btnAddArtist.Hide();

                    album.Name = lblName.Text;
                    album.Genre = (GENRE_TYPE)Enum.Parse(typeof(GENRE_TYPE), lblGenre.Text);
                    album.ReleaseDate = DateTime.Parse(dtpReleaseDate.Text);
                    album.Artists = newArtists;
                    musicUnitService.UpdateMusicUnit(album);

                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                MusicAlbum_PreviewKeyDown(this, new PreviewKeyDownEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            List<Artist> artists = musicUnitService.GetArtists();

            if (flowPanelArtists.Controls.Count < 3)
            {
                flowPanelArtists.Controls.Add(new AddArtistAlbumCreationControl(artists));
            }
        }

        private void btnCreateSong_Click(object sender, EventArgs e)
        {
            string? name = txtBoxNameCreateSong.Text;
            string? img = txtBoxImgCreateSong.Text;
            int duration = (int)nmrDurationInSecondsCreateSong.Value;

            if (duration != 0 && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(img))
            {
                MusicUnit song = MusicUnitFactory.CreateMusicUnit(Business_Logic.Enums.MUSIC_UNIT_TYPE.SONG, name, img, 0, durationInSeconds: duration, songAlbum: album);
                musicUnitService.CreateMusicUnit(song);
                flowLayoutPanel1.Controls.Add(new SongControl(musicUnitService, (Song)song));
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                MessageBox.Show("Are you sure you want to delete this album (this will also delete all the songs related to this record)?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                musicUnitService.DeleteMusicUnit(album);
                this.RefreshParentMusicForm();
                this.Dispose();
            }            
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

        public void RefreshMusicForm()
        {
            this.fillSongs();
        }
    }
}
