using ShootingRangeForms.Interfaces;
using System.Resources;

namespace ShootingRangeForms.Objects
{
	public class LanePresentBox : IPresentBox
	{
        private string PriceString;

        public Label Name;
        public Label Price;
        public Label TypeOfLane;
        public Label Description;
        public Label AmountLabel;

        public Cart MyCart;
        public Panel ContentBox { get; set; }
        public Button BuyButton;
        public TextBox AmountShots;
        public PictureBox Picture;
        public LaneHolder LaneUsed;

        public LanePresentBox(LaneHolder laneUsed, Cart myCart, Form1 form)
        {
            MyCart = myCart;
            var resources = new ResourceManager(typeof(Form1));
            var image = (Bitmap)resources.GetObject(laneUsed.ImgName);

            ContentBox = new Panel();
            ContentBox.Visible = false;
            ContentBox.BackColor = Color.White;
            LaneUsed = laneUsed;

            Picture = new PictureBox();
            Picture.Location = new Point(ContentBox.Location.X + 5, ContentBox.Location.Y + 5);
            Picture.Size = new Size(ContentBox.Size.Height - 10, ContentBox.Size.Height - 10);
            Picture.Image = image;
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            Name = new Label();
            Name.Text = LaneUsed.Name;
            Name.Location = new Point(ContentBox.Location.X + Picture.Width + 5, ContentBox.Location.Y + 5);
            Name.Size = new Size(180, 20);

            Description = new Label();
            Description.Text = LaneUsed.Description;
            Description.Location = new Point(ContentBox.Location.X + Picture.Width + 200, ContentBox.Location.Y + 5);
            Description.Size = new Size(300, 20);

            PriceString = LaneUsed.RentPrice.ToString();
            Price = new Label();
            Price.Text = $"Price per hour: {PriceString}";
            Price.Location = new Point(ContentBox.Location.X + 550, ContentBox.Location.Y + 70);

            AmountShots = new TextBox();
            AmountShots.Location = new Point(ContentBox.Location.X + 550, ContentBox.Location.Y + 43);
            AmountShots.KeyPress += new KeyPressEventHandler(this.AmountShots_KeyPress);
            AmountLabel = new Label();
            AmountLabel.Text = "Number of hours";
            AmountLabel.Location = new Point(ContentBox.Location.X + 550, ContentBox.Location.Y + 24);
            AmountLabel.Size = new Size(150, 20);

            BuyButton = new Button();
            BuyButton.Text = "Rent This Lane!";
            BuyButton.Size = new Size(100, 30);
            BuyButton.Location = new Point(ContentBox.Location.X + ContentBox.Width - BuyButton.Width - 5, ContentBox.Location.Y + ContentBox.Height - BuyButton.Height - 5);
            BuyButton.Click += new EventHandler(this.AddToCart);
            ContentBox.Controls.Add(Picture);
            ContentBox.Controls.Add(Name);
            ContentBox.Controls.Add(Description);
            ContentBox.Controls.Add(AmountShots);
            ContentBox.Controls.Add(AmountLabel);
            ContentBox.Controls.Add(Price);
            ContentBox.Controls.Add(BuyButton);
            ContentBox.Visible = true;
        }
        public void AddToCart(object sender, EventArgs e)
		{
            if (!MyCart.LanesWillRent.Contains(LaneUsed))
            {
                MyCart.LanesWillRent.Add(LaneUsed);
            }
            LaneUsed.RentHours += int.Parse(AmountShots.Text);
            if (MyCart.Lanes[LaneUsed.LaneType] == true)
            {
                MyCart.Lanes[LaneUsed.LaneType] = false;
            }
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
        private void AmountShots_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            if (char.IsDigit(KeyPressEvent.KeyChar) || KeyPressEvent.KeyChar == '\b')
            {
                if (KeyPressEvent.KeyChar == '0' && this.AmountShots.Text == "")
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
