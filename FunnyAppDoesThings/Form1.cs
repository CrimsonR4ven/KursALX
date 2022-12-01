using System.Diagnostics;

namespace FunnyAppDoesThings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public void DoSomething()
        {
            if (textBox1.Text == "")
            {
                Random rnd = new Random();
                long i = rnd.NextInt64(20, 1500);
                long j = rnd.NextInt64(20, 1500);
                ClientSize = new Size((int)i, (int)j);
                SizeChange();
            }
            else if (textBox1.Text == "higher")
            {
                ClientSize = new Size(ClientSize.Width, ClientSize.Height + 100);
                SizeChange();
            }
            else if (textBox1.Text == "wider")
            {
                ClientSize = new Size(ClientSize.Width + 100, ClientSize.Height);
                SizeChange();
            }
            else if (textBox1.Text == "total apocalypse")
            {
                ClientSize = new Size(1, 1);
                Process.Start("C:\\Users\\k4spa\\source\\repos\\KursALX\\QuickAnihilation\\bin\\Debug\\net6.0-windows\\QuickAnihilation.exe");
            }
            else if (textBox1.Text == "What")
            {
                ThreadStart discoRef = new ThreadStart(RandomColor);
                Thread discoThread = new Thread(discoRef);
                discoThread.Start();
            }
            else
            {
                Text = textBox1.Text;
            }
        }

        private void RandomColor()
        {
            while (true)
            {
                panel2.BackColor = System.Drawing.Color.Red;
                panel1.BackColor = System.Drawing.Color.Blue;
                panel3.BackColor = System.Drawing.Color.Green;
                Thread.Sleep(500);
                panel2.BackColor = System.Drawing.Color.Blue;
                panel1.BackColor = System.Drawing.Color.Green;
                panel3.BackColor = System.Drawing.Color.YellowGreen;
                Thread.Sleep(500);
                panel2.BackColor = System.Drawing.Color.Green;
                panel1.BackColor = System.Drawing.Color.YellowGreen;
                panel3.BackColor = System.Drawing.Color.Red;
                Thread.Sleep(500);
                panel2.BackColor = System.Drawing.Color.YellowGreen;
                panel1.BackColor = System.Drawing.Color.Red;                
                panel3.BackColor = System.Drawing.Color.Blue;
                Thread.Sleep(500);
            }
        }
        private void SizeChange()
        {
            panel1.Width = ClientSize.Width / 2;
            panel1.Height = ClientSize.Height / 2;
            panel2.Width = ClientSize.Width / 2;
            panel2.Height = ClientSize.Height / 2;
            panel3.Width = ClientSize.Width / 2;
            panel3.Height = ClientSize.Height / 2;
            panel4.Width = ClientSize.Width / 2;
            panel4.Height = ClientSize.Height / 2;
            panel2.Location = new System.Drawing.Point(0 + ClientSize.Width / 2, 0);
            panel3.Location = new System.Drawing.Point(0, 0 + ClientSize.Height / 2);
            panel4.Location = new System.Drawing.Point(0 + ClientSize.Width / 2, 0 + ClientSize.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoSomething();
        }
    }
}