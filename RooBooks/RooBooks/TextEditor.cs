using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Windows.Forms;

using RooBooks.Library;

namespace RooBooks.UI
{
	/// <summary>
	/// Summary description for TextEditor.
	/// </summary>
	public class TextEditor : System.Windows.Forms.UserControl
	{

    #region Declarations
    private System.Windows.Forms.MenuItem menuItem8;
    private System.Windows.Forms.MenuItem menuItem19;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Sep8;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Save;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Sep0;
    private System.Windows.Forms.ColorDialog colorDialog;
    private System.Windows.Forms.FontDialog fontDialog;
    private UtilityLibrary.CommandBars.ReBar reBar;
    private UtilityLibrary.CommandBars.ToolBarEx toolBarEx;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Cut;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Copy;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Paste;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Sep1;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Undo;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Redo;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Sep2;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Bold;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Italic;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Underline;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Strikeout;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Sep3;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Font;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_FontColor;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Sep4;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_ALeft;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_ACenter;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_ARight;
    private System.Windows.Forms.RichTextBox richTextBox;
    private System.Windows.Forms.ContextMenu contextMenu;
    private System.Windows.Forms.MenuItem menuItem1;
    private System.Windows.Forms.MenuItem menuItem2;
    private System.Windows.Forms.MenuItem menuItem3;
    private System.Windows.Forms.MenuItem menuItem4;
    private System.Windows.Forms.MenuItem menuItem9;
    private System.Windows.Forms.MenuItem menuItem10;
    private System.Windows.Forms.MenuItem menuItem11;
    private System.Windows.Forms.MenuItem menuItem12;
    private System.Windows.Forms.MenuItem menuItem13;
    private System.Windows.Forms.MenuItem menuItem14;
    private System.Windows.Forms.MenuItem menuItem15;
    private System.Windows.Forms.MenuItem menuItem_Bold;
    private System.Windows.Forms.MenuItem menuItem_Italic;
    private System.Windows.Forms.MenuItem menuItem_Underline;
    private System.Windows.Forms.MenuItem menuItem_Strikeout;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Sup;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Sub;
    private System.Windows.Forms.MenuItem menuItem5;
    private System.Windows.Forms.MenuItem menuItem6;
    private System.Windows.Forms.MenuItem menuItem7;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Baseline;
    #endregion

    #region Properties
    private int bookID = 0;
    public int BookID
    {
      get 
      {
        return bookID;
      }
      set 
      {
        bookID = value;
      }
    }
    private string fontFamilySelected = "Trebuchet MS";
    public string FontFamilySelected
    {
      get 
      {
        return fontFamilySelected;
      }
      set 
      {
        fontFamilySelected = value;
      }
    }
    private float fontSizeSelected = 8.25F;          
    public float FontSizeSelected
    {
      get 
      {
        return fontSizeSelected;
      }
      set 
      {
        fontSizeSelected = value;
      }
    }
    #endregion

    #region Designer variables
		private System.ComponentModel.Container components = null;
    #endregion

