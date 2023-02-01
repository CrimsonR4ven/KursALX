using ShootingRangeForms.Interfaces;
using System.Resources;

namespace ShootingRangeForms.Objects
{
    public class GunPresentBox : IPresentBox
    {
        private string PriceString;
        public GunHolder GunUsed;
        public Label Name;
        public Label Price;
        public Label TypeOfLane;
        public Label Description;
        public TextBox AmountShots;
        public PictureBox Picture;
        public Button BuyButton;
        public Panel ContentBox;
        public Cart MyCart;

        public GunPresentBox(GunHolder gunUsed, Cart myCart)
        {
            MyCart = myCart;
            var resources = new ResourceManager(typeof(Form1));
            var image = (Bitmap)resources.GetObject(gunUsed.ImgName);

            ContentBox = new Panel();
            ContentBox.BackColor = Color.White;
            GunUsed = gunUsed;

            Picture = new PictureBox();
            Picture.Location = new Point(ContentBox.Location.X + 5, ContentBox.Location.Y + 5);
            Picture.Size = new Size(ContentBox.Size.Height - 10, ContentBox.Size.Height - 10);
            Picture.Image = image;
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            Name = new Label();
            Name.Text = GunUsed.Name;
            Name.Location = new Point(ContentBox.Location.X + Picture.Width + 5, ContentBox.Location.Y + 5);

            Description = new Label();
            Description.Text = GunUsed.Description;
            Description.Location = new Point(ContentBox.Location.X + Picture.Width + 200, ContentBox.Location.Y + 5);
            Description.Size = new Size(300, 20);

            PriceString = (GunUsed.Price).ToString();
            Price = new Label();
            Price.Text = $"Price per shot: {PriceString}";
            Price.Location = new Point(ContentBox.Location.X + 550, ContentBox.Location.Y + 70);


            BuyButton = new Button();
            BuyButton.Text = "Rent This Gun!";
            BuyButton.Size = new Size(100,30);
            BuyButton.Location = new Point(ContentBox.Location.X + ContentBox.Width - BuyButton.Width - 5, ContentBox.Location.Y + ContentBox.Height - BuyButton.Height - 5);
            BuyButton.Click += new EventHandler(this.AddToCart);
            ContentBox.Controls.Add(Picture);
            ContentBox.Controls.Add(Name);
            ContentBox.Controls.Add(Description);
            ContentBox.Controls.Add(Price);
            ContentBox.Controls.Add(BuyButton);
        }

		public void Dispose()
		{
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
            if (!MyCart.GunsWillBuy.Contains(GunUsed))
            {
                MyCart.GunsWillBuy.Add(GunUsed);
            }
            GunUsed.Amount += int.Parse("5");
        }
	}
}
