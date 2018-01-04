using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using RooBooks.Library;

namespace RooBooks.UI
{
	/// <summary>
	/// Summary description for RooBooks_About.
	/// </summary>
	public class About : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private Settings rbSettings = null;
    private System.Windows.Forms.LinkLabel linkLabel_sd;
    private System.Windows.Forms.LinkLabel linkLabel3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public About()
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(About));
      this.label1 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.linkLabel_sd = new System.Windows.Forms.LinkLabel();
      this.linkLabel3 = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label1.Location = new System.Drawing.Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "RooBooks";
      // 
      // linkLabel1
      // 
      this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
      this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Blue;
      this.linkLabel1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
      this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
      this.linkLabel1.Location = new System.Drawing.Point(8, 41);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(64, 24);
      this.linkLabel1.TabIndex = 1;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "supudo";
      this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // linkLabel2
      // 
      this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Blue;
      this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Blue;
      this.linkLabel2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
      this.linkLabel2.LinkColor = System.Drawing.Color.Blue;
      this.linkLabel2.Location = new System.Drawing.Point(8, 74);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(28, 24);
      this.linkLabel2.TabIndex = 2;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "roo";
      this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Blue;
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      // 
      // linkLabel_sd
      // 
      this.linkLabel_sd.ActiveLinkColor = System.Drawing.Color.Blue;
      this.linkLabel_sd.DisabledLinkColor = System.Drawing.Color.Blue;
      this.linkLabel_sd.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.linkLabel_sd.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
      this.linkLabel_sd.LinkColor = System.Drawing.Color.Blue;
      this.linkLabel_sd.Location = new System.Drawing.Point(8, 107);
      this.linkLabel_sd.Name = "linkLabel_sd";
      this.linkLabel_sd.Size = new System.Drawing.Size(32, 24);
      this.linkLabel_sd.TabIndex = 3;
      this.linkLabel_sd.TabStop = true;
      this.linkLabel_sd.Text = "Geo";
      this.linkLabel_sd.VisitedLinkColor = System.Drawing.Color.Blue;
      this.linkLabel_sd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_sd_LinkClicked);
      // 
      // linkLabel3
      // 
      this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Blue;
      this.linkLabel3.DisabledLinkColor = System.Drawing.Color.Blue;
      this.linkLabel3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
      this.linkLabel3.LinkColor = System.Drawing.Color.Blue;
      this.linkLabel3.Location = new System.Drawing.Point(8, 140);
      this.linkLabel3.Name = "linkLabel3";
      this.linkLabel3.Size = new System.Drawing.Size(60, 24);
      this.linkLabel3.TabIndex = 4;
      this.linkLabel3.TabStop = true;
      this.linkLabel3.Text = "SandDock";
      this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Blue;
      this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
      // 
      // About
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(146, 199);
      this.Controls.Add(this.linkLabel3);
      this.Controls.Add(this.linkLabel_sd);
      this.Controls.Add(this.linkLabel2);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "About";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "About RooBooks";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RooBooks_About_KeyDown);
      this.Load += new System.EventHandler(this.About_Load);
      this.ResumeLayout(false);

    }
    #endregion

    private void About_Load(object sender, System.EventArgs e)
    {
      try 
      {
        this.rbSettings = new Settings();
        LoadSettings();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void LoadSettings() 
    {
      try 
      {
        ///~ font settings
        string fName = this.rbSettings.getRegistrySetting("ApplicationFontName").ToString();
        float fSize = Convert.ToSingle(this.rbSettings.getRegistrySetting("ApplicationFontSize").ToString());
        string tStyle = this.rbSettings.getRegistrySetting("ApplicationFontStyle").ToString();
        FontStyle fStyle = FontStyle.Regular;
        if (tStyle == "bold")
          fStyle = FontStyle.Bold;
        if (tStyle == "italic")
          fStyle = FontStyle.Italic;
        Font f = new Font(fName, fSize, fStyle);
        SetControlsFont(this, f);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
 
    private void SetControlsFont(Control parent, Font font) 
    {
      try 
      {
        foreach (Control c in parent.Controls) 
        {
          if (c.Name == "label1")
            c.Font = new Font(font.FontFamily, font.Size + 6, font.Style);
          else
            c.Font = font;
          if (c.HasChildren)
            SetControlsFont(c, font);
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start("http://bighead.waferbaby.com/");
    }

    private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start("http://www.supudo.net/");
    }

    private void linkLabel_sd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start("mailto:bloodpoint@hotmail.com");
    }

    private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start("http://www.divil.co.uk/");
    }

    private void RooBooks_About_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
    {
      if (e.KeyData == Keys.Escape) 
      {
        this.Dispose();
      }
    }
	}
}
