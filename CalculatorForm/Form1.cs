using System.Linq.Expressions;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        int operation = 0;
        int x = 0;
        int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "1"; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ClearAfter();
            Screen.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            y = FromScreen();
            if(operation == 1)
            {
                Screen.Text = $"Equals: {(x + y).ToString()}";
            }
            else if (operation == 2)
            {
                Screen.Text = $"Equals: {(x - y).ToString()}";
            }
            else if (operation == 3)
            {
                Screen.Text = $"Equals: {(x * y).ToString()}";
            }
            else if (operation == 4)
            {
                Screen.Text = $"Equals: {(x / y).ToString()} \n\r tutaj s³owo na resztê po angielsku: {(x % y).ToString()}";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operation = 1;
            x = FromScreen();
            Screen.Text = "";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            operation = 2;
            x = FromScreen();
            Screen.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation = 3;
            x = FromScreen();
            Screen.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation = 4;
            x = FromScreen();
            Screen.Text = "";
        }

        private int FromScreen()
        {
            try
            {
                return int.Parse(Screen.Text);
            }
            catch(FormatException ex)
            {
                Screen.Text = "Error: Number cant be empty";
            }
            catch(Exception ex)
            {
                Screen.Text = "Error: Unkonwn error";
            }
            return 0;
        }
        private void ClearAfter()
        {
            string text = Screen.Text;
            try
            {
                if (text[0] == 'E')
                {
                    Screen.Text = "";
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}