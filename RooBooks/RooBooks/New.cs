using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using RooBooks.Library;

namespace RooBooks.UI
{
	/// <summary>
	/// Summary description for RooBooks_New.
	/// </summary>
	public class New : System.Windows.Forms.Form
  {
    private System.Windows.Forms.Label label_TopHeader;
    private System.Windows.Forms.Panel panel_Category;
    private System.Windows.Forms.Panel panel_Author;
    private System.Windows.Forms.Panel panel_Book;
    private System.Windows.Forms.GroupBox groupBox_Header_Delimiter;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox_CategoryName;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button_Cancel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBox_FirstName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox_LastName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button button_OK1;
    private System.Windows.Forms.Button button_OK2;
    private System.Windows.Forms.Button button_Cancel2;
    private System.Windows.Forms.Button button_OK3;
    private System.Windows.Forms.Button button_Cancel3;
    private System.Windows.Forms.TextBox textBox_BookTitle;
    private System.Windows.Forms.Form parentForm;
    private Settings rbSettings = null;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox comboBox_BD_Genres;
    private System.Windows.Forms.Panel panel_Choice;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckBox checkBox_Category;
    private System.Windows.Forms.CheckBox checkBox_Author;
    private System.Windows.Forms.CheckBox checkBox_Book;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button button_Next;
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.Button button_Back1;
    private DB worker = null;
    private SortedList bookGenres = null;

    private string whatIs = "";
    public string WhatIs 
    {
      get 
      {
        return whatIs;
      }
      set 
      {
        whatIs = value;
      }
    }

    private bool fromScratch = false;
    public bool FromScratch 
    {
      get 
      {
        return fromScratch;
      }
      set 
      {
        fromScratch = value;
      }
    }

    private int parentID = 0;
    public int ParentID 
    {
      get 
      {
        return parentID;
      }
      set 
      {
        parentID = value;
      }
    }

    private string appPath = "";
    private System.Windows.Forms.Button button_Back2;
    private System.Windows.Forms.Button button_Back3;
  
    public string AppPath 
    {
      get 
      {
        return appPath;
      }
      set 
      {
        appPath = value;
      }
    }
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public New(System.Windows.Forms.Form pf, string what)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