    #region Class specific
		public TextEditor()
		{
			InitializeComponent();
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TextEditor));
      this.reBar = new UtilityLibrary.CommandBars.ReBar();
      this.toolBarEx = new UtilityLibrary.CommandBars.ToolBarEx();
      this.toolBarItem_Save = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Sep0 = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Cut = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Copy = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Paste = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Sep1 = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Undo = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Redo = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Sep2 = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Bold = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Italic = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Underline = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Strikeout = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Sep8 = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Sup = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Sub = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Baseline = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Sep3 = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Font = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_FontColor = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_Sep4 = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_ALeft = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_ACenter = new UtilityLibrary.CommandBars.ToolBarItem();
      this.toolBarItem_ARight = new UtilityLibrary.CommandBars.ToolBarItem();
      this.richTextBox = new System.Windows.Forms.RichTextBox();
      this.contextMenu = new System.Windows.Forms.ContextMenu();
      this.menuItem1 = new System.Windows.Forms.MenuItem();
      this.menuItem2 = new System.Windows.Forms.MenuItem();
      this.menuItem3 = new System.Windows.Forms.MenuItem();
      this.menuItem4 = new System.Windows.Forms.MenuItem();
      this.menuItem_Bold = new System.Windows.Forms.MenuItem();
      this.menuItem_Italic = new System.Windows.Forms.MenuItem();
      this.menuItem_Underline = new System.Windows.Forms.MenuItem();
      this.menuItem_Strikeout = new System.Windows.Forms.MenuItem();
      this.menuItem6 = new System.Windows.Forms.MenuItem();
      this.menuItem5 = new System.Windows.Forms.MenuItem();
      this.menuItem7 = new System.Windows.Forms.MenuItem();
      this.menuItem9 = new System.Windows.Forms.MenuItem();
      this.menuItem10 = new System.Windows.Forms.MenuItem();
      this.menuItem11 = new System.Windows.Forms.MenuItem();
      this.menuItem12 = new System.Windows.Forms.MenuItem();
      this.menuItem13 = new System.Windows.Forms.MenuItem();
      this.menuItem14 = new System.Windows.Forms.MenuItem();
      this.menuItem15 = new System.Windows.Forms.MenuItem();
      this.menuItem8 = new System.Windows.Forms.MenuItem();
      this.menuItem19 = new System.Windows.Forms.MenuItem();
      this.fontDialog = new System.Windows.Forms.FontDialog();
      this.colorDialog = new System.Windows.Forms.ColorDialog();
      this.SuspendLayout();
      // 
      // reBar
      // 
      this.reBar.Bands.Add(this.toolBarEx);
      this.reBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.reBar.Location = new System.Drawing.Point(0, 0);
      this.reBar.Name = "reBar";
      this.reBar.Size = new System.Drawing.Size(616, 26);
      this.reBar.TabIndex = 0;
      this.reBar.TabStop = false;
      this.reBar.Text = "reBar";
      // 
      // toolBarEx
      // 
      this.toolBarEx.Dock = System.Windows.Forms.DockStyle.Top;
      this.toolBarEx.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.toolBarEx.Items.AddRange(new UtilityLibrary.CommandBars.ToolBarItem[] {
                                                                                   this.toolBarItem_Save,
                                                                                   this.toolBarItem_Sep0,
                                                                                   this.toolBarItem_Cut,
                                                                                   this.toolBarItem_Copy,
                                                                                   this.toolBarItem_Paste,
                                                                                   this.toolBarItem_Sep1,
                                                                                   this.toolBarItem_Undo,
                                                                                   this.toolBarItem_Redo,
                                                                                   this.toolBarItem_Sep2,
                                                                                   this.toolBarItem_Bold,
                                                                                   this.toolBarItem_Italic,
                                                                                   this.toolBarItem_Underline,
                                                                                   this.toolBarItem_Strikeout,
                                                                                   this.toolBarItem_Sep8,
                                                                                   this.toolBarItem_Sup,
                                                                                   this.toolBarItem_Sub,
                                                                                   this.toolBarItem_Baseline,
                                                                                   this.toolBarItem_Sep3,
                                                                                   this.toolBarItem_Font,
                                                                                   this.toolBarItem_FontColor,
                                                                                   this.toolBarItem_Sep4,
                                                                                   this.toolBarItem_ALeft,
                                                                                   this.toolBarItem_ACenter,
                                                                                   this.toolBarItem_ARight});
      this.toolBarEx.Location = new System.Drawing.Point(9, 2);
      this.toolBarEx.Name = "toolBarEx";
      this.toolBarEx.Size = new System.Drawing.Size(603, 22);
      this.toolBarEx.TabIndex = 0;
      this.toolBarEx.TabStop = false;
      // 
      // toolBarItem_Save
      // 
      this.toolBarItem_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Save.Image")));
      this.toolBarItem_Save.Index = 0;
      this.toolBarItem_Save.QuietMode = false;
      this.toolBarItem_Save.Text = null;
      this.toolBarItem_Save.ToolBar = this.toolBarEx;
      this.toolBarItem_Save.ToolTip = null;
      this.toolBarItem_Save.Click += new System.EventHandler(this.toolBarItem_Save_Click);
      // 
      // toolBarItem_Sep0
      // 
      this.toolBarItem_Sep0.Index = 1;
      this.toolBarItem_Sep0.QuietMode = false;
      this.toolBarItem_Sep0.Style = UtilityLibrary.CommandBars.ToolBarItemStyle.Separator;
      this.toolBarItem_Sep0.Text = null;
      this.toolBarItem_Sep0.ToolBar = this.toolBarEx;
      this.toolBarItem_Sep0.ToolTip = null;
      // 
      // toolBarItem_Cut
      // 
      this.toolBarItem_Cut.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Cut.Image")));
      this.toolBarItem_Cut.Index = 2;
      this.toolBarItem_Cut.QuietMode = false;
      this.toolBarItem_Cut.Text = null;
      this.toolBarItem_Cut.ToolBar = this.toolBarEx;
      this.toolBarItem_Cut.ToolTip = "Cut";
      this.toolBarItem_Cut.Click += new System.EventHandler(this.toolBarItem_Cut_Click);
      // 
      // toolBarItem_Copy
      // 
      this.toolBarItem_Copy.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Copy.Image")));
      this.toolBarItem_Copy.Index = 3;
      this.toolBarItem_Copy.QuietMode = false;
      this.toolBarItem_Copy.Text = null;
      this.toolBarItem_Copy.ToolBar = this.toolBarEx;
      this.toolBarItem_Copy.ToolTip = "Copy";
      this.toolBarItem_Copy.Click += new System.EventHandler(this.toolBarItem_Copy_Click);
      // 
      // toolBarItem_Paste
      // 
      this.toolBarItem_Paste.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Paste.Image")));
      this.toolBarItem_Paste.Index = 4;
      this.toolBarItem_Paste.QuietMode = false;
      this.toolBarItem_Paste.Text = null;
      this.toolBarItem_Paste.ToolBar = this.toolBarEx;
      this.toolBarItem_Paste.ToolTip = "Paste";
      this.toolBarItem_Paste.Click += new System.EventHandler(this.toolBarItem_Paste_Click);
      // 
      // toolBarItem_Sep1
      // 
      this.toolBarItem_Sep1.Index = 5;
      this.toolBarItem_Sep1.QuietMode = false;
      this.toolBarItem_Sep1.Style = UtilityLibrary.CommandBars.ToolBarItemStyle.Separator;
      this.toolBarItem_Sep1.Text = null;
      this.toolBarItem_Sep1.ToolBar = this.toolBarEx;
      this.toolBarItem_Sep1.ToolTip = null;
      // 
      // toolBarItem_Undo
      // 
      this.toolBarItem_Undo.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Undo.Image")));
      this.toolBarItem_Undo.Index = 6;
      this.toolBarItem_Undo.QuietMode = false;
      this.toolBarItem_Undo.Text = null;
      this.toolBarItem_Undo.ToolBar = this.toolBarEx;
      this.toolBarItem_Undo.ToolTip = "Undo";
      this.toolBarItem_Undo.Click += new System.EventHandler(this.toolBarItem_Undo_Click);
      // 
      // toolBarItem_Redo
      // 
      this.toolBarItem_Redo.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Redo.Image")));
      this.toolBarItem_Redo.Index = 7;
      this.toolBarItem_Redo.QuietMode = false;
      this.toolBarItem_Redo.Text = null;
      this.toolBarItem_Redo.ToolBar = this.toolBarEx;
      this.toolBarItem_Redo.ToolTip = "Redo";
      this.toolBarItem_Redo.Click += new System.EventHandler(this.toolBarItem_Redo_Click);
      // 
      // toolBarItem_Sep2
      // 
      this.toolBarItem_Sep2.Index = 8;
      this.toolBarItem_Sep2.QuietMode = false;
      this.toolBarItem_Sep2.Style = UtilityLibrary.CommandBars.ToolBarItemStyle.Separator;
      this.toolBarItem_Sep2.Text = null;
      this.toolBarItem_Sep2.ToolBar = this.toolBarEx;
      this.toolBarItem_Sep2.ToolTip = null;
      // 
      // toolBarItem_Bold
      // 
      this.toolBarItem_Bold.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Bold.Image")));
      this.toolBarItem_Bold.Index = 9;
      this.toolBarItem_Bold.QuietMode = false;
      this.toolBarItem_Bold.Text = null;
      this.toolBarItem_Bold.ToolBar = this.toolBarEx;
      this.toolBarItem_Bold.ToolTip = "Bold";
      this.toolBarItem_Bold.Click += new System.EventHandler(this.toolBarItem_Bold_Click);
      // 
      // toolBarItem_Italic
      // 
      this.toolBarItem_Italic.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Italic.Image")));
      this.toolBarItem_Italic.Index = 10;
      this.toolBarItem_Italic.QuietMode = false;
      this.toolBarItem_Italic.Text = null;
      this.toolBarItem_Italic.ToolBar = this.toolBarEx;
      this.toolBarItem_Italic.ToolTip = "Italic";
      this.toolBarItem_Italic.Click += new System.EventHandler(this.toolBarItem_Italic_Click);
      // 
      // toolBarItem_Underline
      // 
      this.toolBarItem_Underline.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Underline.Image")));
      this.toolBarItem_Underline.Index = 11;
      this.toolBarItem_Underline.QuietMode = false;
      this.toolBarItem_Underline.Text = null;
      this.toolBarItem_Underline.ToolBar = this.toolBarEx;
      this.toolBarItem_Underline.ToolTip = "Underline";
      this.toolBarItem_Underline.Click += new System.EventHandler(this.toolBarItem_Underline_Click);
      // 
      // toolBarItem_Strikeout
      // 
      this.toolBarItem_Strikeout.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Strikeout.Image")));
      this.toolBarItem_Strikeout.Index = 12;
      this.toolBarItem_Strikeout.QuietMode = false;
      this.toolBarItem_Strikeout.Text = null;
      this.toolBarItem_Strikeout.ToolBar = this.toolBarEx;
      this.toolBarItem_Strikeout.ToolTip = "Strikeout";
      this.toolBarItem_Strikeout.Click += new System.EventHandler(this.toolBarItem_Strikeout_Click);
      // 
      // toolBarItem_Sep8
      // 
      this.toolBarItem_Sep8.Index = 13;
      this.toolBarItem_Sep8.QuietMode = false;
      this.toolBarItem_Sep8.Style = UtilityLibrary.CommandBars.ToolBarItemStyle.Separator;
      this.toolBarItem_Sep8.Text = null;
      this.toolBarItem_Sep8.ToolBar = this.toolBarEx;
      this.toolBarItem_Sep8.ToolTip = null;
      // 
      // toolBarItem_Sup
      // 
      this.toolBarItem_Sup.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Sup.Image")));
      this.toolBarItem_Sup.Index = 14;
      this.toolBarItem_Sup.QuietMode = false;
      this.toolBarItem_Sup.Text = null;
      this.toolBarItem_Sup.ToolBar = this.toolBarEx;
      this.toolBarItem_Sup.ToolTip = "Superscript";
      this.toolBarItem_Sup.Changed += new System.EventHandler(this.toolBarItem_Sup_Changed);
      // 
      // toolBarItem_Sub
      // 
      this.toolBarItem_Sub.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Sub.Image")));
      this.toolBarItem_Sub.Index = 15;
      this.toolBarItem_Sub.QuietMode = false;
      this.toolBarItem_Sub.Text = null;
      this.toolBarItem_Sub.ToolBar = this.toolBarEx;
      this.toolBarItem_Sub.ToolTip = "Subscript";
      this.toolBarItem_Sub.Changed += new System.EventHandler(this.toolBarItem_Sub_Changed);
      // 
      // toolBarItem_Baseline
      // 
      this.toolBarItem_Baseline.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Baseline.Image")));
      this.toolBarItem_Baseline.Index = 16;
      this.toolBarItem_Baseline.QuietMode = false;
      this.toolBarItem_Baseline.Text = null;
      this.toolBarItem_Baseline.ToolBar = this.toolBarEx;
      this.toolBarItem_Baseline.ToolTip = null;
      this.toolBarItem_Baseline.Changed += new System.EventHandler(this.toolBarItem_Baseline_Changed);
      // 
      // toolBarItem_Sep3
      // 
      this.toolBarItem_Sep3.Index = 17;
      this.toolBarItem_Sep3.QuietMode = false;
      this.toolBarItem_Sep3.Style = UtilityLibrary.CommandBars.ToolBarItemStyle.Separator;
      this.toolBarItem_Sep3.Text = null;
      this.toolBarItem_Sep3.ToolBar = this.toolBarEx;
      this.toolBarItem_Sep3.ToolTip = null;
      // 
      // toolBarItem_Font
      // 
      this.toolBarItem_Font.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_Font.Image")));
      this.toolBarItem_Font.Index = 18;
      this.toolBarItem_Font.QuietMode = false;
      this.toolBarItem_Font.Text = null;
      this.toolBarItem_Font.ToolBar = this.toolBarEx;
      this.toolBarItem_Font.ToolTip = "Choose font";
      this.toolBarItem_Font.Click += new System.EventHandler(this.toolBarItem_Font_Click);
      // 
      // toolBarItem_FontColor
      // 
      this.toolBarItem_FontColor.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_FontColor.Image")));
      this.toolBarItem_FontColor.Index = 19;
      this.toolBarItem_FontColor.QuietMode = false;
      this.toolBarItem_FontColor.Text = null;
      this.toolBarItem_FontColor.ToolBar = this.toolBarEx;
      this.toolBarItem_FontColor.ToolTip = "Choose font color";
      this.toolBarItem_FontColor.Click += new System.EventHandler(this.toolBarItem_FontColor_Click);
      // 
      // toolBarItem_Sep4
      // 
      this.toolBarItem_Sep4.Index = 20;
      this.toolBarItem_Sep4.QuietMode = false;
      this.toolBarItem_Sep4.Style = UtilityLibrary.CommandBars.ToolBarItemStyle.Separator;
      this.toolBarItem_Sep4.Text = null;
      this.toolBarItem_Sep4.ToolBar = this.toolBarEx;
      this.toolBarItem_Sep4.ToolTip = null;
      // 
      // toolBarItem_ALeft
      // 
      this.toolBarItem_ALeft.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_ALeft.Image")));
      this.toolBarItem_ALeft.Index = 21;
      this.toolBarItem_ALeft.QuietMode = false;
      this.toolBarItem_ALeft.Text = null;
      this.toolBarItem_ALeft.ToolBar = this.toolBarEx;
      this.toolBarItem_ALeft.ToolTip = "Align left";
      this.toolBarItem_ALeft.Click += new System.EventHandler(this.toolBarItem_ALeft_Click);
      // 
      // toolBarItem_ACenter
      // 
      this.toolBarItem_ACenter.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_ACenter.Image")));
      this.toolBarItem_ACenter.Index = 22;
      this.toolBarItem_ACenter.QuietMode = false;
      this.toolBarItem_ACenter.Text = null;
      this.toolBarItem_ACenter.ToolBar = this.toolBarEx;
      this.toolBarItem_ACenter.ToolTip = "Align center";
      this.toolBarItem_ACenter.Click += new System.EventHandler(this.toolBarItem_ACenter_Click);
      // 
      // toolBarItem_ARight
      // 
      this.toolBarItem_ARight.Image = ((System.Drawing.Image)(resources.GetObject("toolBarItem_ARight.Image")));
      this.toolBarItem_ARight.Index = 23;
      this.toolBarItem_ARight.QuietMode = false;
      this.toolBarItem_ARight.Text = null;
      this.toolBarItem_ARight.ToolBar = this.toolBarEx;
      this.toolBarItem_ARight.ToolTip = "Align right";
      this.toolBarItem_ARight.Click += new System.EventHandler(this.toolBarItem_ARight_Click);
      // 
      // richTextBox
      // 
      this.richTextBox.ContextMenu = this.contextMenu;
      this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox.Location = new System.Drawing.Point(0, 26);
      this.richTextBox.Name = "richTextBox";
      this.richTextBox.Size = new System.Drawing.Size(616, 334);
      this.richTextBox.TabIndex = 2;
      this.richTextBox.Text = "";
      this.richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox_LinkClicked);
      // 
      // contextMenu
      // 
      this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                this.menuItem1,
                                                                                this.menuItem2,
                                                                                this.menuItem3,
                                                                                this.menuItem4,
                                                                                this.menuItem_Bold,
                                                                                this.menuItem_Italic,
                                                                                this.menuItem_Underline,
                                                                                this.menuItem_Strikeout,
                                                                                this.menuItem6,
                                                                                this.menuItem5,
                                                                                this.menuItem7,
                                                                                this.menuItem9,
                                                                                this.menuItem10,
                                                                                this.menuItem11,
                                                                                this.menuItem12,
                                                                                this.menuItem13,
                                                                                this.menuItem14,
                                                                                this.menuItem15,
                                                                                this.menuItem8,
                                                                                this.menuItem19});
      // 
      // menuItem1
      // 
      this.menuItem1.Index = 0;
      this.menuItem1.Text = "Cut";
      this.menuItem1.Click += new System.EventHandler(this.toolBarItem_Cut_Click);
      // 
      // menuItem2
      // 
      this.menuItem2.Index = 1;
      this.menuItem2.Text = "Copy";
      this.menuItem2.Click += new System.EventHandler(this.toolBarItem_Copy_Click);
      // 
      // menuItem3
      // 
      this.menuItem3.Index = 2;
      this.menuItem3.Text = "Paste";
      this.menuItem3.Click += new System.EventHandler(this.toolBarItem_Paste_Click);
      // 
      // menuItem4
      // 
      this.menuItem4.Index = 3;
      this.menuItem4.Text = "-";
      // 
      // menuItem_Bold
      // 
      this.menuItem_Bold.Index = 4;
      this.menuItem_Bold.Text = "Bold";
      this.menuItem_Bold.Click += new System.EventHandler(this.toolBarItem_Bold_Click);
      // 
      // menuItem_Italic
      // 
      this.menuItem_Italic.Index = 5;
      this.menuItem_Italic.Text = "Italic";
      this.menuItem_Italic.Click += new System.EventHandler(this.toolBarItem_Italic_Click);
      // 
      // menuItem_Underline
      // 
      this.menuItem_Underline.Index = 6;
      this.menuItem_Underline.Text = "Underline";
      this.menuItem_Underline.Click += new System.EventHandler(this.toolBarItem_Underline_Click);
      // 
      // menuItem_Strikeout
      // 
      this.menuItem_Strikeout.Index = 7;
      this.menuItem_Strikeout.Text = "Strikeout";
      this.menuItem_Strikeout.Click += new System.EventHandler(this.toolBarItem_Strikeout_Click);
      // 
      // menuItem6
      // 
      this.menuItem6.Index = 8;
      this.menuItem6.Text = "Subscript";
      this.menuItem6.Click += new System.EventHandler(this.toolBarItem_Sub_Changed);
      // 
      // menuItem5
      // 
      this.menuItem5.Index = 9;
      this.menuItem5.Text = "Superscript";
      this.menuItem5.Click += new System.EventHandler(this.toolBarItem_Sup_Changed);
      // 
      // menuItem7
      // 
      this.menuItem7.Index = 10;
      this.menuItem7.Text = "Baseline";
      this.menuItem7.Click += new System.EventHandler(this.toolBarItem_Baseline_Changed);
      // 
      // menuItem9
      // 
      this.menuItem9.Index = 11;
      this.menuItem9.Text = "-";
      // 
      // menuItem10
      // 
      this.menuItem10.Index = 12;
      this.menuItem10.Text = "Font";
      this.menuItem10.Click += new System.EventHandler(this.toolBarItem_Font_Click);
      // 
      // menuItem11
      // 
      this.menuItem11.Index = 13;
      this.menuItem11.Text = "Font color";
      this.menuItem11.Click += new System.EventHandler(this.toolBarItem_FontColor_Click);
      // 
      // menuItem12
      // 
      this.menuItem12.Index = 14;
      this.menuItem12.Text = "-";
      // 
      // menuItem13
      // 
      this.menuItem13.Index = 15;
      this.menuItem13.Text = "Align left";
      this.menuItem13.Click += new System.EventHandler(this.toolBarItem_ALeft_Click);
      // 
      // menuItem14
      // 
      this.menuItem14.Index = 16;
      this.menuItem14.Text = "Align center";
      this.menuItem14.Click += new System.EventHandler(this.toolBarItem_ACenter_Click);
      // 
      // menuItem15
      // 
      this.menuItem15.Index = 17;
      this.menuItem15.Text = "Align right";
      this.menuItem15.Click += new System.EventHandler(this.toolBarItem_ARight_Click);
      // 
      // menuItem8
      // 
      this.menuItem8.Index = 18;
      this.menuItem8.Text = "-";
      // 
      // menuItem19
      // 
      this.menuItem19.Index = 19;
      this.menuItem19.Text = "Wordwrap";
      this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
      // 
      // fontDialog
      // 
      this.fontDialog.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      // 
      // TextEditor
      // 
      this.Controls.Add(this.richTextBox);
      this.Controls.Add(this.reBar);
      this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.Name = "TextEditor";
      this.Size = new System.Drawing.Size(616, 360);
      this.ResumeLayout(false);

    }
		#endregion
    #endregion

    #region ToolBar Buttons
    private void toolBarItem_Save_Click(object sender, System.EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      DB w = new DB();
      w.UpdateBookNotes(this.BookID, this.richTextBox.Rtf);
      Cursor = Cursors.Default;
    }
    private void toolBarItem_Cut_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedRtf != "") 
      {
        Clipboard.SetDataObject(this.richTextBox.SelectedRtf, false);
      }
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_Copy_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedRtf != "") 
        Clipboard.SetDataObject(this.richTextBox.SelectedRtf, false);
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_Paste_Click(object sender, System.EventArgs e)
    {
      IDataObject iData = Clipboard.GetDataObject();
      this.richTextBox.Rtf = (string)iData.GetData(DataFormats.Rtf); 
    }

    private void toolBarItem_Undo_Click(object sender, System.EventArgs e)
    {
      this.richTextBox.Undo();
    }

    private void toolBarItem_Redo_Click(object sender, System.EventArgs e)
    {
      this.richTextBox.Redo();
    }

    private void toolBarItem_Bold_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
      {
        if ((this.richTextBox.SelectionFont.Style & FontStyle.Bold) != FontStyle.Bold)
          this.richTextBox.SelectionFont = new Font(this.richTextBox.SelectionFont.FontFamily, this.richTextBox.SelectionFont.Size, this.richTextBox.SelectionFont.Style | FontStyle.Bold);
        else
          this.richTextBox.SelectionFont = new Font(this.richTextBox.SelectionFont.FontFamily, this.richTextBox.SelectionFont.Size, this.richTextBox.SelectionFont.Style ^ FontStyle.Bold);
      }
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_Italic_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
      {
        if ((this.richTextBox.SelectionFont.Style & FontStyle.Italic) != FontStyle.Italic)
          this.richTextBox.SelectionFont = new Font(this.richTextBox.SelectionFont, this.richTextBox.SelectionFont.Style | FontStyle.Italic);
        else
          this.richTextBox.SelectionFont = new Font(this.richTextBox.SelectionFont, this.richTextBox.SelectionFont.Style ^ FontStyle.Italic);
      }
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_Underline_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
      {
        if ((this.richTextBox.SelectionFont.Style & FontStyle.Underline) != FontStyle.Underline)
          this.richTextBox.SelectionFont = new Font(this.richTextBox.SelectionFont, this.richTextBox.SelectionFont.Style | FontStyle.Underline);
        else
          this.richTextBox.SelectionFont = new Font(this.richTextBox.SelectionFont, this.richTextBox.SelectionFont.Style ^ FontStyle.Underline);
      }
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_Strikeout_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
      {
        if ((this.richTextBox.SelectionFont.Style & FontStyle.Strikeout) != FontStyle.Strikeout)
          this.richTextBox.SelectionFont = new Font(this.richTextBox.SelectionFont, this.richTextBox.SelectionFont.Style | FontStyle.Strikeout);
        else
          this.richTextBox.SelectionFont = new Font(this.richTextBox.SelectionFont, this.richTextBox.SelectionFont.Style ^ FontStyle.Strikeout);
      }
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_Sub_Changed(object sender, System.EventArgs e)
    {
      this.richTextBox.SelectionCharOffset = 0;
      if (this.richTextBox.SelectedText != "") 
        this.richTextBox.SelectionCharOffset = this.richTextBox.SelectionCharOffset - 6;
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_Sup_Changed(object sender, System.EventArgs e)
    {
      this.richTextBox.SelectionCharOffset = 0;
      if (this.richTextBox.SelectedText != "") 
        this.richTextBox.SelectionCharOffset = this.richTextBox.SelectionCharOffset + 6;
      else
        ShowMessage("No text selected!");
    }
    private void toolBarItem_Baseline_Changed(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
        this.richTextBox.SelectionCharOffset = 0;
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_Font_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
      {
        this.fontDialog.Font = new Font(this.fontFamilySelected, this.fontSizeSelected, FontStyle.Regular);
        if (this.fontDialog.ShowDialog() == DialogResult.OK) 
          this.richTextBox.SelectionFont = new Font(this.fontDialog.Font.FontFamily, this.fontDialog.Font.Size, this.richTextBox.SelectionFont.Style | this.fontDialog.Font.Style);
      }
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_FontColor_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
      {
        this.colorDialog.Color = Color.Black;
        if (this.colorDialog.ShowDialog() == DialogResult.OK) 
          this.richTextBox.SelectionColor = this.colorDialog.Color;
      }
      else
        ShowMessage("No text selected!");
    }
    private void toolBarItem_ALeft_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
        this.richTextBox.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Left;
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_ACenter_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
      {
        if ((this.richTextBox.SelectionAlignment & System.Windows.Forms.HorizontalAlignment.Center) != System.Windows.Forms.HorizontalAlignment.Center)
          this.richTextBox.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;
        else
          this.richTextBox.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Left;
      }
      else
        ShowMessage("No text selected!");
    }

    private void toolBarItem_ARight_Click(object sender, System.EventArgs e)
    {
      if (this.richTextBox.SelectedText != "") 
      {
        if ((this.richTextBox.SelectionAlignment & System.Windows.Forms.HorizontalAlignment.Right) != System.Windows.Forms.HorizontalAlignment.Right)
          this.richTextBox.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Right;
        else
          this.richTextBox.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Left;
      }
      else
        ShowMessage("No text selected!");
    }

    #endregion

    #region Mans
    public void SetText(string txt) 
    {
      this.richTextBox.Rtf = ((txt == "") ? "" : txt + "\0");
    }

    public string getRtf() 
    {
      return this.richTextBox.Rtf;
    }
    public void setText() 
    {
      this.richTextBox.Text = "";
    }
    public string getText() 
    {
      return this.richTextBox.Text;
    }
    private void menuItem19_Click(object sender, System.EventArgs e)
    {
      this.richTextBox.WordWrap = !this.richTextBox.WordWrap;
    }
    #endregion

    #region Message
    private void ShowMessage(string txt) 
    {
      MessageBox.Show(this, txt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
    }
    #endregion

    #region Events
    private void richTextBox_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(e.LinkText);
    }
    #endregion

	}
}
