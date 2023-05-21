using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using Business_Logic.Services;
using Data_Access_Layer.Repositories;

namespace Desktop_Application
{
    public partial class LoginForm : Form
    {

        IUserAuthenticationService userAuthenticationService;
        public LoginForm(IUserAuthenticationService userAuthenticationService)
        {
            InitializeComponent();
            this.ActiveControl = null;
            this.userAuthenticationService = userAuthenticationService;
        }

        public void ClearTextBoxes()
        {
            this.txtBoxEmail.Text = string.Empty;
            this.txtBoxPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtBoxEmail.Text;
                string password = txtBoxPassword.Text;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    throw new ArgumentException(ExceptionMessages.EmptyRequiredFields);
                }

                User? user = userAuthenticationService.AuthenticateUser(email, password);

                if (user == null || user.Type == USER_TYPE.NORMAL)
                {
                    throw new ArgumentException(ExceptionMessages.AuthenticationFailed);
                }

                ArtistRepository artistRepository = new ArtistRepository();
                ArtistService artistService = new ArtistService(artistRepository);

                AlbumRepository albumRepository = new AlbumRepository(artistRepository);
                AlbumService albumService = new AlbumService(albumRepository);

                SongRepository songRepository = new SongRepository(albumRepository);
                SongService songService = new SongService(songRepository);

                MusicUnitRepository musicUnitRepository = new MusicUnitRepository(albumRepository, artistRepository);
                MusicUnitService musicUnitService = new MusicUnitService(albumService, songService, artistService, musicUnitRepository);

                UserRepository userRepository = new UserRepository();
                UserService userService = new UserService(userRepository);


                MainForm mainForm = new MainForm(musicUnitService, userService, this);
                this.Hide();
                mainForm.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "Password")
            {
                txtBoxPassword.Text = string.Empty;
                txtBoxPassword.PasswordChar = '*';
            }
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text.Length == 0)
            {
                txtBoxPassword.Text = "Password";
                txtBoxPassword.PasswordChar = '\0';
            }
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "Email")
            {
                txtBoxEmail.Text = "";
            }
        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text.Length == 0)
            {
                txtBoxEmail.Text = "Email";
            }
        }
    }
}
