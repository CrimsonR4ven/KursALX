using ShootingRangeForms.Enums;
using ShootingRangeForms.Interfaces;
using ShootingRangeForms.Objects;
namespace ShootingRangeForms
{
	partial class Form1
	{
		private void InitializeForm()
		{
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Maroon;
			this.ClientSize = new Size(1046, 659);
			this.Name = "Shooting Range";
			this.Text = "Shooting Range";
		}

		private void InitializeStartMenu()
		{
			this.ConfigureButton = new Button();
			this.CheckoutButton = new Button();
			this.ConfigureLabel = new Label();
			this.CheckoutLabel = new Label();
			this.label1 = new Label();
			this.pictureBox1 = new PictureBox();
			this.panel1 = new Panel();
			this.pictureBox2 = new PictureBox();
			this.pictureBox3 = new PictureBox();
			this.label2 = new Label();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			this.SuspendLayout();
			// 
			// ConfigureButton
			// 
			this.ConfigureButton.Location = new Point(108, 149);
			this.ConfigureButton.Name = "ConfigureButton";
			this.ConfigureButton.Size = new Size(111, 23);
			this.ConfigureButton.TabIndex = 0;
			this.ConfigureButton.UseVisualStyleBackColor = true;
			this.ConfigureButton.Click += new EventHandler(this.Configure_Click);
			// 
			// CheckoutButton
			// 
			this.CheckoutButton.Location = new Point(108, 211);
			this.CheckoutButton.Name = "CheckoutButton";
			this.CheckoutButton.Size = new Size(111, 23);
			this.CheckoutButton.TabIndex = 2;
			this.CheckoutButton.UseVisualStyleBackColor = true;
			this.CheckoutButton.Click += new EventHandler(this.ShopServiceButton_Click);
			// 
			// ConfigureLabel
			// 
			this.ConfigureLabel.AutoSize = true;
			this.ConfigureLabel.BackColor = Color.Black;
			this.ConfigureLabel.ForeColor = Color.Maroon;
			this.ConfigureLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			this.ConfigureLabel.Location = new Point(100, 115);
			this.ConfigureLabel.Name = "ConfigureLabel";
			this.ConfigureLabel.Size = new Size(85, 15);
			this.ConfigureLabel.TabIndex = 3;
			this.ConfigureLabel.Text = "Configure App";
			// 
			// CheckoutLabel
			// 
			this.CheckoutLabel.AutoSize = true;
			this.CheckoutLabel.ForeColor = Color.Maroon;
			this.CheckoutLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			this.CheckoutLabel.Location = new Point(105, 180);
			this.CheckoutLabel.Name = "CheckoutLabel";
			this.CheckoutLabel.Size = new Size(80, 15);
			this.CheckoutLabel.TabIndex = 4;
			this.CheckoutLabel.Text = "Self Checkout";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Maroon;
			this.label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			this.label1.Location = new Point(43, 23);
			this.label1.Name = "label1";
			this.label1.Size = new Size(242, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Shooting Range App";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.BackgroundImage = Properties.Resources.Revolver;
			this.pictureBox1.Image = Properties.Resources.Revolver;
			this.pictureBox1.Location = new Point(-1067, 187);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(206, 229);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.Black;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.ConfigureLabel);
			this.panel1.Controls.Add(this.ConfigureButton);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.CheckoutButton);
			this.panel1.Controls.Add(this.CheckoutLabel);
			this.panel1.Location = new Point(360, -6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(324, 687);
			this.panel1.TabIndex = 7;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = Color.Transparent;
			this.pictureBox2.Image = Properties.Resources.Revolver;
			this.pictureBox2.Location = new Point(690, 17);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(346, 328);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = Color.Transparent;
			this.pictureBox3.Image = Properties.Resources.Revolver2;
			this.pictureBox3.Location = new Point(8, 17);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(346, 328);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = Color.Maroon;
			this.label2.Location = new Point(95, 456);
			this.label2.Name = "label2";
			this.label2.Size = new Size(38, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Made by: Crimson Raven";
			// 
			// Form1
			// 
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			this.ResumeLayout(false);
		}
		private void InitializeChoiceMenu()
		{
			//TODO Choice menu
		}
		private void InitializeCheckoutMenu()
		{
			//TODO checkout menu
		}
		private void InitalizeGunBoxes(List<GunHolder> gunList)
		{
			ObjectListCreate(gunList);
			height = 20;
			foreach (GunPresentBox gunPresent in GunsPresent)
			{
				gunPresent.ContentBox.Location = new Point(panel2.Width + 20, height);
				gunPresent.ContentBox.Size = new Size(ClientSize.Width - panel2.Width - 40, 100);
				Controls.Add(gunPresent.ContentBox);
				height += gunPresent.ContentBox.Height + 20;
			}
		}
		public void InitalizeGunCartBoxes()
		{
			ObjectListCreate();
			height = 20;
			foreach (IPresentBox gunCartPresent in GunsPresent)
			{
				gunCartPresent.ContentBox.Location = new Point(panel2.Width + 20, height);
				gunCartPresent.ContentBox.Size = new Size(ClientSize.Width - panel2.Width - 40, 100);
				Controls.Add(gunCartPresent.ContentBox);
				height += gunCartPresent.ContentBox.Height + 20;
			}
		}
		private void InitalizeLaneBoxes(List<LaneHolder> laneList)
		{
			ObjectListCreate(laneList);
			height = 20;
			foreach (LanePresentBox gunPresent in GunsPresent)
			{
				gunPresent.ContentBox.Location = new Point(panel2.Width + 20, height);
				gunPresent.ContentBox.Size = new Size(ClientSize.Width - panel2.Width - 40, 100);
				Controls.Add(gunPresent.ContentBox);
				height += gunPresent.ContentBox.Height + 20;
			}
		}
		public void InitializeLaneChoices()
		{
			ListDispose();
			ObjectListCreate(gunCart.Lanes);
			height = 20;
			if(GunsPresent.Count == 0)
			{
				InitalizeGunCartBoxes();
			}
			else
			{
				foreach (LaneChoicePresentBox gunPresent in GunsPresent)
				{
					gunPresent.ContentBox.Location = new Point(panel2.Width + 20, height);
					gunPresent.ContentBox.Size = new Size(ClientSize.Width - panel2.Width - 40, 200);
					Controls.Add(gunPresent.ContentBox);
					height += gunPresent.ContentBox.Height + 20;
				}
			}
		}
	}
}
