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
    public partial class Contact_Tracing_Form : Form
    {
        public Contact_Tracing_Form()
        {
            InitializeComponent();
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

            //radio button select yes or no
            //do you have a fever
            String feverAnswer = "";
            if (feveryesrb.Checked)
            {
                feverAnswer = feveryesrb.Text;
                file.WriteLine("Do you have a fever? " + "Yes");
            }

            if (fevernorb.Checked)
            {
                feverAnswer = fevernorb.Text;
                file.WriteLine("Do you have a fever? " + "No");
            }

            //Do you have a dry cough?
            String drycoughAnswer = "";
            if (coughyesrb.Checked)
            {
                drycoughAnswer = coughyesrb.Text;
                file.WriteLine("Do you have a dry cough? " + "Yes");
            }

            if (coughnorb.Checked)
            {
                drycoughAnswer = coughnorb.Text;
                file.WriteLine("Do you have a dry cough? " + "No");
            }

            //Do you experience headache?
            String headacheAnswer = "";
            if (headacheyesrb.Checked)
            {
                headacheAnswer = headacheyesrb.Text;
                file.WriteLine("Do you experience headache? " + "Yes");
            }

            if (headachenorb.Checked)
            {
                headacheAnswer = headachenorb.Text;
                file.WriteLine("Do you experience headache? " + "No");
            }

            //Do you have sore throat?
            String soreAnswer = "";
            if (headacheyesrb.Checked)
            {
                soreAnswer = soreyesrb.Text;
                file.WriteLine("Do you have sore throat? " + "Yes");
            }

            if (sorenorb.Checked)
            {
                soreAnswer = sorenorb.Text;
                file.WriteLine("Do you have sore throat? " + "No");
            }

            //Do you experience fatigue?
            String fatigueAnswer = "";
            if (fatigueyesrb.Checked)
            {
                fatigueAnswer = fatigueyesrb.Text;
                file.WriteLine("Do you experience fatigue? " + "Yes");
            }

            if (fatiguenorb.Checked)
            {
                fatigueAnswer = fatiguenorb.Text;
                file.WriteLine("Do you experience fatigue? " + "No");
            }

            //Do you experience shortness of breath?
            String breathAnswer = "";
            if (breathyesrb.Checked)
            {
                breathAnswer = breathyesrb.Text;
                file.WriteLine("Do you experience shortness of breath? " + "Yes");
            }

            if (breathnorb.Checked)
            {
                breathAnswer = breathnorb.Text;
                file.WriteLine("Do you experience shortness of breath? " + "No");
            }

            //Do you experience body ache?
            String bodyAnswer = "";
            if (bodyyesrb.Checked)
            {
                bodyAnswer = bodyyesrb.Text;
                file.WriteLine("Do you experience body ache? " + "Yes");
            }

            if (bodynorb.Checked)
            {
                bodyAnswer = bodynorb.Text;
                file.WriteLine("Do you experience body ache? " + "No");
            }

            //Do you experience diarrhea?
            String diarrheaAnswer = "";
            if (diarrheayesrb.Checked)
            {
                diarrheaAnswer = diarrheayesrb.Text;
                file.WriteLine("Do you experience diarrhea? " + "Yes");
            }

            if (diarrheanorb.Checked)
            {
                diarrheaAnswer = diarrheanorb.Text;
                file.WriteLine("Do you experience diarrhea? " + "No");
            }

            //Do you experience loss of smell?
            String smellAnswer = "";
            if (smellyesrb.Checked)
            {
                smellAnswer = smellyesrb.Text;
                file.WriteLine("Do you experience loss of smell? " + "Yes");
            }

            if (smellnorb.Checked)
            {
                smellAnswer = smellnorb.Text;
                file.WriteLine("Do you experience loss of smell? " + "No");
            }

            //Have you gone somewhere outside your residence city?
            String goneAnswer = "";
            if (goneyesrb.Checked)
            {
                goneAnswer = goneyesrb.Text;
                file.WriteLine("Have you gone somewhere outside your residence city? " + "Yes");
            }

            if (gonenorb.Checked)
            {
                goneAnswer = gonenorb.Text;
                file.WriteLine("Have you gone somewhere outside your residence city? " + "No");
            }

            //Have you had close contact with a Covid 19 patient?
            String patientAnswer = "";
            if (patientyesrb.Checked)
            {
                patientAnswer = patientyesrb.Text;
                file.WriteLine("Have you had close contact with a Covid 19 patient? " + "Yes");
            }

            if (patientnorb.Checked)
            {
                patientAnswer = patientnorb.Text;
                file.WriteLine("Have you had close contact with a Covid 19 patient? " + "No");
            }

            //If yes, state the date of the exposure. If no, type NA.

            file.WriteLine("If yes, state the date of the exposure. If no, type NA. " + exposurebx.Text);

            file.Close();
        }

        private void checkbttn_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\Phenyang\source\repos\Contact_Tracing\Contact Tracing Form Information.txt");

            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                MessageBox.Show(line);
            }

        }
    }
}
