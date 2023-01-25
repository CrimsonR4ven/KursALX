using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ShootingRangeForms.Objects
{
    public class GunPresentBox
    {
        private string PriceString;
        public GunHolder GunUsed;
        public Label Name;
        public Label Price;
        public Label TypeOfLane;
        public TextBox Description;
        public TextBox AmountShots;
        public PictureBox Picture;
        public Button BuyButton;
        public Panel ContentBox;

        public GunPresentBox(GunHolder gunUsed)
        {
            ContentBox = new Panel();
            ContentBox.BackColor = Color.White;
            GunUsed = gunUsed;

            Picture = new PictureBox();
            Picture.Location = new Point(ContentBox.Location.X + 5, ContentBox.Location.Y + 5);
            Picture.Size = new Size(ContentBox.Size.Height - 10, ContentBox.Size.Height - 10);
            Picture.Image = global::ShootingRangeForms.Properties.Resources.Revolver;
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            Name = new Label();
            Name.Text = GunUsed.Name;
            Name.Location = new Point(ContentBox.Location.X + Picture.Width + 5, ContentBox.Location.Y + 5);

            PriceString = (GunUsed.Price).ToString();
            Price = new Label();
            Price.Text = $"Price per shot: {PriceString}";
            Price.Location = new Point(ContentBox.Location.X + 550, ContentBox.Location.Y + 70);

            BuyButton = new Button();
            BuyButton.Text = "Rent This Gun!";
            BuyButton.Size = new Size(100,30);
            BuyButton.Location = new Point(ContentBox.Location.X + ContentBox.Width - BuyButton.Width - 5, ContentBox.Location.Y + ContentBox.Height - BuyButton.Height - 5);
            ContentBox.Controls.Add(Picture);
            ContentBox.Controls.Add(Name);
            ContentBox.Controls.Add(Price);
            ContentBox.Controls.Add(BuyButton);
        }
    }
}
