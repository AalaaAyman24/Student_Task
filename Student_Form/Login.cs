namespace Student_Form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            /*  AppDbcontext db = new AppDbcontext();
              string name = textBox1.Text, pass = textBox2.Text;

              var res = db.Students.Where(a => a.Name == name && pass == a.Password).FirstOrDefault();
              if (res != null)
              {
                  MessageBox.Show("Correct");

              }


              */
               Form4 f = new Form4();
               Hide();
               f.ShowDialog();  

               



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Register form2 = new Register();
            form2.ShowDialog();
            this.Close();
            /*

             Form4 Data = new Form4();
             Hide();
             Data.ShowDialog();

             */


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
