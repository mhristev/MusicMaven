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

namespace Desktop_Application.MusicSection
{
    public partial class MusicAlbum : Form
    {
        private Form? _activeForm;
        public MusicAlbum()
        {
            InitializeComponent();
            fillUsers();
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
            flowLayoutPanel1.Controls.Clear();

            List<SongControl> components = new List<SongControl>();
            components.Add(new SongControl());
            components.Add(new SongControl());
            components.Add(new SongControl());

            foreach (SongControl auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
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


            string[] substrings = lblArtists.Text.Split('|');
            flowPanelArtists.Controls.Clear();
            foreach (string substring in substrings)
            {
                if (substring.Trim().Length > 0)
                {
                    flowPanelArtists.Controls.Add(new AddArtistAlbumCreationControl(substring.Trim()));
                }
            }
            btnAddArtist.Show();

            cmBoxGenre.Location = lblGenre.Location;
            cmBoxGenre.Text = lblGenre.Text;
            cmBoxGenre.Size = lblGenre.Size * 2;
            cmBoxGenre.RightToLeft = RightToLeft.No;
            cmBoxGenre.Show();
            cmBoxGenre.BringToFront();

            dtpReleaseDate.Location = lblReleaseDate.Location;
            dtpReleaseDate.Value = DateTime.Parse(lblReleaseDate.Text);
            dtpReleaseDate.Size = lblReleaseDate.Size * 2;
            dtpReleaseDate.RightToLeft = RightToLeft.No;
            dtpReleaseDate.Show();
            dtpReleaseDate.BringToFront();

            lblArtists.Hide();
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

                    lblReleaseDate.Text = dtpReleaseDate.Text;
                    lblReleaseDate.Size = dtpReleaseDate.Size;
                    dtpReleaseDate.Hide();
                    lblReleaseDate.Show();

                    lblArtists.Text = "";
                    foreach (AddArtistAlbumCreationControl c in flowPanelArtists.Controls)
                    {
                        lblArtists.Text += c.GetSelectedArtistName() + " | ";
                    }
                    flowPanelArtists.Controls.Clear();

                    lblArtists.Show();
                    btnAddArtist.Hide();

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
            if (flowPanelArtists.Controls.Count < 3)
            {
                flowPanelArtists.Controls.Add(new AddArtistAlbumCreationControl());
            }
        }
    }
}
