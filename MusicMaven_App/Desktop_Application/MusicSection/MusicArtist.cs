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
    public partial class MusicArtistForm : Form
    {
        public MusicArtistForm()
        {
            InitializeComponent();
            fillUsers();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Test2_Load(object sender, EventArgs e)
        {

        }
        public void fillUsers()
        {
            flowLayoutPanel1.Controls.Clear();

            List<UserControl2> components = new List<UserControl2>();
            components.Add(new UserControl2());
            components.Add(new UserControl2());
            components.Add(new UserControl2());

            foreach (UserControl2 auc in components)
            {
                flowLayoutPanel1.Controls.Add(auc);
            }
        }
    }
}
