using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact_Tracing_Form f2 = new Contact_Tracing_Form();
            this.Hide();
            f2.Show();        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This collect information for health purposes. This helps to monitor people who had closed contact with Covid-19 patients.", "About");
        }
    }
}
