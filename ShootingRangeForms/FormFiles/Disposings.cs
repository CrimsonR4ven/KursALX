using ShootingRangeForms.Interfaces;
using ShootingRangeForms.Objects;
namespace ShootingRangeForms
{
	partial class Form1
	{
		private void DisposeStartMenu()
		{
			panel1.Dispose();
			label1.Dispose();
			label2.Dispose();
			pictureBox1.Dispose();
			pictureBox2.Dispose();
			pictureBox3.Dispose();
			CheckoutLabel.Dispose();
			ConfigureLabel.Dispose();
			CheckoutButton.Dispose();
			ConfigureButton.Dispose();
		}
		private void DisposeCheckoutMenu()
		{
			panel2.Dispose();
			panel3.Dispose();
			BuyCheckout.Dispose();
			BackCheckout.Dispose();
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
