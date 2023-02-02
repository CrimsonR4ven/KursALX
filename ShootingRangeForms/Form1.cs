using ShootingRangeForms.Objects;

namespace ShootingRangeForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //todo Loading screen
            dBAccess.TestConnection();
            // if true end loading screen else no connection window
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
            InitalizeGunBoxes(GunHolder.FromGunList(dBAccess.GetGunListFromCategory("HandGuns", connString)));
            //InitializeCheckoutMenu();
        }
        private void BackCheckout_Click(object sender, EventArgs e)
        {
            ListDispose();
            DisposeCheckoutMenu();
            InitializeStartMenu();
        }
        #region Radio buttons on checkout
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();
            var radioBtn = (RadioButton)sender;
            InitalizeGunBoxes(GunHolder.FromGunList(dBAccess.GetGunListFromCategory(radioBtn.Text, connString)));
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();
            InitalizeLaneBoxes(LaneHolder.FromLaneList(dBAccess.GetLaneList(connString)));
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            ListDispose();
            InitializeLaneChoices();       
        }
        #endregion
        public void ListDispose()
        {
            DisposeGunBoxes(GunsPresent);
            //todo lookin bad, fix that
        }
    }
}