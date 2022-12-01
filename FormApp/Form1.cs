namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HardCodedButton = new Button();
            HardCodedButton.Parent = this;
            HardCodedButton.Top = 150;
            HardCodedButton.Left = 150;
            HardCodedButton.Text = "Koles³aw ale Hard Coded";
            HardCodedButton.Width = 100;
            HardCodedButton.Click += new System.EventHandler(SayKoleslaw);
            HardCodedButton = new Button();
            HardCodedButton.Parent = this;
            HardCodedButton.Top = 200;
            HardCodedButton.Left = 150;
            HardCodedButton.Text = "Koles³aw ale Hard Coded";
            HardCodedButton.Width = 100;
            HardCodedButton.Click += new System.EventHandler(ExtendButton);
        }

        private void SayKoleslaw(Object sender, EventArgs args)
        {
            MessageBox.Show("Koles³aw!");
        }

        private void ExtendButton(Object sender, EventArgs args)
        {
            HardCodedButton.Width += 100;
        }
    }
}