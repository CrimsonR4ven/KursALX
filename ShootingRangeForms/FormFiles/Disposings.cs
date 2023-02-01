using ShootingRangeForms.Interfaces;
using ShootingRangeForms.Objects;
namespace ShootingRangeForms
{
	partial class Form1
	{
		private void DisposeStartMenu()
		{
			ConfigureButton.Dispose();
			ConfigureLabel.Dispose();
			CheckoutButton.Dispose();
			CheckoutLabel.Dispose();
			pictureBox1.Dispose();
			pictureBox2.Dispose();
			pictureBox3.Dispose();
			panel1.Dispose();
			label1.Dispose();
			label2.Dispose();
		}
		public void DisposeCheckoutMenu()
		{
			panel2.Dispose();
			BackCheckout.Dispose();
			BuyCheckout.Dispose();
		}
		public void DisposeGunBoxes(List<IPresentBox> presentBoxes)
		{
			foreach (IPresentBox presentBox in presentBoxes)
			{
				presentBox.Dispose();
			}
		}
	}
}
