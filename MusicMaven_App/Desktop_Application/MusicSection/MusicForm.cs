﻿using System;
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
        public MusicForm()
        {
            InitializeComponent();
            // flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MusicArtist(), sender);
        }
        public void fillUsers()
        {
            flowLayoutPanel1.Controls.Clear();

            List<DefaultMusicControl> components = new List<DefaultMusicControl>();
            components.Add(new DefaultMusicControl(new Business_Logic.Models.MusicUnits.MusicUnit("", "", "", 1, Business_Logic.Enums.MUSIC_UNIT_TYPE.ARTIST)));
            components.Add(new DefaultMusicControl(new Business_Logic.Models.MusicUnits.MusicUnit("", "", "", 1, Business_Logic.Enums.MUSIC_UNIT_TYPE.ALBUM)));
            components.Add(new DefaultMusicControl(new Business_Logic.Models.MusicUnits.MusicUnit("", "", "", 1, Business_Logic.Enums.MUSIC_UNIT_TYPE.SONG)));

            foreach (DefaultMusicControl auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
        }
    }
}
