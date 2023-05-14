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
            if (e.KeyCode == Keys.Enter)
            {
                if (msktxtBoxDuration.Visible)
                {
                    lblSongDuration.Text = msktxtBoxDuration.Text;
                    lblSongDuration.Size = msktxtBoxDuration.Size;
                    msktxtBoxDuration.Hide();
                    lblSongDuration.Show();

                    cmbBoxSongAlbum.Enabled = false;

                    lblSongName.Text = txtBoxSongName.Text;
                    lblSongName.Size = txtBoxSongName.Size;
                    txtBoxSongName.Hide();
                    lblSongName.Show();

                    song.Name = txtBoxSongName.Text;
                    song.DurationInMinutesAndSeconds = msktxtBoxDuration.Text;
                    song.Album = (Album)cmbBoxSongAlbum.SelectedItem;

                    musicUnitService.UpdateMusicUnit(song);
                }
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
                // Do something with the underneathForm
                underneathForm.RefreshMusicForm();
            }

        }

        public void RefreshMusicForm()
        {
            throw new NotImplementedException();
        }
    }
}
