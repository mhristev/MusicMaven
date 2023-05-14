using Business_Logic.Enums;
using Business_Logic.Factories;
using Business_Logic.Interfaces;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models.MusicUnits;
using Business_Logic.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class MusicForm : Form, IMusicForm
    {
        private Form? _activeForm;
        private IMusicUnitService musicUnitService;

        public MusicForm(IMusicUnitService musicUnitService)
        {
            InitializeComponent();
            this.musicUnitService = musicUnitService;
            fillMusicUnits();
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
        public void RefreshContents()
        {
            fillMusicUnits();
        }

        public void fillMusicUnits()
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
            try
            {
                string name = txtBoxArtistName.Text;
                string imageURL = txtBoxArtistImageURL.Text;
                string artistTypeSelectedText = cmbBoxArtistType.Text;


                ARTIST_TYPE artistType = (ARTIST_TYPE)Enum.Parse(typeof(ARTIST_TYPE), artistTypeSelectedText);

                MusicUnit unit = MusicUnitFactory.CreateMusicUnit(MUSIC_UNIT_TYPE.ARTIST, name, imageURL, artistType: artistType);
                musicUnitService.CreateMusicUnit(unit);
                flowPanelMusicUnits.Controls.Add(new DefaultMusicControl(musicUnitService, unit));

                txtBoxArtistName.Text = string.Empty;
                txtBoxArtistImageURL.Text = string.Empty;
                cmbBoxArtistType.Text = string.Empty;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void RefreshMusicForm()
        {
            this.fillMusicUnits();
        }

        public void RefreshParentMusicForm()
        {
            throw new NotImplementedException();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MusicUnit> units = musicUnitService.FindMusicUnitsByKeywordOrderedByHighestRated(txtboxSearch.Text.Trim().ToLower());
            flowPanelMusicUnits.Controls.Clear();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtboxSearch.Text = string.Empty;
            this.fillMusicUnits();
        }
    }
}
