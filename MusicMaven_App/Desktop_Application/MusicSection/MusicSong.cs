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
    public partial class MusicSong : Form
    {
        public MusicSong()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nmrDuration_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            msktxtBoxDuration.Location = lblDuration.Location;
            msktxtBoxDuration.Text = lblDuration.Text;
            msktxtBoxDuration.Size = lblDuration.Size * 2;
            msktxtBoxDuration.RightToLeft = RightToLeft.No;
            msktxtBoxDuration.Show();
            msktxtBoxDuration.BringToFront();

            cmbBoxAlbum.Location = lblAlbum.Location;
            cmbBoxAlbum.Text = lblAlbum.Text;
            cmbBoxAlbum.Size = lblAlbum.Size * 2;
            cmbBoxAlbum.RightToLeft = RightToLeft.No;
            cmbBoxAlbum.Show();
            cmbBoxAlbum.BringToFront();

            lblDuration.Hide();
            lblAlbum.Hide();
        }
        private void MusicSong_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (msktxtBoxDuration.Visible)
                {
                    lblDuration.Text = msktxtBoxDuration.Text;
                    lblDuration.Size = msktxtBoxDuration.Size;
                    msktxtBoxDuration.Hide();
                    lblDuration.Show();

                    lblAlbum.Text = cmbBoxAlbum.Text;
                    lblAlbum.Size = cmbBoxAlbum.Size;
                    cmbBoxAlbum.Hide();
                    lblAlbum.Show();

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
    }
}
