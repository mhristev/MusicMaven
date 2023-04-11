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
    }
}
