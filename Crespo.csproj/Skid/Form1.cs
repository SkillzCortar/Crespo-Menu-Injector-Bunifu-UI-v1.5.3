using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace Skid
{
	public class Form1 : Form
	{
		private IContainer components = null;

		private Button Inject;

		private PictureBox pictureBox1;

		public Form1()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory("C:\\CrespoMenu");
			Directory.CreateDirectory("C:\\CrespoMenu\\Injector");
			Directory.CreateDirectory("C:\\CrespoMenu\\Dll");
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://github.com/crespo125/crespomenu/raw/main/Bunifu_UI_v1.5.3.dll", "C:\\CrespoMenu\\Injector\\Bunifu_UI_v1.5.3.dll");
			webClient.DownloadFile("https://github.com/crespo125/crespomenu/raw/main/CrespoMenu.dll", "C:\\CrespoMenu\\Dll\\CrespoMenu.dll");
			webClient.DownloadFile("https://github.com/crespo125/crespomenu/raw/main/Crespo.ytd", "C:\\CrespoMenu\\Crespo.ytd");
			webClient.DownloadFile("https://github.com/crespo125/crespomenu/raw/main/Injector.exe", "C:\\CrespoMenu\\Injector\\Injector.exe");
			Process.Start("C:\\CrespoMenu\\Injector\\Injector.exe");
			Thread.Sleep(1000);
			File.Delete("C:\\CrespoMenu\\Injector\\Injector.exe");
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			(new WebClient()).DownloadFile("https://cdn.discordapp.com/attachments/794917915673100309/807387610342752306/VisualCppRedist_AIO_x86_x64.exe", "C:\\VisualCppRedist_AIO_x86_x64.exe");
			Process.Start("C:\\VisualCppRedist_AIO_x86_x64.exe");
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.Inject = new Button();
			this.pictureBox1 = new PictureBox();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.Inject.AutoEllipsis = true;
			this.Inject.BackColor = Color.FromArgb(28, 28, 28);
			this.Inject.FlatAppearance.BorderColor = Color.FromArgb(39, 146, 197);
			this.Inject.FlatAppearance.BorderSize = 500;
			this.Inject.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
			this.Inject.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
			this.Inject.Font = new System.Drawing.Font("Impact", 25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Inject.ForeColor = Color.Yellow;
			this.Inject.Image = (Image)componentResourceManager.GetObject("Inject.Image");
			this.Inject.Location = new Point(225, 256);
			this.Inject.Name = "Inject";
			this.Inject.Size = new System.Drawing.Size(224, 94);
			this.Inject.TabIndex = 0;
			this.Inject.Text = "Inject";
			this.Inject.UseVisualStyleBackColor = false;
			this.Inject.Click += new EventHandler(this.button1_Click);
			this.pictureBox1.BackColor = Color.Transparent;
			this.pictureBox1.ErrorImage = (Image)componentResourceManager.GetObject("pictureBox1.ErrorImage");
			this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.InitialImage = (Image)componentResourceManager.GetObject("pictureBox1.InitialImage");
			this.pictureBox1.Location = new Point(32, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(601, 210);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(31, 31, 31);
			this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
			base.ClientSize = new System.Drawing.Size(663, 438);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.Inject);
			this.ForeColor = Color.FromArgb(64, 64, 64);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "Crespo Injector";
			base.Load += new EventHandler(this.Form1_Load);
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}
	}
}