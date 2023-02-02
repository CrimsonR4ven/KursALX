using ShootingRangeForms.Interfaces;
using System.Resources;

namespace ShootingRangeForms.Objects
{
	public class LaneChoicePresentBox : IPresentBox
	{
        private string PriceString;

        public Label Name;
        public Label Title;
        public Label NameTwo;
        public Label Price;
        public Label PriceTwo;
        public Label TypeOfLane;
        public Label Description;
        public Label AmountLabel;

        public Cart MyCart;
        public Form1 Forma;
        public Panel ContentBox { get; set; }
        public Button BuyButton;
        public Button BuyButtonTwo;
        public TextBox AmountShots;
        public LaneHolder LaneUsed;
        public LaneHolder LaneUsedTwo;
        public PictureBox PictureOne;
        public PictureBox PictureTwo;

        public LaneChoicePresentBox(LaneHolder laneUsedOne, LaneHolder laneUsedTwo, Cart myCart, Form1 form)
        {
            MyCart = myCart;
            var resources = new ResourceManager(typeof(Form1));
            var image = (Bitmap)resources.GetObject(laneUsedOne.ImgName);
            var imageTwo = (Bitmap)resources.GetObject(laneUsedTwo.ImgName);
            Forma = form;
            ContentBox = new Panel();
            ContentBox.Visible = false;
            ContentBox.BackColor = Color.White;
            LaneUsed = laneUsedOne;
            LaneUsedTwo = laneUsedTwo;

            PictureOne = new PictureBox();
            PictureOne.Location = new Point(ContentBox.Location.X + 5, ContentBox.Location.Y + 5);
            PictureOne.Size = new Size(190, 190);
            PictureOne.Image = image;
            PictureOne.BackColor = System.Drawing.Color.Transparent;
            PictureOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            PictureTwo = new PictureBox();
            PictureTwo.Location = new Point(ContentBox.Location.X + 500, ContentBox.Location.Y + 5);
            PictureTwo.Size = new Size(190, 190);
            PictureTwo.Image = imageTwo;
            PictureTwo.BackColor = System.Drawing.Color.Transparent;
            PictureTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            Title = new Label();
            Title.Text = "Choose Lane for shooting rented gun";
            Title.Location = new Point(ContentBox.Location.X + PictureOne.Width + 5 + 50, ContentBox.Location.Y + 5);
            Title.Size = new Size(250, 20);

            Name = new Label();
            Name.Text = LaneUsed.Name;
            Name.Location = new Point(ContentBox.Location.X + PictureOne.Width + 5 + 10, ContentBox.Location.Y + 25);
            Name.Size = new Size(100, 50);

            NameTwo = new Label();
            NameTwo.Text = LaneUsedTwo.Name;
            NameTwo.Location = new Point(ContentBox.Location.X + PictureOne.Width + 5 + 10 + 180, ContentBox.Location.Y + 25);
            NameTwo.Size = new Size(100, 50);

            /*Description = new Label();
            Description.Text = LaneUsed.Description;
            Description.Location = new Point(ContentBox.Location.X + PictureOne.Width + 200, ContentBox.Location.Y + 5);
            Description.Size = new Size(300, 20);*/

            /*PriceString = LaneUsed.RentPrice.ToString();
            Price = new Label();
            Price.Text = $"Price per hour: {PriceString}";
            Price.Location = new Point(ContentBox.Location.X + 550, ContentBox.Location.Y + 70);*/



            BuyButton = new Button();
            BuyButton.Text = "Rent This One!";
            BuyButton.Size = new Size(100, 30);
            BuyButton.Location = new Point(ContentBox.Location.X + 200 - 5 + 10, ContentBox.Location.Y + ContentBox.Height + 70 - BuyButton.Height - 5);
            BuyButton.Click += new EventHandler(this.AddToCart);

            BuyButtonTwo = new Button();
            BuyButtonTwo.Text = "Rent This One!";
            BuyButtonTwo.Size = new Size(100, 30);
            BuyButtonTwo.Location = new Point(ContentBox.Location.X + 200 - 5 + 10 + 180, ContentBox.Location.Y + ContentBox.Height + 70 - BuyButton.Height - 5);
            BuyButtonTwo.Click += new EventHandler(this.AddToCart);

            ContentBox.Controls.Add(PictureOne);
            ContentBox.Controls.Add(PictureTwo);
            ContentBox.Controls.Add(Title);
            ContentBox.Controls.Add(Name);
            ContentBox.Controls.Add(NameTwo);
            //ContentBox.Controls.Add(Description);
            //ContentBox.Controls.Add(Price);
            ContentBox.Controls.Add(BuyButton);
            ContentBox.Controls.Add(BuyButtonTwo);
            ContentBox.Visible = true;
        }
        public void AddToCart(object sender, EventArgs e)
        {
            MyCart.LanesWillRent.Add(LaneUsed);
            LaneUsed.RentHours += int.Parse("1");
            if (MyCart.Lanes[LaneUsed.LaneType] == true)
            {
                MyCart.Lanes[LaneUsed.LaneType] = false;
            }
            Dispose();
            Forma.InitializeLaneChoices();
        }
        public void AddToCartTwo(object sender, EventArgs e)
        {
            MyCart.LanesWillRent.Add(LaneUsedTwo);
            LaneUsedTwo.RentHours += int.Parse("1");
            if (MyCart.Lanes[LaneUsedTwo.LaneType] == true)
            {
                MyCart.Lanes[LaneUsedTwo.LaneType] = false;
            }
            Dispose();
            Forma.InitializeLaneChoices();
        }
        public void Dispose()
        {
            ContentBox.Visible = false;
            Title.Dispose();
            Name.Dispose();
            NameTwo.Dispose();
            //Price.Dispose();
            //TypeOfLane.Dispose();
            //Description.Dispose();
            //AmountShots.Dispose();
            PictureOne.Dispose();
            PictureTwo.Dispose();
            BuyButton.Dispose();
            BuyButtonTwo.Dispose();
            ContentBox.Dispose();
        }
    }
}
