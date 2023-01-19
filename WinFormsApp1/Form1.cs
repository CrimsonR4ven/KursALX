using Lotto.Objects;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			InitBuyTicket();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (TempNumbers.Count == 6 && textBox2.Text != "")
			{
				ListOfTickets.Add(new Ticket(textBox2.Text, TempNumbers));
				TempNumbers.Clear();
				PresentNumbers();
				DisposeBuyTicket();
				InitBuyTicket();
			}
		}

		private void NumbersCheckedChanged(object sender, EventArgs e)
		{
			var checkBox = (sender as CheckBox);
			if (checkBox.Checked == true && TempNumbers.Count < 6)
			{
				TempNumbers.Add(int.Parse(checkBox.Text));
				checkBox.BackColor = Color.Red;
				PresentNumbers();
			}
			else if(checkBox.Checked == true && TempNumbers.Count >= 6)
			{
				checkBox.Checked = false;
			}
			else if (checkBox.Checked == false)
			{
				TempNumbers.Remove(int.Parse(checkBox.Text));
				checkBox.BackColor = Color.Navy;
				PresentNumbers();
			}
		}
		private void PresentNumbers()
		{
			TempNumbers.Sort();
			textBox1.Text = "";
			foreach (int number in TempNumbers)
			{
				textBox1.Text += number.ToString() + " ";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
                DisposeBuyTicket();
            }
			catch
			{
				DisposeAnswerSeeker();
			}
			InitBuyTicket();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DisposeBuyTicket();
			InitAnswerSeeker();
			TempNumbers.Clear();
			Random rand = new Random();
			bool c = true;
			int temp;
			for (int i = 0; i < 6; i++)
			{
				c = true;
				while (c == true)
				{
					temp = ((int)rand.Next() % 49) + 1;
					if (!TempNumbers.Exists(x => x == temp))
					{
						TempNumbers.Add(temp);
						c = false;
					}
				}
			}
			TempNumbers.Sort();
			textBox3.Text = "Thee shall receiveth thy answ'rs \r\nWinning numbers art:\r\n";
			foreach(int number in TempNumbers)
			{
				textBox3.Text += number.ToString() + " ";
			}
			foreach (Ticket ticket in ListOfTickets)
			{
				textBox4.Text += ticket.Username + HowMuchWin(ticket); 
			}
		}

		private string HowMuchWin(Ticket ticket)
		{
			var win = ": ";
			var numberOfWinningNumbers = 0;
            foreach(int number in ticket.Numbers)
			{
				if (TempNumbers.Contains(number))
				{
					numberOfWinningNumbers++;
				}
			}
			if(numberOfWinningNumbers < 3)
			{
				win += $"you've got {numberOfWinningNumbers} numbers matching,\r\n no prize for thee sadly\r\n";
			}
            else if (numberOfWinningNumbers == 3)
            {
                win += $"you win absourdly high \r\namount of 24 PLN\r\n";
            }
            else if (numberOfWinningNumbers == 4)
            {
                win += $"you win 174 PLN\r\n";
            }
            else if (numberOfWinningNumbers == 5)
            {
                win += $"you win 6.482 PLN\r\n";
            }
			else
			{
                win += $"Sadly you win small \r\namount of 8.500.000PLN\r\n";
            }
			return win;
        } 
	}
}