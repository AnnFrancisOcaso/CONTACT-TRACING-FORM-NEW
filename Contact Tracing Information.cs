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
    public partial class Contact_Tracing_Information : Form
    {
        public Contact_Tracing_Information()
        {
            InitializeComponent();
        }

        public void receiveData(List<string> userInput)
        {
            uInput = userInput;
        }
        List<string> uInput = new List<string>();
        DataTable dt = new DataTable();
        //Creating array to receive list items
        String[] usIn = new string[17];
        int t = 0;

        private void savebttn_Click(object sender, EventArgs e)
        {
            using (StreamWriter tw = new StreamWriter(@"C:\Users\Phenyang\source\repos\Contact_Tracing\List contact tracing information.txt"))
            {
                for (int i = 0; i < dataGridViewctf.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewctf.Columns.Count; j++)
                    {
                        tw.WriteLine($"{dataGridViewctf.Rows[i].Cells[j].Value.ToString()},");
                    }
                }
            }

            MessageBox.Show("Information saved");
        }

        private void Contact_Tracing_Information_Load(object sender, EventArgs e)
        {
            //Adding colums to datatable
            dt.Columns.Add("Date", typeof(String));
            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Address", typeof(String));
            dt.Columns.Add("Contact no.", typeof(String));
            dt.Columns.Add("Email Address", typeof(String));
            dt.Columns.Add("fever", typeof(String));
            dt.Columns.Add("dry cough", typeof(String));
            dt.Columns.Add("headache", typeof(String));
            dt.Columns.Add("sore throat", typeof(String));
            dt.Columns.Add("fatigue", typeof(String));
            dt.Columns.Add("shortness of breath", typeof(String));
            dt.Columns.Add("body ache", typeof(String));
            dt.Columns.Add("diarrhea", typeof(String));
            dt.Columns.Add("loss of smell", typeof(String));
            dt.Columns.Add("had close contact", typeof(String));
            dt.Columns.Add("gone to another city", typeof(String));
            dt.Columns.Add("date of exposure", typeof(String));

            foreach (String x in uInput)
            {
                usIn[t] = x;
                t++;
            }

            //Adding rows to datatable
            dt.Rows.Add(usIn);
            dataGridViewctf.DataSource = dt;
        }
    }
}
