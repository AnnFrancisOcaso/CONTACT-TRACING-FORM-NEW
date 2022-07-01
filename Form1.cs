using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void insertbttn_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Phenyang\source\repos\Contact_Tracing\Login Information.txt");
            file.WriteLine("Date: " + datebx.Text);
            file.WriteLine("First Name: " + namebx.Text);
            file.WriteLine("Surname: " + surnamebx.Text);
            file.WriteLine("Temperature: " + temperaturebx.Text);

            file.Close();
        }
    }
}
