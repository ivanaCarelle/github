using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace github
{
    public partial class HelloGitHubForm : Form
    {
        public HelloGitHubForm()
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello GitHub.");
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
