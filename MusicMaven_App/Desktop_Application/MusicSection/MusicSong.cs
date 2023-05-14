using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;

namespace Desktop_Application.MusicSection
{
    public partial class MusicSong : Form, IMusicForm
    {
        private IMusicUnitService musicUnitService;
        private Song song;
        public MusicSong(IMusicUnitService musicUnitService, Song song)
        {
            InitializeComponent();
            this.song = song;
            this.musicUnitService = musicUnitService;
            lblSongName.Text = song.Name;
            lblSongDuration.Text = song.DurationInMinutesAndSeconds;
            lblSongRating.Text = song.AvrgRating.ToString();
            List<Album> albums = musicUnitService.GetAlbums();
            int index = albums.FindIndex(album => album.Id == song.Album.Id);
            cmbBoxSongAlbum.Show();
            cmbBoxSongAlbum.DataSource = albums;
            cmbBoxSongAlbum.SelectedIndex = index;
            cmbBoxSongAlbum.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.RefreshParentMusicForm();
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            msktxtBoxDuration.Location = lblSongDuration.Location;
            msktxtBoxDuration.Text = lblSongDuration.Text;
            msktxtBoxDuration.Size = lblSongDuration.Size * 2;
            msktxtBoxDuration.RightToLeft = RightToLeft.No;
            msktxtBoxDuration.Show();
            msktxtBoxDuration.BringToFront();

            cmbBoxSongAlbum.Enabled = true;
            txtBoxSongName.Location = lblSongName.Location;
            txtBoxSongName.Text = lblSongName.Text;
            float fontSize = lblSongName.Font.Size;
            txtBoxSongName.Font = new Font(lblSongName.Font.FontFamily, fontSize, lblSongName.Font.Style);
            txtBoxSongName.Size = lblSongName.Size;
            txtBoxSongName.RightToLeft = RightToLeft.No;
            txtBoxSongName.TextAlign = HorizontalAlignment.Center;
            txtBoxSongName.Show();
            txtBoxSongName.BringToFront();

            lblSongDuration.Hide();
            lblSongName.Hide();
        }
        private void MusicSong_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (msktxtBoxDuration.Visible)
                    {
                        lblSongDuration.Text = msktxtBoxDuration.Text;
                        lblSongDuration.Size = msktxtBoxDuration.Size;

                        lblSongName.Text = txtBoxSongName.Text;
                        lblSongName.Size = txtBoxSongName.Size;


                        song.Name = txtBoxSongName.Text;
                        song.DurationInMinutesAndSeconds = msktxtBoxDuration.Text;
                        song.Album = (Album)cmbBoxSongAlbum.SelectedItem;

                        musicUnitService.UpdateMusicUnit(song);

                        msktxtBoxDuration.Hide();
                        lblSongDuration.Show();

                        txtBoxSongName.Hide();
                        lblSongName.Show();

                        cmbBoxSongAlbum.Enabled = false;
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
                MusicSong_PreviewKeyDown(this, new PreviewKeyDownEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Are you sure you want to delete this song?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                musicUnitService.DeleteMusicUnit(song);
                this.RefreshParentMusicForm();
                this.Dispose();
            }
        }

        public void RefreshParentMusicForm()
        {
            if (this.ParentForm is IMusicForm)
            {
                IMusicForm underneathForm = (IMusicForm)this.ParentForm;
                underneathForm.RefreshMusicForm();
            }

        }

        public void RefreshMusicForm()
        {
            throw new NotImplementedException();
        }
    }
}
