namespace running_man
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Image = imageList1.Images[num];
            if (num == 3)
            {
                num = 0;
            }
            else
            {
                num = num + 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 200;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left - 30;
            if (pictureBox3.Left < 90)
            {
                pictureBox3.Left -= 30;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}