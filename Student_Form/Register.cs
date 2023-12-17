using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Form
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* foreach (Form f in Application.OpenForms)
            {
                if (f is Login)
                {
                    f.Show();
                }
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            AppDbcontext db = new AppDbcontext();
            Student stut = new Student()
            {
                Name =  textBox1.Text,
                Password = textBox2.Text,
                Id = textBox5.Text,
                Address = textBox4.Text,
        
            };

            db.Students.Add(stut);   
            db.SaveChanges();
            MessageBox.Show("Added");
            
            Close();
            */

            MessageBox.Show("Added");

        }
    }
}
