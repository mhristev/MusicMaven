using Business_Logic.Enums;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models;
using Business_Logic.Models.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application.UsersSection
{
    public partial class UsersSingleForm : Form
    {
        private User user;
        private IUserService userService;
        public UsersSingleForm(User user, IUserService userService)
        {
            InitializeComponent();
            this.user = user;
            this.userService = userService;
            cmBoxUserType.DataSource = Enum.GetValues(typeof(USER_TYPE));
            lblUsername.Text = user.Username;
            lblEmail.Text = user.Email;
            lblImage.Text = user.Image;
            lblUserType.Text = user.Type.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Replace the label with a textbox containing the same text
            txtBoxUsername.Location = lblUsername.Location;
            txtBoxUsername.Text = lblUsername.Text;
            float fontSize = lblUsername.Font.Size;
            txtBoxUsername.Font = new Font(lblUsername.Font.FontFamily, fontSize, lblUsername.Font.Style);
            txtBoxUsername.Size = lblUsername.Size;
            txtBoxUsername.RightToLeft = RightToLeft.No;
            txtBoxUsername.TextAlign = HorizontalAlignment.Center;
            txtBoxUsername.Show();
            txtBoxUsername.BringToFront();

            txtBoxImage.Location = lblImage.Location;
            txtBoxImage.Text = lblImage.Text;
            txtBoxImage.Size = lblImage.Size * 2;
            txtBoxImage.RightToLeft = RightToLeft.No;
            txtBoxImage.Show();
            txtBoxImage.BringToFront();

            cmBoxUserType.Location = lblUserType.Location;
            cmBoxUserType.Text = lblUserType.Text;
            cmBoxUserType.Size = lblUserType.Size * 2;
            cmBoxUserType.RightToLeft = RightToLeft.No;
            cmBoxUserType.Show();
            cmBoxUserType.BringToFront();

            txtBoxEmail.Location = lblEmail.Location;
            txtBoxEmail.Text = lblEmail.Text;
            txtBoxEmail.Size = lblEmail.Size * 2;
            txtBoxEmail.RightToLeft = RightToLeft.No;
            txtBoxEmail.Show();
            txtBoxEmail.BringToFront();

            lblUsername.Hide();
            lblImage.Hide();
            lblUserType.Hide();
            lblEmail.Hide();
        }

        private void UsersSingleForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtBoxImage.Visible)
                    {
                        this.lblUsername.Text = txtBoxUsername.Text;
                        lblUsername.Size = txtBoxUsername.Size;
                        user.Username = txtBoxUsername.Text;


                        lblImage.Text = txtBoxImage.Text;
                        lblImage.Size = txtBoxImage.Size;
                        user.Image = txtBoxImage.Text;


                        lblUserType.Text = cmBoxUserType.Text;
                        lblUserType.Size = cmBoxUserType.Size;
                        user.Type = (USER_TYPE)Enum.Parse(typeof(USER_TYPE), cmBoxUserType.Text);

                        lblEmail.Text = txtBoxEmail.Text;
                        lblEmail.Size = txtBoxEmail.Size;
                        user.Email = txtBoxEmail.Text;

                        userService.UpdateUser(user);

                        txtBoxUsername.Hide();
                        lblUsername.Show();

                        txtBoxImage.Hide();
                        lblImage.Show();

                        cmBoxUserType.Hide();
                        lblUserType.Show();

                        txtBoxEmail.Hide();
                        lblEmail.Show();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                UsersSingleForm_PreviewKeyDown(this, new PreviewKeyDownEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void RefreshParentUserForm()
        {
            if (this.ParentForm is UsersForm)
            {
                UsersForm underneathForm = (UsersForm)this.ParentForm;
                // Do something with the underneathForm
                underneathForm.RefreshUsers();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Are you sure you want to delete this user (this action will delete all solo albums and songs of this artist)?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                userService.DeleteUser(user);
                this.RefreshParentUserForm();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.RefreshParentUserForm();
            this.Close();
        }
    }
}
