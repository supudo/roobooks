using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using RooBooks.Library;

namespace RooBooks.UI
{
	/// <summary>
	/// Summary description for RooBooks_Preferences.
	/// </summary>
	public class RooBooks_Preferences : System.Windows.Forms.Form
	{

    #region Windows.Forms designer declarations
    private System.Windows.Forms.CheckBox checkBox_tbText_default;
    private System.Windows.Forms.CheckBox checkBox_ResizeBeyond;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label_Appearance;
    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.Label label_tbText;
    private System.Windows.Forms.ComboBox comboBox_tbText;
    private System.Windows.Forms.Panel panel_appearance;
    private System.Windows.Forms.Button button_change_font;
    private System.Windows.Forms.FontDialog fontDialog;
    private System.Windows.Forms.Label preview_font;
    private System.Windows.Forms.CheckBox font_checkbox;
    private System.Windows.Forms.Label label_font;
    private System.Windows.Forms.Panel panel_main;
    private System.Windows.Forms.Label label_description;
    private System.Windows.Forms.Button button_apply;
    private System.Windows.Forms.Button button_cancel;
    private System.Windows.Forms.Button button_ok;
    private System.Windows.Forms.GroupBox group_box;
    private System.Windows.Forms.Panel panel_general;
    private System.Windows.Forms.CheckBox beh_checkbox_checkforupdates;
    private System.Windows.Forms.CheckBox beh_checkbox_minimizetotray;
    private System.Windows.Forms.CheckBox beh_checkbox_minimizeinstead;
    private System.Windows.Forms.CheckBox beh_checkbox_minimized;
    private System.Windows.Forms.GroupBox updates_line;
    private System.Windows.Forms.Label label_updates;
    private System.Windows.Forms.GroupBox behaviour_line;
    private System.Windows.Forms.Label label_behaviour;
    private System.Windows.Forms.Button button_fake;
    private System.Windows.Forms.Label label_preferences;
    private System.Windows.Forms.TreeView tree_preferences;
    #endregion

