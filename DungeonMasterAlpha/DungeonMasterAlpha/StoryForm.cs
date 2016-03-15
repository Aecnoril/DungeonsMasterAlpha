using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonMasterAlpha
{
    public partial class StoryForm : Form
    {
        public StoryForm()
        {
            InitializeComponent();
        }

        private void exitTabPage_Enter(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