      this.WhatIs = what;
      this.parentForm = pf;
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(New));
      this.panel_Category = new System.Windows.Forms.Panel();
      this.button_Back2 = new System.Windows.Forms.Button();
      this.button_OK1 = new System.Windows.Forms.Button();
      this.button_Cancel1 = new System.Windows.Forms.Button();
      this.textBox_CategoryName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label_TopHeader = new System.Windows.Forms.Label();
      this.groupBox_Header_Delimiter = new System.Windows.Forms.GroupBox();
      this.panel_Author = new System.Windows.Forms.Panel();
      this.button_Back1 = new System.Windows.Forms.Button();
      this.textBox_LastName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button_OK3 = new System.Windows.Forms.Button();
      this.button_Cancel3 = new System.Windows.Forms.Button();
      this.textBox_FirstName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.panel_Book = new System.Windows.Forms.Panel();
      this.button_Back3 = new System.Windows.Forms.Button();
      this.comboBox_BD_Genres = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.button_OK2 = new System.Windows.Forms.Button();
      this.button_Cancel2 = new System.Windows.Forms.Button();
      this.textBox_BookTitle = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.panel_Choice = new System.Windows.Forms.Panel();
      this.button_Next = new System.Windows.Forms.Button();
      this.button_Cancel = new System.Windows.Forms.Button();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.checkBox_Book = new System.Windows.Forms.CheckBox();
      this.checkBox_Author = new System.Windows.Forms.CheckBox();
      this.checkBox_Category = new System.Windows.Forms.CheckBox();
      this.label6 = new System.Windows.Forms.Label();
      this.panel_Category.SuspendLayout();
      this.panel_Author.SuspendLayout();
      this.panel_Book.SuspendLayout();
      this.panel_Choice.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel_Category
      // 
      this.panel_Category.Controls.Add(this.button_Back2);
      this.panel_Category.Controls.Add(this.button_OK1);
      this.panel_Category.Controls.Add(this.button_Cancel1);
      this.panel_Category.Controls.Add(this.textBox_CategoryName);
      this.panel_Category.Controls.Add(this.label1);
      this.panel_Category.Controls.Add(this.groupBox1);
      this.panel_Category.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Category.Location = new System.Drawing.Point(0, 48);
      this.panel_Category.Name = "panel_Category";
      this.panel_Category.Size = new System.Drawing.Size(510, 191);
      this.panel_Category.TabIndex = 0;
      // 
      // button_Back2
      // 
      this.button_Back2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_Back2.Location = new System.Drawing.Point(237, 147);
      this.button_Back2.Name = "button_Back2";
      this.button_Back2.Size = new System.Drawing.Size(76, 24);
      this.button_Back2.TabIndex = 14;
      this.button_Back2.Text = "< Back";
      this.button_Back2.Click += new System.EventHandler(this.button_Back_Click);
      // 
      // button_OK1
      // 
      this.button_OK1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_OK1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_OK1.Location = new System.Drawing.Point(326, 147);
      this.button_OK1.Name = "button_OK1";
      this.button_OK1.Size = new System.Drawing.Size(76, 24);
      this.button_OK1.TabIndex = 2;
      this.button_OK1.Text = "OK";
      this.button_OK1.Click += new System.EventHandler(this.SaveItem);
      // 
      // button_Cancel1
      // 
      this.button_Cancel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_Cancel1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_Cancel1.Location = new System.Drawing.Point(414, 147);
      this.button_Cancel1.Name = "button_Cancel1";
      this.button_Cancel1.Size = new System.Drawing.Size(76, 24);
      this.button_Cancel1.TabIndex = 3;
      this.button_Cancel1.Text = "Cancel";
      this.button_Cancel1.Click += new System.EventHandler(this.DiscardItem);
      // 
      // textBox_CategoryName
      // 
      this.textBox_CategoryName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.textBox_CategoryName.Location = new System.Drawing.Point(116, 16);
      this.textBox_CategoryName.MaxLength = 255;
      this.textBox_CategoryName.Name = "textBox_CategoryName";
      this.textBox_CategoryName.Size = new System.Drawing.Size(336, 20);
      this.textBox_CategoryName.TabIndex = 1;
      this.textBox_CategoryName.Text = "";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Category Name";
      // 
      // groupBox1
      // 
      this.groupBox1.Location = new System.Drawing.Point(-100, 128);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(700, 4);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      // 
      // label_TopHeader
      // 
      this.label_TopHeader.BackColor = System.Drawing.SystemColors.Window;
      this.label_TopHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.label_TopHeader.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_TopHeader.Location = new System.Drawing.Point(0, 0);
      this.label_TopHeader.Name = "label_TopHeader";
      this.label_TopHeader.Size = new System.Drawing.Size(510, 48);
      this.label_TopHeader.TabIndex = 1;
      this.label_TopHeader.Text = "   New";
      this.label_TopHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // groupBox_Header_Delimiter
      // 
      this.groupBox_Header_Delimiter.Location = new System.Drawing.Point(-12, 48);
      this.groupBox_Header_Delimiter.Name = "groupBox_Header_Delimiter";
      this.groupBox_Header_Delimiter.Size = new System.Drawing.Size(700, 4);
      this.groupBox_Header_Delimiter.TabIndex = 2;
      this.groupBox_Header_Delimiter.TabStop = false;
      // 
      // panel_Author
      // 
      this.panel_Author.Controls.Add(this.button_Back1);
      this.panel_Author.Controls.Add(this.textBox_LastName);
      this.panel_Author.Controls.Add(this.label3);
      this.panel_Author.Controls.Add(this.button_OK3);
      this.panel_Author.Controls.Add(this.button_Cancel3);
      this.panel_Author.Controls.Add(this.textBox_FirstName);
      this.panel_Author.Controls.Add(this.label2);
      this.panel_Author.Controls.Add(this.groupBox2);
      this.panel_Author.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Author.Location = new System.Drawing.Point(0, 48);
      this.panel_Author.Name = "panel_Author";
      this.panel_Author.Size = new System.Drawing.Size(510, 191);
      this.panel_Author.TabIndex = 3;
      // 
      // button_Back1
      // 
      this.button_Back1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_Back1.Location = new System.Drawing.Point(237, 147);
      this.button_Back1.Name = "button_Back1";
      this.button_Back1.Size = new System.Drawing.Size(76, 24);
      this.button_Back1.TabIndex = 13;
      this.button_Back1.Text = "< Back";
      this.button_Back1.Click += new System.EventHandler(this.button_Back_Click);
      // 
      // textBox_LastName
      // 
      this.textBox_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_LastName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.textBox_LastName.Location = new System.Drawing.Point(88, 16);
      this.textBox_LastName.MaxLength = 255;
      this.textBox_LastName.Name = "textBox_LastName";
      this.textBox_LastName.Size = new System.Drawing.Size(330, 20);
      this.textBox_LastName.TabIndex = 2;
      this.textBox_LastName.Text = "";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label3.Location = new System.Drawing.Point(12, 56);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 23);
      this.label3.TabIndex = 10;
      this.label3.Text = "Last Name";
      // 
      // button_OK3
      // 
      this.button_OK3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_OK3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_OK3.Location = new System.Drawing.Point(326, 147);
      this.button_OK3.Name = "button_OK3";
      this.button_OK3.Size = new System.Drawing.Size(76, 24);
      this.button_OK3.TabIndex = 3;
      this.button_OK3.Text = "OK";
      this.button_OK3.Click += new System.EventHandler(this.SaveItem);
      // 
      // button_Cancel3
      // 
      this.button_Cancel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_Cancel3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_Cancel3.Location = new System.Drawing.Point(414, 147);
      this.button_Cancel3.Name = "button_Cancel3";
      this.button_Cancel3.Size = new System.Drawing.Size(76, 24);
      this.button_Cancel3.TabIndex = 4;
      this.button_Cancel3.Text = "Cancel";
      this.button_Cancel3.Click += new System.EventHandler(this.DiscardItem);
      // 
      // textBox_FirstName
      // 
      this.textBox_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_FirstName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.textBox_FirstName.Location = new System.Drawing.Point(88, 56);
      this.textBox_FirstName.MaxLength = 255;
      this.textBox_FirstName.Name = "textBox_FirstName";
      this.textBox_FirstName.Size = new System.Drawing.Size(330, 20);
      this.textBox_FirstName.TabIndex = 1;
      this.textBox_FirstName.Text = "";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label2.Location = new System.Drawing.Point(12, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 23);
      this.label2.TabIndex = 5;
      this.label2.Text = "First Name";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Location = new System.Drawing.Point(-100, 128);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(694, 4);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      // 
      // panel_Book
      // 
      this.panel_Book.Controls.Add(this.button_Back3);
      this.panel_Book.Controls.Add(this.comboBox_BD_Genres);
      this.panel_Book.Controls.Add(this.label5);
      this.panel_Book.Controls.Add(this.button_OK2);
      this.panel_Book.Controls.Add(this.button_Cancel2);
      this.panel_Book.Controls.Add(this.textBox_BookTitle);
      this.panel_Book.Controls.Add(this.label4);
      this.panel_Book.Controls.Add(this.groupBox3);
      this.panel_Book.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Book.Location = new System.Drawing.Point(0, 48);
      this.panel_Book.Name = "panel_Book";
      this.panel_Book.Size = new System.Drawing.Size(510, 191);
      this.panel_Book.TabIndex = 4;
      // 
      // button_Back3
      // 
      this.button_Back3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_Back3.Location = new System.Drawing.Point(237, 147);
      this.button_Back3.Name = "button_Back3";
      this.button_Back3.Size = new System.Drawing.Size(76, 24);
      this.button_Back3.TabIndex = 14;
      this.button_Back3.Text = "< Back";
      this.button_Back3.Click += new System.EventHandler(this.button_Back_Click);
      // 
      // comboBox_BD_Genres
      // 
      this.comboBox_BD_Genres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox_BD_Genres.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.comboBox_BD_Genres.ItemHeight = 16;
      this.comboBox_BD_Genres.Location = new System.Drawing.Point(88, 56);
      this.comboBox_BD_Genres.Name = "comboBox_BD_Genres";
      this.comboBox_BD_Genres.Size = new System.Drawing.Size(166, 24);
      this.comboBox_BD_Genres.TabIndex = 2;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label5.Location = new System.Drawing.Point(12, 56);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(64, 23);
      this.label5.TabIndex = 10;
      this.label5.Text = "Genre";
      // 
      // button_OK2
      // 
      this.button_OK2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_OK2.Location = new System.Drawing.Point(326, 147);
      this.button_OK2.Name = "button_OK2";
      this.button_OK2.Size = new System.Drawing.Size(76, 24);
      this.button_OK2.TabIndex = 3;
      this.button_OK2.Text = "OK";
      this.button_OK2.Click += new System.EventHandler(this.SaveItem);
      // 
      // button_Cancel2
      // 
      this.button_Cancel2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_Cancel2.Location = new System.Drawing.Point(414, 147);
      this.button_Cancel2.Name = "button_Cancel2";
      this.button_Cancel2.Size = new System.Drawing.Size(76, 24);
      this.button_Cancel2.TabIndex = 4;
      this.button_Cancel2.Text = "Cancel";
      this.button_Cancel2.Click += new System.EventHandler(this.DiscardItem);
      // 
      // textBox_BookTitle
      // 
      this.textBox_BookTitle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.textBox_BookTitle.Location = new System.Drawing.Point(88, 16);
      this.textBox_BookTitle.MaxLength = 255;
      this.textBox_BookTitle.Name = "textBox_BookTitle";
      this.textBox_BookTitle.Size = new System.Drawing.Size(336, 20);
      this.textBox_BookTitle.TabIndex = 1;
      this.textBox_BookTitle.Text = "";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label4.Location = new System.Drawing.Point(12, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(64, 23);
      this.label4.TabIndex = 5;
      this.label4.Text = "Book Title";
      // 
      // groupBox3
      // 
      this.groupBox3.Location = new System.Drawing.Point(-100, 128);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(700, 4);
      this.groupBox3.TabIndex = 8;
      this.groupBox3.TabStop = false;
      // 
      // panel_Choice
      // 
      this.panel_Choice.Controls.Add(this.button_Next);
      this.panel_Choice.Controls.Add(this.button_Cancel);
      this.panel_Choice.Controls.Add(this.groupBox4);
      this.panel_Choice.Controls.Add(this.checkBox_Book);
      this.panel_Choice.Controls.Add(this.checkBox_Author);
      this.panel_Choice.Controls.Add(this.checkBox_Category);
      this.panel_Choice.Controls.Add(this.label6);
      this.panel_Choice.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Choice.Location = new System.Drawing.Point(0, 48);
      this.panel_Choice.Name = "panel_Choice";
      this.panel_Choice.Size = new System.Drawing.Size(510, 191);
      this.panel_Choice.TabIndex = 11;
      // 
      // button_Next
      // 
      this.button_Next.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_Next.Location = new System.Drawing.Point(321, 147);
      this.button_Next.Name = "button_Next";
      this.button_Next.Size = new System.Drawing.Size(76, 24);
      this.button_Next.TabIndex = 9;
      this.button_Next.Text = "Next >";
      this.button_Next.Click += new System.EventHandler(this.button1_Click);
      // 
      // button_Cancel
      // 
      this.button_Cancel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_Cancel.Location = new System.Drawing.Point(414, 147);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(76, 24);
      this.button_Cancel.TabIndex = 10;
      this.button_Cancel.Text = "Cancel";
      this.button_Cancel.Click += new System.EventHandler(this.button2_Click);
      // 
      // groupBox4
      // 
      this.groupBox4.Location = new System.Drawing.Point(-100, 128);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(700, 4);
      this.groupBox4.TabIndex = 11;
      this.groupBox4.TabStop = false;
      // 
      // checkBox_Book
      // 
      this.checkBox_Book.Location = new System.Drawing.Point(12, 88);
      this.checkBox_Book.Name = "checkBox_Book";
      this.checkBox_Book.TabIndex = 3;
      this.checkBox_Book.Text = "Book";
      this.checkBox_Book.Click += new System.EventHandler(this.checkBox_Book_Click);
      // 
      // checkBox_Author
      // 
      this.checkBox_Author.Location = new System.Drawing.Point(12, 64);
      this.checkBox_Author.Name = "checkBox_Author";
      this.checkBox_Author.TabIndex = 2;
      this.checkBox_Author.Text = "Author";
      this.checkBox_Author.Click += new System.EventHandler(this.checkBox_Author_Click);
      // 
      // checkBox_Category
      // 
      this.checkBox_Category.Location = new System.Drawing.Point(12, 40);
      this.checkBox_Category.Name = "checkBox_Category";
      this.checkBox_Category.TabIndex = 1;
      this.checkBox_Category.Text = "Category";
      this.checkBox_Category.Click += new System.EventHandler(this.checkBox_Category_Click);
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(12, 16);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(104, 24);
      this.label6.TabIndex = 0;
      this.label6.Text = "Add new ...";
      // 
      // New
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(510, 239);
      this.Controls.Add(this.panel_Author);
      this.Controls.Add(this.panel_Book);
      this.Controls.Add(this.panel_Category);
      this.Controls.Add(this.panel_Choice);
      this.Controls.Add(this.groupBox_Header_Delimiter);
      this.Controls.Add(this.label_TopHeader);
      this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "New";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "New";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RooBooks_New_KeyDown);
      this.Load += new System.EventHandler(this.New_Load);
      this.panel_Category.ResumeLayout(false);
      this.panel_Author.ResumeLayout(false);
      this.panel_Book.ResumeLayout(false);
      this.panel_Choice.ResumeLayout(false);
      this.ResumeLayout(false);

    }
    #endregion

    private void New_Load(object sender, System.EventArgs e)
    {
      try 
      {
        this.rbSettings = new Settings();
        this.worker = new DB();
        this.bookGenres = new SortedList();
        LoadSettings();
        SetNewProperties();
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
          if (c.Name == "label_TopHeader")
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

    private void SetNewProperties() 
    {
      this.button_Back1.Visible = false;
      this.button_Back2.Visible = false;
      this.button_Back3.Visible = false;
      if (this.WhatIs == "choice") 
      {
        this.panel_Category.Visible = false;
        this.panel_Author.Visible = false;
        this.panel_Book.Visible = false;
        this.panel_Choice.Visible = true;
        this.label_TopHeader.Text = "  New ...";
        this.label_TopHeader.TextAlign = ContentAlignment.MiddleLeft;
        this.FromScratch = true;
      }
      else if (this.WhatIs == "category") 
      {
        this.panel_Category.Visible = true;
        this.panel_Author.Visible = false;
        this.panel_Book.Visible = false;
        this.panel_Choice.Visible = false;
        this.label_TopHeader.Text = "  New Category";
        this.label_TopHeader.TextAlign = ContentAlignment.MiddleLeft;
        if (this.FromScratch)
          this.button_Back2.Visible = true;
      }
      else if (this.WhatIs == "author") 
      {
        this.panel_Category.Visible = false;
        this.panel_Author.Visible = true;
        this.panel_Book.Visible = false;
        this.panel_Choice.Visible = false;
        this.label_TopHeader.Text = "  New Author";
        this.label_TopHeader.TextAlign = ContentAlignment.MiddleLeft;
        if (this.FromScratch)
          this.button_Back1.Visible = true;
      }
      else if (this.WhatIs == "book") 
      {
        this.panel_Category.Visible = false;
        this.panel_Author.Visible = false;
        this.panel_Book.Visible = true;
        this.panel_Choice.Visible = false;
        this.label_TopHeader.Text = "  New Book";
        this.label_TopHeader.TextAlign = ContentAlignment.MiddleLeft;
        if (this.FromScratch)
          this.button_Back3.Visible = true;
        if (this.comboBox_BD_Genres.Items.Count == 0) 
        {
          DataTable dtg = this.worker.GetBookGenres();
          foreach (DataRow row in dtg.Rows) 
          {
            this.comboBox_BD_Genres.Items.Add(row["GenreTx"].ToString());
            this.bookGenres.Add(row["GenreTx"].ToString(), row["GenreID"].ToString());
          }
        }
      }
    }
    private void SaveItem(object sender, System.EventArgs e) 
    {
      DB db = new DB();
      if (this.WhatIs == "category") 
        db.AddCategoryItem(this.ParentID, this.textBox_CategoryName.Text);
      if (this.WhatIs == "author") 
        db.AddAuthorItem(this.ParentID, this.textBox_FirstName.Text, this.textBox_LastName.Text);
      if (this.WhatIs == "book") 
        db.AddBookItem(this.ParentID, this.textBox_BookTitle.Text, int.Parse(this.bookGenres[this.comboBox_BD_Genres.SelectedItem.ToString()].ToString()));
      ((RooBooks)this.parentForm).contextMenu_Categories_Refresh_Click(null, null);
      this.Close();
    }

    private void DiscardItem(object sender, System.EventArgs e) 
    {
      this.Dispose();
      this.Close();
    }

    private void RooBooks_New_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
    {
      if (e.KeyData == Keys.Escape) 
      {
        this.Close();
      }
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      if (!this.checkBox_Category.Checked && !this.checkBox_Author.Checked && !this.checkBox_Book.Checked) 
      {
        string mbText = "You must choose what do you wish to create!";
        string mbCaption = "New...";
        MessageBox.Show(this, mbText, mbCaption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
      }
      else 
      {
        if (this.checkBox_Category.Checked)
          this.WhatIs = "category";
        if (this.checkBox_Author.Checked)
          this.WhatIs = "author";
        if (this.checkBox_Book.Checked)
          this.WhatIs = "book";
        SetNewProperties();
      }
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      this.Close();
    }

    private void checkBox_Category_Click(object sender, System.EventArgs e)
    {
      this.checkBox_Category.Checked = true;
      this.checkBox_Author.Checked = false;
      this.checkBox_Book.Checked = false;
    }

    private void checkBox_Author_Click(object sender, System.EventArgs e)
    {
      this.checkBox_Category.Checked = false;
      this.checkBox_Author.Checked = true;
      this.checkBox_Book.Checked = false;
    }

    private void checkBox_Book_Click(object sender, System.EventArgs e)
    {
      this.checkBox_Category.Checked = false;
      this.checkBox_Author.Checked = false;
      this.checkBox_Book.Checked = true;
    }

    private void button_Back_Click(object sender, System.EventArgs e)
    {
      this.panel_Category.Visible = false;
      this.panel_Author.Visible = false;
      this.panel_Book.Visible = false;
      this.panel_Choice.Visible = true;
    }
	}
}
