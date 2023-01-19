using Lotto.Objects;

namespace WinFormsApp1
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Buy ticket";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(119, 13);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Seek Answers";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(522, 13);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Indigo;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Location = new System.Drawing.Point(0, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(635, 47);
			this.panel1.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Lotto.Properties.Resources.stock_photo_popular_tourist_attraction_trolltunga_sunny;
			this.pictureBox1.Location = new System.Drawing.Point(0, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(635, 419);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(609, 456);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		#region Inits
		private void InitBuyTicket()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox49 = new System.Windows.Forms.CheckBox();
			this.checkBox48 = new System.Windows.Forms.CheckBox();
			this.checkBox47 = new System.Windows.Forms.CheckBox();
			this.checkBox46 = new System.Windows.Forms.CheckBox();
			this.checkBox45 = new System.Windows.Forms.CheckBox();
			this.checkBox44 = new System.Windows.Forms.CheckBox();
			this.checkBox43 = new System.Windows.Forms.CheckBox();
			this.checkBox42 = new System.Windows.Forms.CheckBox();
			this.checkBox41 = new System.Windows.Forms.CheckBox();
			this.checkBox40 = new System.Windows.Forms.CheckBox();
			this.checkBox39 = new System.Windows.Forms.CheckBox();
			this.checkBox38 = new System.Windows.Forms.CheckBox();
			this.checkBox37 = new System.Windows.Forms.CheckBox();
			this.checkBox36 = new System.Windows.Forms.CheckBox();
			this.checkBox35 = new System.Windows.Forms.CheckBox();
			this.checkBox34 = new System.Windows.Forms.CheckBox();
			this.checkBox33 = new System.Windows.Forms.CheckBox();
			this.checkBox32 = new System.Windows.Forms.CheckBox();
			this.checkBox31 = new System.Windows.Forms.CheckBox();
			this.checkBox30 = new System.Windows.Forms.CheckBox();
			this.checkBox29 = new System.Windows.Forms.CheckBox();
			this.checkBox28 = new System.Windows.Forms.CheckBox();
			this.checkBox27 = new System.Windows.Forms.CheckBox();
			this.checkBox26 = new System.Windows.Forms.CheckBox();
			this.checkBox25 = new System.Windows.Forms.CheckBox();
			this.checkBox24 = new System.Windows.Forms.CheckBox();
			this.checkBox23 = new System.Windows.Forms.CheckBox();
			this.checkBox22 = new System.Windows.Forms.CheckBox();
			this.checkBox21 = new System.Windows.Forms.CheckBox();
			this.checkBox20 = new System.Windows.Forms.CheckBox();
			this.checkBox19 = new System.Windows.Forms.CheckBox();
			this.checkBox18 = new System.Windows.Forms.CheckBox();
			this.checkBox17 = new System.Windows.Forms.CheckBox();
			this.checkBox16 = new System.Windows.Forms.CheckBox();
			this.checkBox15 = new System.Windows.Forms.CheckBox();
			this.checkBox14 = new System.Windows.Forms.CheckBox();
			this.checkBox13 = new System.Windows.Forms.CheckBox();
			this.checkBox12 = new System.Windows.Forms.CheckBox();
			this.checkBox11 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();

			this.panel2.BackColor = System.Drawing.Color.Navy;
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.checkBox49);
			this.panel2.Controls.Add(this.checkBox48);
			this.panel2.Controls.Add(this.checkBox47);
			this.panel2.Controls.Add(this.checkBox46);
			this.panel2.Controls.Add(this.checkBox45);
			this.panel2.Controls.Add(this.checkBox44);
			this.panel2.Controls.Add(this.checkBox43);
			this.panel2.Controls.Add(this.checkBox42);
			this.panel2.Controls.Add(this.checkBox41);
			this.panel2.Controls.Add(this.checkBox40);
			this.panel2.Controls.Add(this.checkBox39);
			this.panel2.Controls.Add(this.checkBox38);
			this.panel2.Controls.Add(this.checkBox37);
			this.panel2.Controls.Add(this.checkBox36);
			this.panel2.Controls.Add(this.checkBox35);
			this.panel2.Controls.Add(this.checkBox34);
			this.panel2.Controls.Add(this.checkBox33);
			this.panel2.Controls.Add(this.checkBox32);
			this.panel2.Controls.Add(this.checkBox31);
			this.panel2.Controls.Add(this.checkBox30);
			this.panel2.Controls.Add(this.checkBox29);
			this.panel2.Controls.Add(this.checkBox28);
			this.panel2.Controls.Add(this.checkBox27);
			this.panel2.Controls.Add(this.checkBox26);
			this.panel2.Controls.Add(this.checkBox25);
			this.panel2.Controls.Add(this.checkBox24);
			this.panel2.Controls.Add(this.checkBox23);
			this.panel2.Controls.Add(this.checkBox22);
			this.panel2.Controls.Add(this.checkBox21);
			this.panel2.Controls.Add(this.checkBox20);
			this.panel2.Controls.Add(this.checkBox19);
			this.panel2.Controls.Add(this.checkBox18);
			this.panel2.Controls.Add(this.checkBox17);
			this.panel2.Controls.Add(this.checkBox16);
			this.panel2.Controls.Add(this.checkBox15);
			this.panel2.Controls.Add(this.checkBox14);
			this.panel2.Controls.Add(this.checkBox13);
			this.panel2.Controls.Add(this.checkBox12);
			this.panel2.Controls.Add(this.checkBox11);
			this.panel2.Controls.Add(this.checkBox10);
			this.panel2.Controls.Add(this.checkBox9);
			this.panel2.Controls.Add(this.checkBox8);
			this.panel2.Controls.Add(this.checkBox7);
			this.panel2.Controls.Add(this.checkBox6);
			this.panel2.Controls.Add(this.checkBox5);
			this.panel2.Controls.Add(this.checkBox4);
			this.panel2.Controls.Add(this.checkBox3);
			this.panel2.Controls.Add(this.checkBox2);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Location = new System.Drawing.Point(175, 15);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(255, 392);
			this.panel2.TabIndex = 5;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(168, 73);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 52;
			this.button4.Text = "buy ticket";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(16, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 15);
			this.label1.TabIndex = 51;
			this.label1.Text = "Your username:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(152, 102);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 23);
			this.textBox2.TabIndex = 50;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(54, 145);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox1.Size = new System.Drawing.Size(152, 23);
			this.textBox1.TabIndex = 49;
			this.textBox1.Text = "Your Numbers";
			// 
			// checkBox49
			// 
			this.checkBox49.AutoSize = true;
			this.checkBox49.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox49.Location = new System.Drawing.Point(105, 370);
			this.checkBox49.Name = "checkBox49";
			this.checkBox49.Size = new System.Drawing.Size(38, 19);
			this.checkBox49.TabIndex = 48;
			this.checkBox49.Text = "49";
			this.checkBox49.UseVisualStyleBackColor = true;
			this.checkBox49.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox48
			// 
			this.checkBox48.AutoSize = true;
			this.checkBox48.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox48.Location = new System.Drawing.Point(206, 349);
			this.checkBox48.Name = "checkBox48";
			this.checkBox48.Size = new System.Drawing.Size(38, 19);
			this.checkBox48.TabIndex = 47;
			this.checkBox48.Text = "48";
			this.checkBox48.UseVisualStyleBackColor = true;
			this.checkBox48.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox47
			// 
			this.checkBox47.AutoSize = true;
			this.checkBox47.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox47.Location = new System.Drawing.Point(168, 349);
			this.checkBox47.Name = "checkBox47";
			this.checkBox47.Size = new System.Drawing.Size(38, 19);
			this.checkBox47.TabIndex = 46;
			this.checkBox47.Text = "47";
			this.checkBox47.UseVisualStyleBackColor = true;
			this.checkBox47.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox46
			// 
			this.checkBox46.AutoSize = true;
			this.checkBox46.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox46.Location = new System.Drawing.Point(130, 349);
			this.checkBox46.Name = "checkBox46";
			this.checkBox46.Size = new System.Drawing.Size(38, 19);
			this.checkBox46.TabIndex = 45;
			this.checkBox46.Text = "46";
			this.checkBox46.UseVisualStyleBackColor = true;
			this.checkBox46.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox45
			// 
			this.checkBox45.AutoSize = true;
			this.checkBox45.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox45.Location = new System.Drawing.Point(92, 349);
			this.checkBox45.Name = "checkBox45";
			this.checkBox45.Size = new System.Drawing.Size(38, 19);
			this.checkBox45.TabIndex = 44;
			this.checkBox45.Text = "45";
			this.checkBox45.UseVisualStyleBackColor = true;
			this.checkBox45.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox44
			// 
			this.checkBox44.AutoSize = true;
			this.checkBox44.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox44.Location = new System.Drawing.Point(54, 349);
			this.checkBox44.Name = "checkBox44";
			this.checkBox44.Size = new System.Drawing.Size(38, 19);
			this.checkBox44.TabIndex = 43;
			this.checkBox44.Text = "44";
			this.checkBox44.UseVisualStyleBackColor = true;
			this.checkBox44.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox43
			// 
			this.checkBox43.AutoSize = true;
			this.checkBox43.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox43.Location = new System.Drawing.Point(16, 349);
			this.checkBox43.Name = "checkBox43";
			this.checkBox43.Size = new System.Drawing.Size(38, 19);
			this.checkBox43.TabIndex = 42;
			this.checkBox43.Text = "43";
			this.checkBox43.UseVisualStyleBackColor = true;
			this.checkBox43.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox42
			// 
			this.checkBox42.AutoSize = true;
			this.checkBox42.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox42.Location = new System.Drawing.Point(206, 324);
			this.checkBox42.Name = "checkBox42";
			this.checkBox42.Size = new System.Drawing.Size(38, 19);
			this.checkBox42.TabIndex = 41;
			this.checkBox42.Text = "42";
			this.checkBox42.UseVisualStyleBackColor = true;
			this.checkBox42.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox41
			// 
			this.checkBox41.AutoSize = true;
			this.checkBox41.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox41.Location = new System.Drawing.Point(168, 324);
			this.checkBox41.Name = "checkBox41";
			this.checkBox41.Size = new System.Drawing.Size(38, 19);
			this.checkBox41.TabIndex = 40;
			this.checkBox41.Text = "41";
			this.checkBox41.UseVisualStyleBackColor = true;
			this.checkBox41.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox40
			// 
			this.checkBox40.AutoSize = true;
			this.checkBox40.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox40.Location = new System.Drawing.Point(130, 324);
			this.checkBox40.Name = "checkBox40";
			this.checkBox40.Size = new System.Drawing.Size(38, 19);
			this.checkBox40.TabIndex = 39;
			this.checkBox40.Text = "40";
			this.checkBox40.UseVisualStyleBackColor = true;
			this.checkBox40.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox39
			// 
			this.checkBox39.AutoSize = true;
			this.checkBox39.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox39.Location = new System.Drawing.Point(92, 324);
			this.checkBox39.Name = "checkBox39";
			this.checkBox39.Size = new System.Drawing.Size(38, 19);
			this.checkBox39.TabIndex = 38;
			this.checkBox39.Text = "39";
			this.checkBox39.UseVisualStyleBackColor = true;
			this.checkBox39.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox38
			// 
			this.checkBox38.AutoSize = true;
			this.checkBox38.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox38.Location = new System.Drawing.Point(54, 324);
			this.checkBox38.Name = "checkBox38";
			this.checkBox38.Size = new System.Drawing.Size(38, 19);
			this.checkBox38.TabIndex = 37;
			this.checkBox38.Text = "38";
			this.checkBox38.UseVisualStyleBackColor = true;
			this.checkBox38.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox37
			// 
			this.checkBox37.AutoSize = true;
			this.checkBox37.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox37.Location = new System.Drawing.Point(16, 324);
			this.checkBox37.Name = "checkBox37";
			this.checkBox37.Size = new System.Drawing.Size(38, 19);
			this.checkBox37.TabIndex = 36;
			this.checkBox37.Text = "37";
			this.checkBox37.UseVisualStyleBackColor = true;
			this.checkBox37.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox36
			// 
			this.checkBox36.AutoSize = true;
			this.checkBox36.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox36.Location = new System.Drawing.Point(206, 299);
			this.checkBox36.Name = "checkBox36";
			this.checkBox36.Size = new System.Drawing.Size(38, 19);
			this.checkBox36.TabIndex = 35;
			this.checkBox36.Text = "36";
			this.checkBox36.UseVisualStyleBackColor = true;
			this.checkBox36.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox35
			// 
			this.checkBox35.AutoSize = true;
			this.checkBox35.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox35.Location = new System.Drawing.Point(168, 299);
			this.checkBox35.Name = "checkBox35";
			this.checkBox35.Size = new System.Drawing.Size(38, 19);
			this.checkBox35.TabIndex = 34;
			this.checkBox35.Text = "35";
			this.checkBox35.UseVisualStyleBackColor = true;
			this.checkBox35.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox34
			// 
			this.checkBox34.AutoSize = true;
			this.checkBox34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox34.Location = new System.Drawing.Point(130, 299);
			this.checkBox34.Name = "checkBox34";
			this.checkBox34.Size = new System.Drawing.Size(38, 19);
			this.checkBox34.TabIndex = 33;
			this.checkBox34.Text = "34";
			this.checkBox34.UseVisualStyleBackColor = true;
			this.checkBox34.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox33
			// 
			this.checkBox33.AutoSize = true;
			this.checkBox33.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox33.Location = new System.Drawing.Point(92, 299);
			this.checkBox33.Name = "checkBox33";
			this.checkBox33.Size = new System.Drawing.Size(38, 19);
			this.checkBox33.TabIndex = 32;
			this.checkBox33.Text = "33";
			this.checkBox33.UseVisualStyleBackColor = true;
			this.checkBox33.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox32
			// 
			this.checkBox32.AutoSize = true;
			this.checkBox32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox32.Location = new System.Drawing.Point(54, 299);
			this.checkBox32.Name = "checkBox32";
			this.checkBox32.Size = new System.Drawing.Size(38, 19);
			this.checkBox32.TabIndex = 31;
			this.checkBox32.Text = "32";
			this.checkBox32.UseVisualStyleBackColor = true;
			this.checkBox32.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox31
			// 
			this.checkBox31.AutoSize = true;
			this.checkBox31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox31.Location = new System.Drawing.Point(16, 299);
			this.checkBox31.Name = "checkBox31";
			this.checkBox31.Size = new System.Drawing.Size(38, 19);
			this.checkBox31.TabIndex = 30;
			this.checkBox31.Text = "31";
			this.checkBox31.UseVisualStyleBackColor = true;
			this.checkBox31.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox30
			// 
			this.checkBox30.AutoSize = true;
			this.checkBox30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox30.Location = new System.Drawing.Point(206, 274);
			this.checkBox30.Name = "checkBox30";
			this.checkBox30.Size = new System.Drawing.Size(38, 19);
			this.checkBox30.TabIndex = 29;
			this.checkBox30.Text = "30";
			this.checkBox30.UseVisualStyleBackColor = true;
			this.checkBox30.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox29
			// 
			this.checkBox29.AutoSize = true;
			this.checkBox29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox29.Location = new System.Drawing.Point(168, 274);
			this.checkBox29.Name = "checkBox29";
			this.checkBox29.Size = new System.Drawing.Size(38, 19);
			this.checkBox29.TabIndex = 28;
			this.checkBox29.Text = "29";
			this.checkBox29.UseVisualStyleBackColor = true;
			this.checkBox29.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox28
			// 
			this.checkBox28.AutoSize = true;
			this.checkBox28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox28.Location = new System.Drawing.Point(130, 274);
			this.checkBox28.Name = "checkBox28";
			this.checkBox28.Size = new System.Drawing.Size(38, 19);
			this.checkBox28.TabIndex = 27;
			this.checkBox28.Text = "28";
			this.checkBox28.UseVisualStyleBackColor = true;
			this.checkBox28.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox27
			// 
			this.checkBox27.AutoSize = true;
			this.checkBox27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox27.Location = new System.Drawing.Point(92, 274);
			this.checkBox27.Name = "checkBox27";
			this.checkBox27.Size = new System.Drawing.Size(38, 19);
			this.checkBox27.TabIndex = 26;
			this.checkBox27.Text = "27";
			this.checkBox27.UseVisualStyleBackColor = true;
			this.checkBox27.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox26
			// 
			this.checkBox26.AutoSize = true;
			this.checkBox26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox26.Location = new System.Drawing.Point(54, 274);
			this.checkBox26.Name = "checkBox26";
			this.checkBox26.Size = new System.Drawing.Size(38, 19);
			this.checkBox26.TabIndex = 25;
			this.checkBox26.Text = "26";
			this.checkBox26.UseVisualStyleBackColor = true;
			this.checkBox26.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox25
			// 
			this.checkBox25.AutoSize = true;
			this.checkBox25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox25.Location = new System.Drawing.Point(16, 274);
			this.checkBox25.Name = "checkBox25";
			this.checkBox25.Size = new System.Drawing.Size(38, 19);
			this.checkBox25.TabIndex = 24;
			this.checkBox25.Text = "25";
			this.checkBox25.UseVisualStyleBackColor = true;
			this.checkBox25.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox24
			// 
			this.checkBox24.AutoSize = true;
			this.checkBox24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox24.Location = new System.Drawing.Point(206, 249);
			this.checkBox24.Name = "checkBox24";
			this.checkBox24.Size = new System.Drawing.Size(38, 19);
			this.checkBox24.TabIndex = 23;
			this.checkBox24.Text = "24";
			this.checkBox24.UseVisualStyleBackColor = true;
			this.checkBox24.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox23
			// 
			this.checkBox23.AutoSize = true;
			this.checkBox23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox23.Location = new System.Drawing.Point(168, 249);
			this.checkBox23.Name = "checkBox23";
			this.checkBox23.Size = new System.Drawing.Size(38, 19);
			this.checkBox23.TabIndex = 22;
			this.checkBox23.Text = "23";
			this.checkBox23.UseVisualStyleBackColor = true;
			this.checkBox23.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox22
			// 
			this.checkBox22.AutoSize = true;
			this.checkBox22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox22.Location = new System.Drawing.Point(130, 249);
			this.checkBox22.Name = "checkBox22";
			this.checkBox22.Size = new System.Drawing.Size(38, 19);
			this.checkBox22.TabIndex = 21;
			this.checkBox22.Text = "22";
			this.checkBox22.UseVisualStyleBackColor = true;
			this.checkBox22.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox21
			// 
			this.checkBox21.AutoSize = true;
			this.checkBox21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox21.Location = new System.Drawing.Point(92, 249);
			this.checkBox21.Name = "checkBox21";
			this.checkBox21.Size = new System.Drawing.Size(38, 19);
			this.checkBox21.TabIndex = 20;
			this.checkBox21.Text = "21";
			this.checkBox21.UseVisualStyleBackColor = true;
			this.checkBox21.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox20
			// 
			this.checkBox20.AutoSize = true;
			this.checkBox20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox20.Location = new System.Drawing.Point(54, 249);
			this.checkBox20.Name = "checkBox20";
			this.checkBox20.Size = new System.Drawing.Size(38, 19);
			this.checkBox20.TabIndex = 19;
			this.checkBox20.Text = "20";
			this.checkBox20.UseVisualStyleBackColor = true;
			this.checkBox20.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox19
			// 
			this.checkBox19.AutoSize = true;
			this.checkBox19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox19.Location = new System.Drawing.Point(16, 249);
			this.checkBox19.Name = "checkBox19";
			this.checkBox19.Size = new System.Drawing.Size(38, 19);
			this.checkBox19.TabIndex = 18;
			this.checkBox19.Text = "19";
			this.checkBox19.UseVisualStyleBackColor = true;
			this.checkBox19.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox18
			// 
			this.checkBox18.AutoSize = true;
			this.checkBox18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox18.Location = new System.Drawing.Point(206, 224);
			this.checkBox18.Name = "checkBox18";
			this.checkBox18.Size = new System.Drawing.Size(38, 19);
			this.checkBox18.TabIndex = 17;
			this.checkBox18.Text = "18";
			this.checkBox18.UseVisualStyleBackColor = true;
			this.checkBox18.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox17
			// 
			this.checkBox17.AutoSize = true;
			this.checkBox17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox17.Location = new System.Drawing.Point(168, 224);
			this.checkBox17.Name = "checkBox17";
			this.checkBox17.Size = new System.Drawing.Size(38, 19);
			this.checkBox17.TabIndex = 16;
			this.checkBox17.Text = "17";
			this.checkBox17.UseVisualStyleBackColor = true;
			this.checkBox17.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox16
			// 
			this.checkBox16.AutoSize = true;
			this.checkBox16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox16.Location = new System.Drawing.Point(130, 224);
			this.checkBox16.Name = "checkBox16";
			this.checkBox16.Size = new System.Drawing.Size(38, 19);
			this.checkBox16.TabIndex = 15;
			this.checkBox16.Text = "16";
			this.checkBox16.UseVisualStyleBackColor = true;
			this.checkBox16.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox15
			// 
			this.checkBox15.AutoSize = true;
			this.checkBox15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox15.Location = new System.Drawing.Point(92, 224);
			this.checkBox15.Name = "checkBox15";
			this.checkBox15.Size = new System.Drawing.Size(38, 19);
			this.checkBox15.TabIndex = 14;
			this.checkBox15.Text = "15";
			this.checkBox15.UseVisualStyleBackColor = true;
			this.checkBox15.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox14
			// 
			this.checkBox14.AutoSize = true;
			this.checkBox14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox14.Location = new System.Drawing.Point(54, 224);
			this.checkBox14.Name = "checkBox14";
			this.checkBox14.Size = new System.Drawing.Size(38, 19);
			this.checkBox14.TabIndex = 13;
			this.checkBox14.Text = "14";
			this.checkBox14.UseVisualStyleBackColor = true;
			this.checkBox14.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox13
			// 
			this.checkBox13.AutoSize = true;
			this.checkBox13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox13.Location = new System.Drawing.Point(16, 224);
			this.checkBox13.Name = "checkBox13";
			this.checkBox13.Size = new System.Drawing.Size(38, 19);
			this.checkBox13.TabIndex = 12;
			this.checkBox13.Text = "13";
			this.checkBox13.UseVisualStyleBackColor = true;
			this.checkBox13.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox12
			// 
			this.checkBox12.AutoSize = true;
			this.checkBox12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox12.Location = new System.Drawing.Point(206, 199);
			this.checkBox12.Name = "checkBox12";
			this.checkBox12.Size = new System.Drawing.Size(38, 19);
			this.checkBox12.TabIndex = 11;
			this.checkBox12.Text = "12";
			this.checkBox12.UseVisualStyleBackColor = true;
			this.checkBox12.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox11
			// 
			this.checkBox11.AutoSize = true;
			this.checkBox11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox11.Location = new System.Drawing.Point(168, 199);
			this.checkBox11.Name = "checkBox11";
			this.checkBox11.Size = new System.Drawing.Size(38, 19);
			this.checkBox11.TabIndex = 10;
			this.checkBox11.Text = "11";
			this.checkBox11.UseVisualStyleBackColor = true;
			this.checkBox11.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox10
			// 
			this.checkBox10.AutoSize = true;
			this.checkBox10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox10.Location = new System.Drawing.Point(130, 199);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(38, 19);
			this.checkBox10.TabIndex = 9;
			this.checkBox10.Text = "10";
			this.checkBox10.UseVisualStyleBackColor = true;
			this.checkBox10.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox9
			// 
			this.checkBox9.AutoSize = true;
			this.checkBox9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox9.Location = new System.Drawing.Point(92, 199);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(32, 19);
			this.checkBox9.TabIndex = 8;
			this.checkBox9.Text = "9";
			this.checkBox9.UseVisualStyleBackColor = true;
			this.checkBox9.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox8.Location = new System.Drawing.Point(54, 199);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(32, 19);
			this.checkBox8.TabIndex = 7;
			this.checkBox8.Text = "8";
			this.checkBox8.UseVisualStyleBackColor = true;
			this.checkBox8.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox7.Location = new System.Drawing.Point(16, 199);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(32, 19);
			this.checkBox7.TabIndex = 6;
			this.checkBox7.Text = "7";
			this.checkBox7.UseVisualStyleBackColor = true;
			this.checkBox7.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox6.Location = new System.Drawing.Point(206, 174);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(32, 19);
			this.checkBox6.TabIndex = 5;
			this.checkBox6.Text = "6";
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox5.Location = new System.Drawing.Point(168, 174);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(32, 19);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "5";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox4.Location = new System.Drawing.Point(130, 174);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(32, 19);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "4";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox3.Location = new System.Drawing.Point(92, 174);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(32, 19);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "3";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox2.Location = new System.Drawing.Point(54, 174);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(32, 19);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox1.Location = new System.Drawing.Point(16, 174);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(32, 19);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.NumbersCheckedChanged);
			this.pictureBox1.Controls.Add(this.panel2);

			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
		}
		private void InitAnswerSeeker()
		{
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Navy;
			this.panel3.Controls.Add(this.textBox3);
			this.panel3.Location = new System.Drawing.Point(12, 52);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 100);
			this.panel3.TabIndex = 5;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Navy;
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.textBox4);
			this.panel4.Location = new System.Drawing.Point(360, 52);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 376);
			this.panel4.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(16, 16);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(168, 70);
			this.textBox3.TabIndex = 0;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(13, 35);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(172, 328);
			this.textBox4.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(63, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Winners";
			this.pictureBox1.Controls.Add(this.panel4);
			this.pictureBox1.Controls.Add(this.panel3);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
		}
		#endregion
		#region Disposes
		private void DisposeBuyTicket()
		{
			checkBox1.Dispose();
			checkBox2.Dispose();
			checkBox3.Dispose();
			checkBox4.Dispose();
			checkBox5.Dispose();
			checkBox6.Dispose();
			checkBox7.Dispose();
			checkBox8.Dispose();
			checkBox9.Dispose();
			checkBox10.Dispose();
			checkBox11.Dispose();
			checkBox12.Dispose();
			checkBox13.Dispose();
			checkBox14.Dispose();
			checkBox15.Dispose();
			checkBox16.Dispose();
			checkBox17.Dispose();
			checkBox18.Dispose();
			checkBox19.Dispose();
			checkBox20.Dispose();
			checkBox21.Dispose();
			checkBox22.Dispose();
			checkBox23.Dispose();
			checkBox24.Dispose();
			checkBox25.Dispose();
			checkBox26.Dispose();
			checkBox27.Dispose();
			checkBox28.Dispose();
			checkBox29.Dispose();
			checkBox30.Dispose();
			checkBox31.Dispose();
			checkBox32.Dispose();
			checkBox33.Dispose();
			checkBox34.Dispose();
			checkBox35.Dispose();
			checkBox36.Dispose();
			checkBox37.Dispose();
			checkBox38.Dispose();
			checkBox39.Dispose();
			checkBox40.Dispose();
			checkBox41.Dispose();
			checkBox42.Dispose();
			checkBox43.Dispose();
			checkBox44.Dispose();
			checkBox45.Dispose();
			checkBox46.Dispose();
			checkBox47.Dispose();
			checkBox48.Dispose();
			checkBox49.Dispose();
			textBox1.Dispose();
			textBox2.Dispose();
			label1.Dispose();
			button4.Dispose();
			panel2.Dispose();
		}
		private void DisposeAnswerSeeker()
		{
            this.panel3.Dispose();
            this.panel4.Dispose();
            this.textBox3.Dispose();
            this.textBox4.Dispose();
            this.label2.Dispose();
        }
		#endregion
		private Button button1;
		private Button button2;
		private Button button3;
		private Panel panel1;
		private PictureBox pictureBox1;
		private Panel panel2;
		private Button button4;
		private Label label1;
		private TextBox textBox2;
		private TextBox textBox1;
		private CheckBox checkBox49;
		private CheckBox checkBox48;
		private CheckBox checkBox47;
		private CheckBox checkBox46;
		private CheckBox checkBox45;
		private CheckBox checkBox44;
		private CheckBox checkBox43;
		private CheckBox checkBox42;
		private CheckBox checkBox41;
		private CheckBox checkBox40;
		private CheckBox checkBox39;
		private CheckBox checkBox38;
		private CheckBox checkBox37;
		private CheckBox checkBox36;
		private CheckBox checkBox35;
		private CheckBox checkBox34;
		private CheckBox checkBox33;
		private CheckBox checkBox32;
		private CheckBox checkBox31;
		private CheckBox checkBox30;
		private CheckBox checkBox29;
		private CheckBox checkBox28;
		private CheckBox checkBox27;
		private CheckBox checkBox26;
		private CheckBox checkBox25;
		private CheckBox checkBox24;
		private CheckBox checkBox23;
		private CheckBox checkBox22;
		private CheckBox checkBox21;
		private CheckBox checkBox20;
		private CheckBox checkBox19;
		private CheckBox checkBox18;
		private CheckBox checkBox17;
		private CheckBox checkBox16;
		private CheckBox checkBox15;
		private CheckBox checkBox14;
		private CheckBox checkBox13;
		private CheckBox checkBox12;
		private CheckBox checkBox11;
		private CheckBox checkBox10;
		private CheckBox checkBox9;
		private CheckBox checkBox8;
		private CheckBox checkBox7;
		private CheckBox checkBox6;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private List<Ticket> ListOfTickets = new List<Ticket>();
		private List<int> TempNumbers = new List<int>();
		private Panel panel3;
		private TextBox textBox3;
		private Panel panel4;
		private Label label2;
		private TextBox textBox4;
	}
}