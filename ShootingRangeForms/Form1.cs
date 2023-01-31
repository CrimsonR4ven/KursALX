using ShootingRangeForms.Objects;

namespace ShootingRangeForms
{
    public partial class Form1 : Form
    {
        int LastList = 1;
        public Form1()
        {
            InitializeForm();
            InitializeStartMenu();
        }

        private void Configure_Click(object sender, EventArgs e)
        {
            DisposeStartMenu();
        }

        private void ShopServiceButton_Click(object sender, EventArgs e)
        {
            DisposeStartMenu();
            InitializeComponent();
            InitalizeGunBoxes(HandGuns);
            //InitializeCheckoutMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackCheckout_Click(object sender, EventArgs e)
        {
            DisposeCheckoutMenu();
            InitializeStartMenu();
        }
        #region Radio buttons on checkout
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();
            var radioBtn = (RadioButton)sender;
            InitalizeGunBoxes(GunHolder.FromGunList(dBAccess.GetGunListFromCategory(radioBtn.Text, connString)));
            LastList = 1;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();

            LastList = 2;
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();

            LastList = 3;
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();

            LastList = 4;
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();

            LastList = 5;
        }
        #endregion
        private void ListDispose()
        {
            if (LastList == 1)
            {
                DisposeGunBoxes();
            }
            else if (LastList == 2)
            {

            }
            else if (LastList == 3)
            {

            }
            else if (LastList == 4)
            {

            }
            else if (LastList == 5)
            {

            }
        }
    }
}