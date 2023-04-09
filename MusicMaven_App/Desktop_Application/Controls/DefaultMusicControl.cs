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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusicForm parent = this.FindForm() as MusicForm;
            if (parent != null)
            {
                parent.OpenChildForm(new MusicArtistForm(), sender);
            }

            MusicForm grandParent = this.Parent as MusicForm;

            if (grandParent != null)
            {
                grandParent.OpenChildForm(new MusicArtistForm(), sender);
            }

        }
    }
}
