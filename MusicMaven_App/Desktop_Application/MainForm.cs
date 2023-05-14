using Business_Logic.Interfaces.IServices;
using Desktop_Application.MusicSection;
using Desktop_Application.UsersSection;

namespace Desktop_Application
{
    public partial class MainForm : Form
    {
        private Form? _activeForm;
        private IMusicUnitService musicUnitService;
        private IUserService userService;
        public MainForm(IMusicUnitService musicUnitService, IUserService userService)
        {
            InitializeComponent();
            this.musicUnitService = musicUnitService;
            this.userService = userService;
            OpenChildForm(new MusicForm(this.musicUnitService), this);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            OpenChildForm(new MusicForm(this.musicUnitService), sender);
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new UsersForm(userService), sender);
        }
    }
}