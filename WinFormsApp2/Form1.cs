using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        int flag1 = 0;
        DateTime now;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TimeBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (flag1 == 0)
            {
                try
                {
                    now = DateTime.Now.AddMinutes(Int32.Parse(InputTime1.Text));
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("몇 분인지 적어주세요!");
                    return;
                }

                timer1.Interval = 1000;
                timer1.Start();
                button1.Text = "=";
                flag1 = 1;

            }

            else if (flag1 == 1)
            {
                string NowTime = TimeBox1.Text;

                timer1.Stop();
                button1.Text = "▶";
                flag1 = 2;

            }
            else if (flag1 == 2) 
            {
                TimeBox1.Text = NowTime;

                //현재 값이 되어야함ㅠ

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = now - DateTime.Now;
            //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Abs(t.Hours), Math.Abs(t.Minutes), Math.Abs(t.Seconds));
            //textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", (t.Hours), (t.Minutes), (t.Seconds));
         
            TimeBox1.Text = String.Format("{0}", t.ToString("hh':'mm':'ss"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}