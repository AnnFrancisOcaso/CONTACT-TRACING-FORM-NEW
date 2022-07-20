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
using ZXing;

namespace Contact_Tracing
{
    public partial class Contact_Tracing_Form : Form
    {
        public Contact_Tracing_Form()
        {
            InitializeComponent();
        }

        String dt, nm, add, cn, ea, dfever, ddryc, dheadache, dsoret, dfatigue, dshortb, dbodya, ddia, dsmell, dcity, dpatient, dexposure;

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader data = new StreamReader(@"C:\Users\Phenyang\source\repos\Contact_Tracing\Contact Tracing Form Information.txt");
            MessageBox.Show(data.ReadToEnd());
            data.Close();
        }

        private void generatebttn_Click(object sender, EventArgs e)
        {
            string qrData = form2datebx.Text + "," + namebx.Text + "," + numberbx.Text + "," + addbx.Text + "," + emailbx.Text + "," + feverbx.Text + "," + coughbx.Text + "," + headbx.Text + "," + sorebx.Text + "," + fatiguebx.Text + "," + breathbx.Text + "," + bodybx.Text + "," + diabx.Text + "," + smellbx.Text + "," + citybx.Text + "," + exposurebx.Text;
         
            string qrImageFileName = namebx.Text;

            if(string.IsNullOrEmpty(qrData) || string.IsNullOrEmpty(qrImageFileName))
            {
                MessageBox.Show("Textboxes are empty! Please input data.", "Error");
                return;
            }

            if (File.Exists(@"C:\Users\Phenyang\source\repos\Contact_Tracing\qr info\"+ qrImageFileName + ".png"))
            {
                MessageBox.Show("File already exists!Choose another name!", "Error");
                return;
            }

            BarcodeWriter barcode = new BarcodeWriter();
            barcode.Format = BarcodeFormat.QR_CODE;

            barcode.Write(qrData).Save(@"C:\Users\Phenyang\source\repos\Contact_Tracing\qr info\" + qrImageFileName + ".png");
            pictureboxqr.Image = Image.FromFile(@"C:\Users\Phenyang\source\repos\Contact_Tracing\qr info\" + qrImageFileName + ".png");
        }

        private void homebttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void checkbttn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_Tracing_Information f4 = new Contact_Tracing_Information();
            f4.receiveData(contactInformation);
            f4.Show();
        }

        String[] ct = new String[17];
        List<string> contactInformation = new List<string>();
        int f = 0;


        private void savebttn3_Click(object sender, EventArgs e)
        {
            //Making input equal variables
            dt = form2datebx.Text;
            nm = namebx.Text;
            cn = numberbx.Text;
            add = addbx.Text;
            ea = emailbx.Text;
            dfever = feverbx.Text;
            ddryc = coughbx.Text;
            dheadache = headbx.Text;
            dsoret = sorebx.Text;
            dfatigue = fatiguebx.Text;
            dshortb = breathbx.Text;
            dbodya = bodybx.Text;
            ddia = diabx.Text;
            dsmell = smellbx.Text;
            dcity = citybx.Text;
            dpatient = patientbx.Text;
            dexposure = exposurebx.Text;



            //saving variables in an array then saving array into a list
            ct[f] = dt;
            ct[f + 1] = nm;
            ct[f + 2] = add;
            ct[f + 3] = cn;
            ct[f + 4] = ea;
            ct[f + 5] = dfever;
            ct[f + 6] = ddryc;
            ct[f + 7] = dheadache;
            ct[f + 8] = dsoret;
            ct[f + 9] = dfatigue;
            ct[f + 10] = dshortb;
            ct[f + 11] = dbodya;
            ct[f + 12] = ddia;
            ct[f + 13] = dsmell;
            ct[f + 14] = dcity;
            ct[f + 15] = dpatient;
            ct[f + 16] = dexposure;
            contactInformation.AddRange(ct);

            MessageBox.Show("Data saved!");
            f++;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbttn_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Phenyang\source\repos\Contact_Tracing\Contact Tracing Form Information.txt");
            file.WriteLine("Name: " + namebx.Text);
            file.WriteLine("Contact no.: " + numberbx.Text);
            file.WriteLine("Address: " + addbx.Text);
            file.WriteLine("Email Address: " + emailbx.Text);
            file.WriteLine("Do you have a fever? " + feverbx.Text);
            file.WriteLine("Do you have a dry cough? " + coughbx.Text);
            file.WriteLine("Do you experience headache? " + headbx.Text);
            file.WriteLine("Do you have sore throat? " + sorebx.Text);
            file.WriteLine("Do you experience fatigue? " + fatiguebx.Text);
            file.WriteLine("Do you experience shortness of breath? " + breathbx.Text);
            file.WriteLine("Do you experience body ache? " + bodybx.Text);
            file.WriteLine("Do you experience diarrhea? " + diabx.Text);
            file.WriteLine("Do you experience loss of smell? " + smellbx.Text);
            file.WriteLine("Have you gone somewhere outside your residence city? " + citybx.Text);
            file.WriteLine("Have you had close contact with a Covid 19 patient? " + patientbx.Text);
            file.WriteLine("If yes, state the date of the exposure. If no, type NA. " + exposurebx.Text);

            file.Close();
        }

        
    }
}
