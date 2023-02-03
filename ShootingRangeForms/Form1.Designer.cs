using ShootingRangeForms.Objects;
using ShootingRangeForms.Enums;
using ShootingRangeData.ShootingRangeDB;
using Microsoft.Extensions.Configuration;
using ShootingRangeForms.Interfaces;
using ShootingRangeForms.Controls;

namespace ShootingRangeForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.panel2 = new System.Windows.Forms.Panel();
			this.radioButton10 = new System.Windows.Forms.RadioButton();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.BuyCheckout = new System.Windows.Forms.Button();
			this.BackCheckout = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Controls.Add(this.radioButton10);
			this.panel2.Controls.Add(this.radioButton9);
			this.panel2.Controls.Add(this.radioButton8);
			this.panel2.Controls.Add(this.radioButton7);
			this.panel2.Controls.Add(this.radioButton6);
			this.panel2.Controls.Add(this.radioButton5);
			this.panel2.Controls.Add(this.radioButton4);
			this.panel2.Controls.Add(this.radioButton3);
			this.panel2.Controls.Add(this.radioButton2);
			this.panel2.Controls.Add(this.radioButton1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.BuyCheckout);
			this.panel2.Controls.Add(this.BackCheckout);
			this.panel2.Location = new System.Drawing.Point(0, -3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(310, 662);
			this.panel2.TabIndex = 0;
			// 
			// radioButton10
			// 
			this.radioButton10.AutoSize = true;
			this.radioButton10.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton10.Location = new System.Drawing.Point(36, 297);
			this.radioButton10.Name = "radioButton10";
			this.radioButton10.Size = new System.Drawing.Size(121, 19);
			this.radioButton10.TabIndex = 11;
			this.radioButton10.Text = "My Shopping Cart";
			this.radioButton10.UseVisualStyleBackColor = true;
			this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton9.Location = new System.Drawing.Point(36, 272);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(120, 19);
			this.radioButton9.TabIndex = 10;
			this.radioButton9.Text = "Organised Groups";
			this.radioButton9.UseVisualStyleBackColor = true;
			this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton8.Location = new System.Drawing.Point(36, 247);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(74, 19);
			this.radioButton8.TabIndex = 9;
			this.radioButton8.Text = "Packages";
			this.radioButton8.UseVisualStyleBackColor = true;
			this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton7.Location = new System.Drawing.Point(36, 222);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(163, 19);
			this.radioButton7.TabIndex = 8;
			this.radioButton7.Text = "Rent Lane (Own gun only)";
			this.radioButton7.UseVisualStyleBackColor = true;
			this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton6.Location = new System.Drawing.Point(36, 197);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(89, 19);
			this.radioButton6.TabIndex = 7;
			this.radioButton6.Text = "Sniper Rifles";
			this.radioButton6.UseVisualStyleBackColor = true;
			this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton5.Location = new System.Drawing.Point(36, 172);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(101, 19);
			this.radioButton5.TabIndex = 6;
			this.radioButton5.Text = "Machine Guns";
			this.radioButton5.UseVisualStyleBackColor = true;
			this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton4.Location = new System.Drawing.Point(36, 147);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(75, 19);
			this.radioButton4.TabIndex = 5;
			this.radioButton4.Text = "Shotguns";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton3.Location = new System.Drawing.Point(36, 122);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(53, 19);
			this.radioButton3.TabIndex = 4;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Rifles";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton2.Location = new System.Drawing.Point(36, 97);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(75, 19);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Revolvers";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton1.Location = new System.Drawing.Point(36, 72);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(81, 19);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "HandGuns";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Maroon;
			this.label3.Location = new System.Drawing.Point(71, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 37);
			this.label3.TabIndex = 1;
			this.label3.Text = "Categories";
			// 
			// BuyCheckout
			// 
			this.BuyCheckout.Location = new System.Drawing.Point(163, 627);
			this.BuyCheckout.Name = "BuyCheckout";
			this.BuyCheckout.Size = new System.Drawing.Size(96, 23);
			this.BuyCheckout.TabIndex = 2;
			this.BuyCheckout.Text = "Checkout";
			this.BuyCheckout.UseVisualStyleBackColor = true;
			// 
			// BackCheckout
			// 
			this.BackCheckout.Location = new System.Drawing.Point(36, 627);
			this.BackCheckout.Name = "BackCheckout";
			this.BackCheckout.Size = new System.Drawing.Size(96, 23);
			this.BackCheckout.TabIndex = 1;
			this.BackCheckout.Text = "Go Back";
			this.BackCheckout.UseVisualStyleBackColor = true;
			this.BackCheckout.Click += new System.EventHandler(this.BackCheckout_Click);
			// 
			// panel3
			// 
			this.panel3.AutoScroll = true;
			this.panel3.Location = new System.Drawing.Point(310, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(736, 659);
			this.panel3.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(1046, 659);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Name = "Form1";
			this.Text = "Shooting Range";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        #region Variables Definition
        int height = 20;
        private string connString = Program.config.GetSection("ConnectionStrings").GetSection("SqlServer").Get<string>();
        private Cart gunCart = new Cart();
        private List<GunHolder> gunsUsed = new List<GunHolder>();
        private List<IPresentBox> GunsPresent = new List<IPresentBox>();
        private Button ConfigureButton;
        private Button CheckoutButton;
        private Label ConfigureLabel;
        private Label CheckoutLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Button BuyCheckout;
        private Button BackCheckout;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
		private RadioButton radioButton10;
		private DBAccessClass dBAccess = new DBAccessClass();
		#endregion

		private Panel panel2;
		private Panel panel3;
	}
}