using Business_Logic.Enums;
using Business_Logic.Interfaces.IServices;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;
using Business_Logic.Services;
using Desktop_Application.MusicSection;
using Desktop_Application.UsersSection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application.Controls
{
    public partial class DefaultUserControl : UserControl
    {
        private IUserService userService;
        private User user;
        public DefaultUserControl(IUserService userService, User user)
        {
            InitializeComponent();
            this.userService = userService;
            this.user = user;
            this.lblEmail.Text = user.Email;
            this.lblUsername.Text = user.Username;
            this.lblType.Text = user.Type.ToString();
        }

        private void DefaultUserControl_Click(object sender, EventArgs e)
        {
            UsersForm? parent = this.FindForm() as UsersForm;
            if (parent != null)
            {
                parent.OpenChildForm(new UsersSingleForm(user, userService), sender);   
            }
            else
            {
                MessageBox.Show("Error while loading object.");
            }
        }
    }
}
