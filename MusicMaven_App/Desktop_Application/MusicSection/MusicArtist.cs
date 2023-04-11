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
        public MusicArtist()
        {
            InitializeComponent();
            fillUsers();
            textBox2.Hide();
            cmBoxArtistType.Hide();
            txtBoxImage.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void Test2_Load(object sender, EventArgs e)
        {

        }
        public void fillUsers()
        {
            flowLayoutPanel1.Controls.Clear();

            List<AlbumControl> components = new List<AlbumControl>();
            components.Add(new AlbumControl());
            components.Add(new AlbumControl());
            components.Add(new AlbumControl());

            foreach (AlbumControl auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

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
                    textBox2.Hide();
                    lblName.Show();

                    lblImage.Text = txtBoxImage.Text;
                    lblImage.Size = txtBoxImage.Size;
                    txtBoxImage.Hide();
                    lblImage.Show();

                    lblArtistType.Text = cmBoxArtistType.Text;
                    lblArtistType.Size = cmBoxArtistType.Size;
                    cmBoxArtistType.Hide();
                    lblArtistType.Show();
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
    }
}
