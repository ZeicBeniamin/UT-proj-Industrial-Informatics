using System.Drawing.Drawing2D;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("login.txt", true);
            streamWriter.WriteLine("username password");
            streamWriter.Close();

            StreamReader streamReader = new StreamReader("login.txt");
            {
                string line = String.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(' ');
                    textBoxUsername.Text = tempArray[0];
                    textBoxPassword.Text = tempArray[1];
                }
            }

            Form2 form = new Form2();
            form.Show();
        }

            

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath g1 = new GraphicsPath();
            g1.AddEllipse(0, 2, buttonLogin.Width, buttonLogin.Height);
            buttonLogin.Region = new Region(g1);
            g1.Dispose();
        }

     

        private void buttonRegisterForm1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}