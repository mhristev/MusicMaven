using Business_Logic.Enums;
using Business_Logic.Factories;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
using Business_Logic.Models.MusicUnits;
using Business_Logic.Services;
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

namespace Desktop_Application.UsersSection
{
    public partial class UsersForm : Form
    {
        private Form _activeForm;
        private IUserService userService;
        public UsersForm(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
            cmbBoxUserType.DataSource = Enum.GetValues(typeof(USER_TYPE));
            this.FillUsers();
        }

        private void FillUsers()
        {
            flowLayoutPanelUsers.Controls.Clear();
            List<User> users = userService.GetAllUsers();
            List<DefaultUserControl> components = new List<DefaultUserControl>();
            foreach (User user in users)
            {
                components.Add(new DefaultUserControl(userService, user));

            }

            foreach (DefaultUserControl auc in components)
            {
                flowLayoutPanelUsers.Controls.Add(auc);
            }
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
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void RefreshUsers()
        {
            FillUsers();
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtBoxUsername.Text;
                string imageURL = txtBoxImageURL.Text;
                string email = txtBoxEmail.Text;
                string password = txtBoxPassword.Text;
                string repeatPassword = txtBoxRepeatPassword.Text;

                if (password != repeatPassword)
                {
                    MessageBox.Show("Passwords don't match!");
                    return;
                }

                string userTypeSelectedText = cmbBoxUserType.Text;

                USER_TYPE userType = (USER_TYPE)Enum.Parse(typeof(USER_TYPE), userTypeSelectedText);

                User user = UserFactory.CreateUser(username, email, password, imageURL, userType);
                userService.CreateUser(user);
                flowLayoutPanelUsers.Controls.Add(new DefaultUserControl(userService, user));

                txtBoxUsername.Text = string.Empty;
                txtBoxImageURL.Text = string.Empty;
                txtBoxEmail.Text = string.Empty;
                txtBoxPassword.Text = string.Empty;
                txtBoxRepeatPassword.Text = string.Empty;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
