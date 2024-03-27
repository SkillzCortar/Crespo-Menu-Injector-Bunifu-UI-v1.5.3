using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Resources;
using System.Windows.Forms;

namespace Skid
{
	public class Form2 : Form
	{
		private IContainer components = null;

		private TextBox textBox1;

		private Button Inject;

		private Button button1;

		private PictureBox pictureBox1;

		private Button button2;

		private Button button3;

		private Button button4;

		private Button button5;

		public Form2()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://link-to.net/146049/CrespoKey");
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://crespomods.xyz/");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/GM4EXmW5Jn");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/c/CrespoModss");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Process.Start("https://CrespoMods.xyz/changelog.html");
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form2_Load(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
			this.textBox1 = new TextBox();
			this.Inject = new Button();
			this.button1 = new Button();
			this.pictureBox1 = new PictureBox();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button5 = new Button();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.textBox1.BackColor = Color.Black;
			this.textBox1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12f, FontStyle.Bold, GraphicsUnit.Point, 128);
			this.textBox1.ForeColor = Color.FromArgb(255, 255, 192);
			this.textBox1.Location = new Point(110, 95);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(292, 36);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Key License";
			this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
			this.Inject.AutoEllipsis = true;
			this.Inject.BackColor = Color.FromArgb(28, 28, 28);
			this.Inject.FlatAppearance.BorderColor = Color.FromArgb(39, 146, 197);
			this.Inject.FlatAppearance.BorderSize = 500;
			this.Inject.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
			this.Inject.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
			this.Inject.Font = new System.Drawing.Font("Impact", 25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Inject.ForeColor = Color.Yellow;
			this.Inject.Image = (Image)componentResourceManager.GetObject("Inject.Image");
			this.Inject.Location = new Point(110, 137);
			this.Inject.Name = "Inject";
			this.Inject.Size = new System.Drawing.Size(143, 50);
			this.Inject.TabIndex = 1;
			this.Inject.Text = "Login";
			this.Inject.UseVisualStyleBackColor = false;
			this.Inject.Click += new EventHandler(this.Inject_Click);
			this.button1.AutoEllipsis = true;
			this.button1.BackColor = Color.FromArgb(28, 28, 28);
			this.button1.FlatAppearance.BorderColor = Color.FromArgb(39, 146, 197);
			this.button1.FlatAppearance.BorderSize = 500;
			this.button1.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
			this.button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
			this.button1.Font = new System.Drawing.Font("Impact", 24.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.Yellow;
			this.button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
			this.button1.Location = new Point(273, 137);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 50);
			this.button1.TabIndex = 2;
			this.button1.Text = "Get Key";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(510, 97);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.button2.AutoEllipsis = true;
			this.button2.BackColor = Color.Transparent;
			this.button2.Cursor = Cursors.Default;
			this.button2.FlatAppearance.BorderColor = Color.FromArgb(39, 146, 197);
			this.button2.FlatAppearance.BorderSize = 500;
			this.button2.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
			this.button2.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
			this.button2.FlatStyle = FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Impact", 24.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.Transparent;
			this.button2.Image = (Image)componentResourceManager.GetObject("button2.Image");
			this.button2.Location = new Point(121, 190);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(51, 46);
			this.button2.TabIndex = 11;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button2_Click_1);
			this.button3.AutoEllipsis = true;
			this.button3.BackColor = Color.Transparent;
			this.button3.Cursor = Cursors.Default;
			this.button3.FlatAppearance.BorderColor = Color.FromArgb(39, 146, 197);
			this.button3.FlatAppearance.BorderSize = 500;
			this.button3.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
			this.button3.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
			this.button3.FlatStyle = FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Impact", 24.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.Transparent;
			this.button3.Image = (Image)componentResourceManager.GetObject("button3.Image");
			this.button3.Location = new Point(201, 187);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(52, 53);
			this.button3.TabIndex = 12;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button4.AutoEllipsis = true;
			this.button4.BackColor = Color.Transparent;
			this.button4.Cursor = Cursors.Default;
			this.button4.FlatAppearance.BorderColor = Color.FromArgb(39, 146, 197);
			this.button4.FlatAppearance.BorderSize = 500;
			this.button4.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
			this.button4.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
			this.button4.FlatStyle = FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Impact", 24.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.Transparent;
			this.button4.Image = (Image)componentResourceManager.GetObject("button4.Image");
			this.button4.Location = new Point(273, 187);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(52, 53);
			this.button4.TabIndex = 13;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.button5.AutoEllipsis = true;
			this.button5.BackColor = Color.Transparent;
			this.button5.Cursor = Cursors.Default;
			this.button5.FlatAppearance.BorderColor = Color.FromArgb(39, 146, 197);
			this.button5.FlatAppearance.BorderSize = 500;
			this.button5.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
			this.button5.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
			this.button5.FlatStyle = FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("Impact", 24.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.Transparent;
			this.button5.Image = (Image)componentResourceManager.GetObject("button5.Image");
			this.button5.Location = new Point(350, 187);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(52, 53);
			this.button5.TabIndex = 14;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new EventHandler(this.button5_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(39, 39, 39);
			this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
			base.ClientSize = new System.Drawing.Size(514, 265);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.Inject);
			base.Controls.Add(this.textBox1);
			this.ForeColor = SystemColors.ControlText;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			this.Text = "Crespo Launcher";
			base.Load += new EventHandler(this.Form2_Load);
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Inject_Click(object sender, EventArgs e)
		{
			string str = (new WebClient()).DownloadString("https://pastebin.com/raw/bM7w8y0n");
			string[] strArrays = str.Split(Array.Empty<char>());
			if (this.textBox1.Text == strArrays[0])
			{
				MessageBox.Show("Correct!", "Crespo Notification");
				(new Form1()).Show();
				base.Hide();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}