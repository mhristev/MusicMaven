using Business_Logic.Interfaces.IServices;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;
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
    }
}
