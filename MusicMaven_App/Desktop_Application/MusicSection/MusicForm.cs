using Business_Logic.Enums;
using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;
using Business_Logic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class MusicForm : Form
    {
        private Form? _activeForm;
        private IMusicUnitService musicUnitService;

        public MusicForm(IMusicUnitService musicUnitService)
        {
            InitializeComponent();
            // flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            this.musicUnitService = musicUnitService;
            fillUsers();
            cmbBoxArtistType.DataSource = Enum.GetValues(typeof(ARTIST_TYPE));
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {

            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.RightToLeft = RightToLeft.No;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fillUsers()
        {
            flowPanelMusicUnits.Controls.Clear();
            List<MusicUnit> units = musicUnitService.GetAllMusicUnits();
            List<DefaultMusicControl> components = new List<DefaultMusicControl>();
            foreach (MusicUnit unit in units)
            {
                components.Add(new DefaultMusicControl(musicUnitService, unit));

            }

            foreach (DefaultMusicControl auc in components)
            {
                flowPanelMusicUnits.Controls.Add(auc);
            }
        }

        private void btnCreateArtist_Click(object sender, EventArgs e)
        {
            string name = txtBoxArtistName.Text;
            string imageURL = txtBoxArtistImageURL.Text;
            string artistTypeSelectedText = cmbBoxArtistType.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (!Enum.TryParse(artistTypeSelectedText, out ARTIST_TYPE artistType))
            {
                MessageBox.Show("Please select a valid artist type.");
                return;
            }
            if (!Uri.IsWellFormedUriString(imageURL, UriKind.RelativeOrAbsolute))
            {
                MessageBox.Show("Please enter a valid image URL.");
                return;
            }

            MusicUnit unit = MusicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, name, imageURL, 0, artistType: artistType);
            musicUnitService.CreateMusicUnit(unit);
            flowPanelMusicUnits.Controls.Add(new DefaultMusicControl(musicUnitService, unit));

            txtBoxArtistName.Text = string.Empty;
            txtBoxArtistImageURL.Text = string.Empty;
            cmbBoxArtistType.Text = string.Empty;

        }
    }
}
