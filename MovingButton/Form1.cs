namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var left = rand.Next(0, this.ClientSize.Width - button1.Width);
            var top = rand.Next(0, this.ClientSize.Height - button1.Height);
            button1.Left = left;
            button1.Top = top;
        }
    }
}