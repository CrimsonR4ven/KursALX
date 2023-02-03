using ShootingRangeForms.Interfaces;
using ShootingRangeForms.Objects;
using System.Resources;

namespace ShootingRangeForms.PresentBoxes
{
	public class GunPresentBox : IPresentBox
	{
		private string PriceString;

		public Panel ContentBox { get; set; }

		public Cart		  MyCart;
		public Label	  Name;
		public Label	  Price;
		public Label	  TypeOfLane;
		public Label	  Description;
		public Label	  AmountLabel;
		public Button	  BuyButton;
		public TextBox	  AmountShots;
		public GunHolder  GunUsed;
		public PictureBox Picture;

		public GunPresentBox(GunHolder gunUsed, Cart myCart, Form1 form)
		{
			MyCart = myCart;
			var resources = new ResourceManager(typeof(Form1));
			var image = (Bitmap)resources.GetObject(gunUsed.ImgName);
			ContentBox = new Panel();
			ContentBox.Visible = false;
			ContentBox.BackColor = Color.White;
			GunUsed = gunUsed;

			Picture = new PictureBox();
			Picture.Location = new Point(ContentBox.Location.X + 5, ContentBox.Location.Y + 5);
			Picture.Size = new Size(ContentBox.Size.Height - 10, ContentBox.Size.Height - 10);
			Picture.Image = image;
			Picture.BackColor = Color.Transparent;
			Picture.SizeMode = PictureBoxSizeMode.Zoom;

			Name = new Label();
			Name.Text = GunUsed.Name;
			Name.Location = new Point(ContentBox.Location.X + Picture.Width + 5, ContentBox.Location.Y + 5);
			Name.Size = new Size(150, 20);

			Description = new Label();
			Description.Text = GunUsed.Description;
			Description.Location = new Point(ContentBox.Location.X + Picture.Width + 200, ContentBox.Location.Y + 5);
			Description.Size = new Size(300, 20);

			PriceString = GunUsed.Price.ToString();
			Price = new Label();
			Price.Text = $"Price per shot: {PriceString}";
			Price.Location = new Point(ContentBox.Location.X + 550, ContentBox.Location.Y + 70);

			AmountShots = new TextBox();
			AmountShots.Location = new Point(ContentBox.Location.X + 550, ContentBox.Location.Y + 43);
			AmountShots.KeyPress += new KeyPressEventHandler(AmountShots_KeyPress);
			AmountLabel = new Label();
			AmountLabel.Text = "Number of shots";
			AmountLabel.Location = new Point(ContentBox.Location.X + 550, ContentBox.Location.Y + 24);
			AmountLabel.Size = new Size(150, 20);

			BuyButton = new Button();
			BuyButton.Text = "Rent This Gun!";
			BuyButton.Size = new Size(100, 30);
			BuyButton.Location = new Point(ContentBox.Location.X + ContentBox.Width - BuyButton.Width - 5, ContentBox.Location.Y + ContentBox.Height - BuyButton.Height - 5);
			BuyButton.Click += new EventHandler(AddToCart);
			ContentBox.Controls.Add(Picture);
			ContentBox.Controls.Add(Name);
			ContentBox.Controls.Add(Description);
			ContentBox.Controls.Add(AmountShots);
			ContentBox.Controls.Add(AmountLabel);
			ContentBox.Controls.Add(Price);
			ContentBox.Controls.Add(BuyButton);
			ContentBox.Visible = true;
		}

		public void Dispose()
		{
			ContentBox.Visible = false;
			Name.Dispose();
			Price.Dispose();
			//TypeOfLane.Dispose();
			Description.Dispose();
			//AmountShots.Dispose();
			Picture.Dispose();
			BuyButton.Dispose();
			ContentBox.Dispose();
		}
		public void AddToCart(object sender, EventArgs e)
		{
			if (!MyCart.GunsWillRent.Contains(GunUsed))
			{
				MyCart.GunsWillRent.Add(GunUsed);
			}
			GunUsed.Amount += int.Parse(AmountShots.Text);
			if (MyCart.Lanes[GunUsed.Lane] == false && !MyCart.ContainsLane(GunUsed.Lane))
			{
				MyCart.Lanes[GunUsed.Lane] = true;
			}
		}
		private void AmountShots_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
		{
			if (char.IsDigit(KeyPressEvent.KeyChar) || KeyPressEvent.KeyChar == '\b')
			{
				if (KeyPressEvent.KeyChar == '0' && AmountShots.Text == "")
				{
					KeyPressEvent.Handled = true;
				}
				else
				{
					KeyPressEvent.Handled = false;
				}
			}
			else
				KeyPressEvent.Handled = true;
		}
	}
}
