using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RooBooks.UI
{
	/// <summary>
	/// Summary description for SplashScreen.
	/// </summary>
	public class SplashScreen : System.Windows.Forms.Form
	{
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.LinkLabel linkLabel_supudonet;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SplashScreen()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SplashScreen));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.linkLabel_supudonet = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(518, 323);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // linkLabel_supudonet
      // 
      this.linkLabel_supudonet.ActiveLinkColor = System.Drawing.Color.Blue;
      this.linkLabel_supudonet.BackColor = System.Drawing.Color.White;
      this.linkLabel_supudonet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.linkLabel_supudonet.LinkColor = System.Drawing.Color.Blue;
      this.linkLabel_supudonet.Location = new System.Drawing.Point(10, 296);
      this.linkLabel_supudonet.Name = "linkLabel_supudonet";
      this.linkLabel_supudonet.Size = new System.Drawing.Size(106, 16);
      this.linkLabel_supudonet.TabIndex = 1;
      this.linkLabel_supudonet.TabStop = true;
      this.linkLabel_supudonet.Text = "www.supudo.net";
      this.linkLabel_supudonet.VisitedLinkColor = System.Drawing.Color.Blue;
      this.linkLabel_supudonet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_supudonet_LinkClicked);
      // 
      // SplashScreen
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(518, 323);
      this.Controls.Add(this.linkLabel_supudonet);
      this.Controls.Add(this.pictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SplashScreen";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Splash";
      this.TopMost = true;
      this.ResumeLayout(false);

    }
		#endregion

    private void linkLabel_supudonet_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start("http://www.supudo.net/");
    }
	}
}