    #region My declarations
    private Settings rbSettings = new Settings();
    private string fontName = "Trebuchet MS";
    private float fontSize = 0F;
    private string fontStyle = "regular";
    private System.Windows.Forms.Form parentForm;
    #endregion

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RooBooks_Preferences(System.Windows.Forms.Form pf)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
      //
      this.parentForm = pf;
      this.fontName = (String)this.rbSettings.getRegistrySetting("ApplicationFontName");
      this.fontSize = Convert.ToSingle(this.rbSettings.getRegistrySetting("ApplicationFontSize"));
      this.fontStyle = (string)this.rbSettings.getRegistrySetting("ApplicationFontStyle");
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RooBooks_Preferences));
      this.fontDialog = new System.Windows.Forms.FontDialog();
      this.panel_main = new System.Windows.Forms.Panel();
      this.group_box = new System.Windows.Forms.GroupBox();
      this.panel_appearance = new System.Windows.Forms.Panel();
      this.checkBox_tbText_default = new System.Windows.Forms.CheckBox();
      this.comboBox_tbText = new System.Windows.Forms.ComboBox();
      this.label_tbText = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label_Appearance = new System.Windows.Forms.Label();
      this.button_change_font = new System.Windows.Forms.Button();
      this.preview_font = new System.Windows.Forms.Label();
      this.font_checkbox = new System.Windows.Forms.CheckBox();
      this.label_font = new System.Windows.Forms.Label();
      this.panel_general = new System.Windows.Forms.Panel();
      this.beh_checkbox_checkforupdates = new System.Windows.Forms.CheckBox();
      this.beh_checkbox_minimizetotray = new System.Windows.Forms.CheckBox();
      this.beh_checkbox_minimizeinstead = new System.Windows.Forms.CheckBox();
      this.beh_checkbox_minimized = new System.Windows.Forms.CheckBox();
      this.updates_line = new System.Windows.Forms.GroupBox();
      this.label_updates = new System.Windows.Forms.Label();
      this.behaviour_line = new System.Windows.Forms.GroupBox();
      this.label_behaviour = new System.Windows.Forms.Label();
      this.label_description = new System.Windows.Forms.Label();
      this.button_apply = new System.Windows.Forms.Button();
      this.button_cancel = new System.Windows.Forms.Button();
      this.button_ok = new System.Windows.Forms.Button();
      this.button_fake = new System.Windows.Forms.Button();
      this.label_preferences = new System.Windows.Forms.Label();
      this.tree_preferences = new System.Windows.Forms.TreeView();
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.checkBox_ResizeBeyond = new System.Windows.Forms.CheckBox();
      this.panel_main.SuspendLayout();
      this.group_box.SuspendLayout();
      this.panel_appearance.SuspendLayout();
      this.panel_general.SuspendLayout();
      this.SuspendLayout();
      // 
      // fontDialog
      // 
      this.fontDialog.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.fontDialog.MaxSize = 28;
      this.fontDialog.MinSize = 6;
      this.fontDialog.ShowEffects = false;
      // 
      // panel_main
      // 
      this.panel_main.Controls.Add(this.group_box);
      this.panel_main.Controls.Add(this.label_description);
      this.panel_main.Controls.Add(this.button_apply);
      this.panel_main.Controls.Add(this.button_cancel);
      this.panel_main.Controls.Add(this.button_ok);
      this.panel_main.Controls.Add(this.button_fake);
      this.panel_main.Controls.Add(this.label_preferences);
      this.panel_main.Controls.Add(this.tree_preferences);
      this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_main.Location = new System.Drawing.Point(0, 0);
      this.panel_main.Name = "panel_main";
      this.panel_main.Size = new System.Drawing.Size(696, 452);
      this.panel_main.TabIndex = 1;
      // 
      // group_box
      // 
      this.group_box.Controls.Add(this.panel_appearance);
      this.group_box.Controls.Add(this.panel_general);
      this.group_box.Location = new System.Drawing.Point(189, 63);
      this.group_box.Name = "group_box";
      this.group_box.Size = new System.Drawing.Size(489, 333);
      this.group_box.TabIndex = 3;
      this.group_box.TabStop = false;
      this.group_box.Text = "General";
      // 
      // panel_appearance
      // 
      this.panel_appearance.Controls.Add(this.checkBox_ResizeBeyond);
      this.panel_appearance.Controls.Add(this.checkBox_tbText_default);
      this.panel_appearance.Controls.Add(this.comboBox_tbText);
      this.panel_appearance.Controls.Add(this.label_tbText);
      this.panel_appearance.Controls.Add(this.groupBox1);
      this.panel_appearance.Controls.Add(this.label_Appearance);
      this.panel_appearance.Controls.Add(this.button_change_font);
      this.panel_appearance.Controls.Add(this.preview_font);
      this.panel_appearance.Controls.Add(this.font_checkbox);
      this.panel_appearance.Controls.Add(this.label_font);
      this.panel_appearance.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_appearance.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.panel_appearance.Location = new System.Drawing.Point(3, 16);
      this.panel_appearance.Name = "panel_appearance";
      this.panel_appearance.Size = new System.Drawing.Size(483, 314);
      this.panel_appearance.TabIndex = 0;
      // 
      // checkBox_tbText_default
      // 
      this.checkBox_tbText_default.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.checkBox_tbText_default.Location = new System.Drawing.Point(172, 180);
      this.checkBox_tbText_default.Name = "checkBox_tbText_default";
      this.checkBox_tbText_default.Size = new System.Drawing.Size(144, 20);
      this.checkBox_tbText_default.TabIndex = 13;
      this.checkBox_tbText_default.Text = "Use default";
      this.checkBox_tbText_default.CheckedChanged += new System.EventHandler(this.checkBox_tbText_default_CheckedChanged);
      // 
      // comboBox_tbText
      // 
      this.comboBox_tbText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox_tbText.Location = new System.Drawing.Point(12, 180);
      this.comboBox_tbText.Name = "comboBox_tbText";
      this.comboBox_tbText.Size = new System.Drawing.Size(144, 24);
      this.comboBox_tbText.TabIndex = 12;
      // 
      // label_tbText
      // 
      this.label_tbText.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_tbText.Location = new System.Drawing.Point(12, 149);
      this.label_tbText.Name = "label_tbText";
      this.label_tbText.Size = new System.Drawing.Size(144, 18);
      this.label_tbText.TabIndex = 11;
      this.label_tbText.Text = "Toolbar text";
      // 
      // groupBox1
      // 
      this.groupBox1.Location = new System.Drawing.Point(72, 18);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(399, 2);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      // 
      // label_Appearance
      // 
      this.label_Appearance.Location = new System.Drawing.Point(12, 12);
      this.label_Appearance.Name = "label_Appearance";
      this.label_Appearance.Size = new System.Drawing.Size(57, 15);
      this.label_Appearance.TabIndex = 9;
      this.label_Appearance.Text = "Font";
      this.label_Appearance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // button_change_font
      // 
      this.button_change_font.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_change_font.Location = new System.Drawing.Point(172, 72);
      this.button_change_font.Name = "button_change_font";
      this.button_change_font.Size = new System.Drawing.Size(165, 33);
      this.button_change_font.TabIndex = 8;
      this.button_change_font.Text = "Change font";
      this.button_change_font.Click += new System.EventHandler(this.button_change_font_Click);
      // 
      // preview_font
      // 
      this.preview_font.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.preview_font.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.preview_font.Location = new System.Drawing.Point(12, 72);
      this.preview_font.Name = "preview_font";
      this.preview_font.Size = new System.Drawing.Size(147, 63);
      this.preview_font.TabIndex = 6;
      this.preview_font.Text = "Font Preview";
      this.preview_font.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // font_checkbox
      // 
      this.font_checkbox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.font_checkbox.Location = new System.Drawing.Point(174, 115);
      this.font_checkbox.Name = "font_checkbox";
      this.font_checkbox.Size = new System.Drawing.Size(144, 20);
      this.font_checkbox.TabIndex = 2;
      this.font_checkbox.Text = "Use default";
      this.font_checkbox.CheckedChanged += new System.EventHandler(this.font_checkbox_CheckedChanged);
      // 
      // label_font
      // 
      this.label_font.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_font.Location = new System.Drawing.Point(12, 39);
      this.label_font.Name = "label_font";
      this.label_font.Size = new System.Drawing.Size(144, 18);
      this.label_font.TabIndex = 0;
      this.label_font.Text = "Application font ";
      // 
      // panel_general
      // 
      this.panel_general.Controls.Add(this.beh_checkbox_checkforupdates);
      this.panel_general.Controls.Add(this.beh_checkbox_minimizetotray);
      this.panel_general.Controls.Add(this.beh_checkbox_minimizeinstead);
      this.panel_general.Controls.Add(this.beh_checkbox_minimized);
      this.panel_general.Controls.Add(this.updates_line);
      this.panel_general.Controls.Add(this.label_updates);
      this.panel_general.Controls.Add(this.behaviour_line);
      this.panel_general.Controls.Add(this.label_behaviour);
      this.panel_general.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_general.Location = new System.Drawing.Point(3, 16);
      this.panel_general.Name = "panel_general";
      this.panel_general.Size = new System.Drawing.Size(483, 314);
      this.panel_general.TabIndex = 0;
      // 
      // beh_checkbox_checkforupdates
      // 
      this.beh_checkbox_checkforupdates.Location = new System.Drawing.Point(12, 222);
      this.beh_checkbox_checkforupdates.Name = "beh_checkbox_checkforupdates";
      this.beh_checkbox_checkforupdates.Size = new System.Drawing.Size(232, 15);
      this.beh_checkbox_checkforupdates.TabIndex = 10;
      this.beh_checkbox_checkforupdates.Text = "Check on start for updates";
      // 
      // beh_checkbox_minimizetotray
      // 
      this.beh_checkbox_minimizetotray.Location = new System.Drawing.Point(12, 108);
      this.beh_checkbox_minimizetotray.Name = "beh_checkbox_minimizetotray";
      this.beh_checkbox_minimizetotray.Size = new System.Drawing.Size(232, 15);
      this.beh_checkbox_minimizetotray.TabIndex = 8;
      this.beh_checkbox_minimizetotray.Text = "Minimize application to tray";
      // 
      // beh_checkbox_minimizeinstead
      // 
      this.beh_checkbox_minimizeinstead.Location = new System.Drawing.Point(12, 76);
      this.beh_checkbox_minimizeinstead.Name = "beh_checkbox_minimizeinstead";
      this.beh_checkbox_minimizeinstead.Size = new System.Drawing.Size(232, 15);
      this.beh_checkbox_minimizeinstead.TabIndex = 6;
      this.beh_checkbox_minimizeinstead.Text = "Minimize application instead of closing";
      // 
      // beh_checkbox_minimized
      // 
      this.beh_checkbox_minimized.Location = new System.Drawing.Point(12, 39);
      this.beh_checkbox_minimized.Name = "beh_checkbox_minimized";
      this.beh_checkbox_minimized.Size = new System.Drawing.Size(232, 18);
      this.beh_checkbox_minimized.TabIndex = 4;
      this.beh_checkbox_minimized.Text = "Run minimized";
      // 
      // updates_line
      // 
      this.updates_line.Location = new System.Drawing.Point(73, 198);
      this.updates_line.Name = "updates_line";
      this.updates_line.Size = new System.Drawing.Size(399, 2);
      this.updates_line.TabIndex = 3;
      this.updates_line.TabStop = false;
      // 
      // label_updates
      // 
      this.label_updates.Location = new System.Drawing.Point(10, 192);
      this.label_updates.Name = "label_updates";
      this.label_updates.Size = new System.Drawing.Size(57, 15);
      this.label_updates.TabIndex = 2;
      this.label_updates.Text = "Updates";
      // 
      // behaviour_line
      // 
      this.behaviour_line.Location = new System.Drawing.Point(72, 18);
      this.behaviour_line.Name = "behaviour_line";
      this.behaviour_line.Size = new System.Drawing.Size(399, 2);
      this.behaviour_line.TabIndex = 1;
      this.behaviour_line.TabStop = false;
      // 
      // label_behaviour
      // 
      this.label_behaviour.Location = new System.Drawing.Point(9, 12);
      this.label_behaviour.Name = "label_behaviour";
      this.label_behaviour.Size = new System.Drawing.Size(57, 15);
      this.label_behaviour.TabIndex = 0;
      this.label_behaviour.Text = "Behaviour";
      // 
      // label_description
      // 
      this.label_description.BackColor = System.Drawing.SystemColors.HotTrack;
      this.label_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label_description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label_description.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_description.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.label_description.Location = new System.Drawing.Point(180, 12);
      this.label_description.Name = "label_description";
      this.label_description.Size = new System.Drawing.Size(507, 36);
      this.label_description.TabIndex = 7;
      this.label_description.Text = " General";
      this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // button_apply
      // 
      this.button_apply.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_apply.Location = new System.Drawing.Point(594, 414);
      this.button_apply.Name = "button_apply";
      this.button_apply.Size = new System.Drawing.Size(93, 27);
      this.button_apply.TabIndex = 6;
      this.button_apply.Text = "Apply";
      this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
      // 
      // button_cancel
      // 
      this.button_cancel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_cancel.Location = new System.Drawing.Point(492, 414);
      this.button_cancel.Name = "button_cancel";
      this.button_cancel.Size = new System.Drawing.Size(93, 27);
      this.button_cancel.TabIndex = 5;
      this.button_cancel.Text = "Cancel";
      this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
      // 
      // button_ok
      // 
      this.button_ok.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_ok.Location = new System.Drawing.Point(390, 414);
      this.button_ok.Name = "button_ok";
      this.button_ok.Size = new System.Drawing.Size(93, 27);
      this.button_ok.TabIndex = 4;
      this.button_ok.Text = "OK";
      this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
      // 
      // button_fake
      // 
      this.button_fake.Enabled = false;
      this.button_fake.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.button_fake.Location = new System.Drawing.Point(180, 57);
      this.button_fake.Name = "button_fake";
      this.button_fake.Size = new System.Drawing.Size(507, 348);
      this.button_fake.TabIndex = 2;
      this.button_fake.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      // 
      // label_preferences
      // 
      this.label_preferences.Location = new System.Drawing.Point(12, 12);
      this.label_preferences.Name = "label_preferences";
      this.label_preferences.Size = new System.Drawing.Size(141, 15);
      this.label_preferences.TabIndex = 1;
      this.label_preferences.Text = "Preferences";
      // 
      // tree_preferences
      // 
      this.tree_preferences.Cursor = System.Windows.Forms.Cursors.Default;
      this.tree_preferences.FullRowSelect = true;
      this.tree_preferences.ImageIndex = -1;
      this.tree_preferences.Location = new System.Drawing.Point(9, 30);
      this.tree_preferences.Name = "tree_preferences";
      this.tree_preferences.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
                                                                                 new System.Windows.Forms.TreeNode("General"),
                                                                                 new System.Windows.Forms.TreeNode("Appearance")});
      this.tree_preferences.SelectedImageIndex = -1;
      this.tree_preferences.Size = new System.Drawing.Size(159, 375);
      this.tree_preferences.TabIndex = 0;
      this.tree_preferences.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_preferences_AfterSelect);
      // 
      // checkBox_ResizeBeyond
      // 
      this.checkBox_ResizeBeyond.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.checkBox_ResizeBeyond.Location = new System.Drawing.Point(12, 220);
      this.checkBox_ResizeBeyond.Name = "checkBox_ResizeBeyond";
      this.checkBox_ResizeBeyond.Size = new System.Drawing.Size(144, 20);
      this.checkBox_ResizeBeyond.TabIndex = 14;
      this.checkBox_ResizeBeyond.Text = "Free Resize";
      // 
      // RooBooks_Preferences
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(696, 452);
      this.Controls.Add(this.panel_main);
      this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Menu = this.mainMenu1;
      this.MinimizeBox = false;
      this.Name = "RooBooks_Preferences";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Preferences";
      this.Load += new System.EventHandler(this.RooBooks_Preferences_Load);
      this.panel_main.ResumeLayout(false);
      this.group_box.ResumeLayout(false);
      this.panel_appearance.ResumeLayout(false);
      this.panel_general.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

    private void RooBooks_Preferences_Load(object sender, System.EventArgs e)
    {
      try 
      {
        this.beh_checkbox_minimized.Checked = bool.Parse((string)this.rbSettings.getRegistrySetting("RunMinimized"));
        this.beh_checkbox_minimizeinstead.Checked = bool.Parse((string)this.rbSettings.getRegistrySetting("MinimizeInstead"));
        this.beh_checkbox_minimizetotray.Checked = bool.Parse((string)this.rbSettings.getRegistrySetting("MinimizeToTray"));
        this.beh_checkbox_checkforupdates.Checked = bool.Parse((string)this.rbSettings.getRegistrySetting("CheckForUpdatesOnStart"));
        this.checkBox_ResizeBeyond.Checked = bool.Parse((string)this.rbSettings.getRegistrySetting("ResizeBeyond"));
        LoadSettings();
        LoadComboToolbar();
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }    
    }

    #region Loading Settings
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
          if (c.Name == "label_description")
            c.Font = new Font(font.FontFamily, font.Size + 6F, font.Style);
          else if (c.Name == "button_ok" || c.Name == "button_cancel" || c.Name == "button_apply")
            c.Font = new Font(font.FontFamily, font.Size + 2F, font.Style);
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
    #endregion

    #region Event-handlers
    private void button_cancel_Click(object sender, System.EventArgs e)
    {
      this.Close();
    }

    private void button_ok_Click(object sender, System.EventArgs e)
    {
      savePreferences();
      this.Close();
    }

    private void button_apply_Click(object sender, System.EventArgs e)
    {
      savePreferences();
    }

    private void button_change_font_Click(object sender, System.EventArgs e)
    {
      try 
      {
        FontStyle style = FontStyle.Regular;
        if (this.fontStyle == "bold")
          style = FontStyle.Bold;
        if (this.fontStyle == "italic")
          style = FontStyle.Italic;

        this.fontDialog.Font = new Font(this.fontName, this.fontSize, style);
        if (this.fontDialog.ShowDialog() == DialogResult.OK) 
        {
          String dFont = this.fontDialog.Font.FontFamily.GetName(0);
          float dSize = this.fontDialog.Font.Size;
          FontStyle dStyle = this.fontDialog.Font.Style;
          this.preview_font.Font = new Font(dFont, dSize, dStyle);
          this.fontName = dFont;
          this.fontSize = dSize;
          if (dStyle == FontStyle.Regular)
            this.fontStyle = "regular";
          if (dStyle == FontStyle.Italic)
            this.fontStyle = "italic";
          if (dStyle == FontStyle.Bold)
            this.fontStyle = "bold";
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void font_checkbox_CheckedChanged(object sender, System.EventArgs e)
    {
      setDefaultFont();
    }

    private void tree_preferences_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
    {
      String selectedPreference = this.tree_preferences.SelectedNode.Text;
      this.label_description.Text = selectedPreference;
      this.group_box.Text = selectedPreference;
      showPreferences();
    }
    private void checkBox_tbText_default_CheckedChanged(object sender, System.EventArgs e)
    {
      LoadComboToolbar();
    }
    #endregion

    #region Workers
    private void setDefaultFont() 
    {
      this.fontName = (String)this.rbSettings.getRegistrySetting("ApplicationFontName");
      this.fontSize = Convert.ToSingle(this.rbSettings.getRegistrySetting("ApplicationFontSize"));
      this.fontStyle = (string)this.rbSettings.getRegistrySetting("ApplicationFontStyle");

      FontStyle style = FontStyle.Regular;
      if (this.fontStyle == "bold")
        style = FontStyle.Bold;
      if (this.fontStyle == "italic")
        style = FontStyle.Italic;
      if (this.fontStyle == "strikeout")
        style = FontStyle.Strikeout;
      if (this.fontStyle == "underline")
        style = FontStyle.Underline;

      this.preview_font.Font = new Font(this.fontName, this.fontSize, style);
    }
    private void savePreferences() 
    {
      // appearance
      this.rbSettings.setRegistrySetting("ApplicationFontName", this.fontName);
      this.rbSettings.setRegistrySetting("ApplicationFontSize", "" + this.fontSize);
      this.rbSettings.setRegistrySetting("ApplicationFontStyle", this.fontStyle);
      this.rbSettings.setRegistrySetting("ToolBarText", ((this.comboBox_tbText.SelectedItem.ToString() == "No text labels") ? "0" : ((this.comboBox_tbText.SelectedItem.ToString() == "Show text labels") ? "2" : "1")));
      this.rbSettings.setRegistrySetting("ResizeBeyond", ((this.checkBox_ResizeBeyond.Checked) ? "true" : "false"));
      ((RooBooks)this.parentForm).CanResizeBeyond = ((this.checkBox_ResizeBeyond.Checked) ? true : false);

      // general
      this.rbSettings.setRegistrySetting("RunMinimized", this.beh_checkbox_minimized.Checked.ToString());
      this.rbSettings.setRegistrySetting("MinimizeInstead", this.beh_checkbox_minimizeinstead.Checked.ToString());
      this.rbSettings.setRegistrySetting("MinimizeToTray", this.beh_checkbox_minimizetotray.Checked.ToString());
      this.rbSettings.setRegistrySetting("CheckForUpdatesOnStart", this.beh_checkbox_checkforupdates.Checked.ToString());

      // setting font on parent control
      FontStyle style = FontStyle.Regular;
      if (this.fontStyle == "bold")
        style = FontStyle.Bold;
      if (this.fontStyle == "italic")
        style = FontStyle.Italic;
      if (this.fontStyle == "strikeout")
        style = FontStyle.Strikeout;
      if (this.fontStyle == "underline")
        style = FontStyle.Underline;
      ((RooBooks)this.parentForm).SetControlsFont(new Font(this.fontName, this.fontSize, style));
      ((RooBooks)this.parentForm).SetToolbarTexts(((this.comboBox_tbText.SelectedItem.ToString() == "No text labels") ? 0 : ((this.comboBox_tbText.SelectedItem.ToString() == "Show text labels") ? 2 : 1)));
    }

    private void showPreferences() 
    {
      Cursor = Cursors.WaitCursor;
      showPanel();
      Cursor = Cursors.Default;
    }

    private void showPanel()
    {
      this.panel_general.Visible = false;
      this.panel_appearance.Visible = false;
      if (this.tree_preferences.SelectedNode.Text.Equals("General")) 
        this.panel_general.Visible = true;
      if (this.tree_preferences.SelectedNode.Text.Equals("Appearance")) 
        this.panel_appearance.Visible = true;
    }
    private void LoadComboToolbar() 
    {
      if (this.comboBox_tbText.Items.Count == 0)
        this.comboBox_tbText.Items.AddRange(new string[3] {"Show text labels", "Selective text on right", "No text labels"});
      int sett = int.Parse((string)this.rbSettings.getRegistrySetting("ToolBarText"));
      if (sett == 0)
        this.comboBox_tbText.Text = "Show text labels";
      if (sett == 1)
        this.comboBox_tbText.Text = "Selective text on right";
      if (sett == 2)
        this.comboBox_tbText.Text = "No text labels";
    }
    #endregion

    #region Error-handling
    public void MsgError(Exception ex, int errorLevel) 
    {
      string mbText = ((errorLevel == 1) ? ex.Message : ex.StackTrace);
      string mbCaption = "Exception occured";
      MessageBox.Show(this, mbText, mbCaption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }
    #endregion

	}
}
