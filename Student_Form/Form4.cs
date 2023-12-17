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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Load_FormClosing(object sender, FormClosingEventArgs e)
        {

            /* foreach (Form f in Application.OpenForms)
             {
                 if (f is Login)
                 {
                     f.Show();
                 }
             }
           */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Hide();
            f3.ShowDialog();
        }
    }
}
