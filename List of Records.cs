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
    public partial class LoginInfo : Form
    {

        public LoginInfo()
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
        String[] usIn = new string[4];
        int r = 0;
        private void List_of_Records_Load(object sender, EventArgs e)
        {
            //Adding colums to datatable
            dt.Columns.Add("Date", typeof(String));
            dt.Columns.Add("Name", typeof(String)); 
            dt.Columns.Add("Surname", typeof(String));
            dt.Columns.Add("Temperature", typeof(String));
           
            foreach(String x in uInput)
            {
                usIn[r] = x;
                r++;
            }

            //Adding rows to datatable
            dt.Rows.Add(usIn);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter tw = new StreamWriter(@"C:\Users\Phenyang\source\repos\Contact_Tracing\List Login.txt"))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.WriteLine($"{dataGridView1.Rows[i].Cells[j].Value.ToString()},");
                    }
                }
            }

            MessageBox.Show("Save Information!");
        }
    }
}
