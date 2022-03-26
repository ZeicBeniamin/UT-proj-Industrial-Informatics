using System.Drawing.Drawing2D;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

   

        private void Form2_Load(object sender, EventArgs e)
        {
            GraphicsPath g1 = new GraphicsPath();
            g1.AddEllipse(0, 2, buttonGAME1.Width, buttonGAME1.Height);
            buttonGAME1.Region = new Region(g1);
            g1.Dispose();

            GraphicsPath g2 = new GraphicsPath();
            g2.AddEllipse(0, 0, buttonGAME2.Width, buttonGAME2.Height);
            buttonGAME2.Region = new Region(g2);
            g2.Dispose();

            GraphicsPath g3 = new GraphicsPath();
            g3.AddEllipse(0, 0, buttonGAME3.Width, buttonGAME3.Height);
            buttonGAME3.Region = new Region(g3);
            g3.Dispose();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
