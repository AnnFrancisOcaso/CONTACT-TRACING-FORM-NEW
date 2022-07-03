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

        String date, name, surname, temp;
        //
        String[] pd = new String [4];
        List<string> personDet = new List<string>();
        int x = 0;

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

        private void loginInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginInfo f3 = new LoginInfo();
            f3.Show();
        }

        private void qrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QR_code f5 = new QR_code();
            f5.Show();
        }

        private void detailsbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginInfo f3 = new LoginInfo();
            f3.receiveData(personDet);
            f3.Show();
        }

        private void savebttn_Click(object sender, EventArgs e)
        {
            //Making input equal variables
            date = datebx.Text;
            name = namebx.Text;
            surname = surnamebx.Text;
            temp = temperaturebx.Text;

            //saving variables in an array then saving array into a list
            pd[x] = date;
            pd[x + 1] = name;
            pd[x + 2] = surname;
            pd[x + 3] = temp;
            personDet.AddRange(pd);

            MessageBox.Show("Data saved!");
            x++;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This collect information for health purposes. This helps to monitor people who had closed contact with Covid-19 patients.", "About");
        }

        //private void insertbttn_Click(object sender, EventArgs e)
        //{
        //    StreamWriter file = new StreamWriter(@"C:\Users\Phenyang\source\repos\Contact_Tracing\Login Information.txt");
        //    file.WriteLine("Date: " + datebx.Text);
        //    file.WriteLine("First Name: " + namebx.Text);
        //    file.WriteLine("Surname: " + surnamebx.Text);
        //    file.WriteLine("Temperature: " + temperaturebx.Text);

        //    file.Close();
        //}
    }
}
