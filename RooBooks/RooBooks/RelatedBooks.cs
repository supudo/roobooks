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
	/// Summary description for RooBooks_RelatedBooks.
	/// </summary>
	public class RelatedBooks : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Button button_View;
    private System.Windows.Forms.Button button_Save;
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.TreeView treeView_RB;
    private System.Windows.Forms.Label label_RB;
    private System.ComponentModel.Container components = null;
    private System.Windows.Forms.Form parentForm;
    private System.Windows.Forms.GroupBox groupBox_RelatedBooks;
    private Settings rbSettings = null;
    
    private DB worker = null;

    private string appPath = "";
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

		public RelatedBooks(System.Windows.Forms.Form pf)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
      //
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RelatedBooks));
      this.groupBox_RelatedBooks = new System.Windows.Forms.GroupBox();
      this.treeView_RB = new System.Windows.Forms.TreeView();
      this.label_RB = new System.Windows.Forms.Label();
      this.button_View = new System.Windows.Forms.Button();
      this.button_Save = new System.Windows.Forms.Button();
      this.button_Cancel = new System.Windows.Forms.Button();
      this.groupBox_RelatedBooks.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox_RelatedBooks
      // 
      this.groupBox_RelatedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_RelatedBooks.Controls.Add(this.treeView_RB);
      this.groupBox_RelatedBooks.Controls.Add(this.label_RB);
      this.groupBox_RelatedBooks.Location = new System.Drawing.Point(11, 12);
      this.groupBox_RelatedBooks.Name = "groupBox_RelatedBooks";
      this.groupBox_RelatedBooks.Size = new System.Drawing.Size(280, 376);
      this.groupBox_RelatedBooks.TabIndex = 1;
      this.groupBox_RelatedBooks.TabStop = false;
      this.groupBox_RelatedBooks.Text = "Related books for :";
      // 
      // treeView_RB
      // 
      this.treeView_RB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.treeView_RB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.treeView_RB.CheckBoxes = true;
      this.treeView_RB.ImageIndex = -1;
      this.treeView_RB.Location = new System.Drawing.Point(12, 64);
      this.treeView_RB.Name = "treeView_RB";
      this.treeView_RB.SelectedImageIndex = -1;
      this.treeView_RB.Size = new System.Drawing.Size(256, 296);
      this.treeView_RB.TabIndex = 1;
      this.treeView_RB.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_RB_AfterCheck);
      this.treeView_RB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_RB_AfterSelect);
      // 
      // label_RB
      // 
      this.label_RB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.label_RB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label_RB.Location = new System.Drawing.Point(12, 28);
      this.label_RB.Name = "label_RB";
      this.label_RB.Size = new System.Drawing.Size(256, 24);
      this.label_RB.TabIndex = 0;
      this.label_RB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // button_View
      // 
      this.button_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_View.Enabled = false;
      this.button_View.Location = new System.Drawing.Point(111, 398);
      this.button_View.Name = "button_View";
      this.button_View.Size = new System.Drawing.Size(52, 24);
      this.button_View.TabIndex = 6;
      this.button_View.Text = "View";
      this.button_View.Click += new System.EventHandler(this.button_View_Click);
      // 
      // button_Save
      // 
      this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_Save.Location = new System.Drawing.Point(175, 398);
      this.button_Save.Name = "button_Save";
      this.button_Save.Size = new System.Drawing.Size(52, 24);
      this.button_Save.TabIndex = 5;
      this.button_Save.Text = "Save";
      this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
      // 
      // button_Cancel
      // 
      this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_Cancel.Location = new System.Drawing.Point(239, 398);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(52, 24);
      this.button_Cancel.TabIndex = 4;
      this.button_Cancel.Text = "Cancel";
      this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
      // 
      // RooBooks_RelatedBooks
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(302, 431);
      this.Controls.Add(this.button_View);
      this.Controls.Add(this.button_Save);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.groupBox_RelatedBooks);
      this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RooBooks_RelatedBooks";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Related Books";
      this.Load += new System.EventHandler(this.RooBooks_RelatedBooks_Load);
      this.groupBox_RelatedBooks.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

    private void RooBooks_RelatedBooks_Load(object sender, System.EventArgs e)
    {
      try 
      {
        this.rbSettings = new Settings();
        this.worker = new DB();
        DataTable dt = this.worker.GetBookData(this.BookID);
        this.label_RB.Text = dt.Rows[0]["BookTitle"].ToString();
        LoadSettings();
        PopulateRelatedBooks();
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
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

    private void PopulateRelatedBooks() 
    {
      try 
      {
        this.treeView_RB.Nodes.Clear();

        DataTable dta = this.worker.GetRelatedBooks(this.BookID);
        SortedList ids = new SortedList();
        foreach (DataRow dr in dta.Rows) 
        {
          ids.Add(dr["DestinationBookID"].ToString(), dr["RelatedBookID"].ToString());
        }
        this.treeView_RB.Nodes.Clear();

        DataTable dt = this.worker.GetCategoriesTree();

        TreeNode rootNode = new TreeNode("Select Related Books");
        rootNode.Tag = "Category@0";
        this.treeView_RB.Nodes.Add(rootNode);

        SortedList alreadyAdded = new SortedList();
        alreadyAdded.Add("BookID@" + this.BookID, "CURRENT BOOK");

        DataRow[] rows = dt.Select("ParentID = 0", "CategoryName");
        foreach (DataRow row in rows) 
        {
          if (!alreadyAdded.ContainsKey("Category@" + row["CategoryID"].ToString())) 
          {
            TreeNode item = new TreeNode();
            item.Tag = "CategoryID@" + row["CategoryID"].ToString();

            bool allChecked = true;
            int authorsCount = 0;
            DataRow[] rowsAuthors = dt.Select("AuthorCategoryID = " + row["CategoryID"].ToString(), "FirstName, LastName");
            foreach (DataRow rowAuthor in rowsAuthors) 
            {
              if (!alreadyAdded.ContainsKey("Author@" + rowAuthor["AuthorID"].ToString()) )
              {
                string authorName = rowAuthor["FirstName"].ToString() + " " + rowAuthor["LastName"].ToString();

                TreeNode itemAuthor = new TreeNode();
                itemAuthor.Tag = "AuthorID@" + rowAuthor["AuthorID"].ToString();
                alreadyAdded.Add("Author@" + rowAuthor["AuthorID"].ToString(), authorName);

                bool allCheckedBooks = true;
                int booksCounter = 0;
                DataRow[] rowsBooks = dt.Select("BookAuthorID = " + rowAuthor["AuthorID"].ToString(), "BookTitle");
                if (rowsBooks.Length == 0)
                  allCheckedBooks = false;
                foreach (DataRow rowBook in rowsBooks) 
                {
                  if (!alreadyAdded.ContainsKey("Book@" + rowBook["BookID"].ToString()) )
                  {
                    TreeNode itemBook = new TreeNode();
                    itemBook.Text = rowBook["BookTitle"].ToString();
                    itemBook.Tag = "BookID@" + rowBook["BookID"].ToString();
                    if (ids.ContainsKey(rowBook["BookID"].ToString())) 
                      itemBook.Checked = true;
                    else 
                    {
                      itemBook.Checked = false;
                      allCheckedBooks = false;
                    }
                    booksCounter++;
                    alreadyAdded.Add("Book@" + rowBook["BookID"].ToString(), rowBook["BookTitle"].ToString());
                    itemAuthor.Nodes.Add(itemBook);
                  }
                }
                string subTextBook = ((booksCounter == 1) ? "1 Book" : ((booksCounter == 0) ? "No Books" : booksCounter + " Books"));
                itemAuthor.Text = authorName.Trim() + " (" + subTextBook + ")";
                itemAuthor.ForeColor = Color.Gray;
                itemAuthor.Checked = allCheckedBooks;
                if (!allCheckedBooks)
                  allChecked = false;
                item.Nodes.Add(itemAuthor);
                authorsCount++;
              }
            }
            string subTextAuthor = ((authorsCount == 1) ? "1 Author" : ((authorsCount == 0) ? "No Authors" : authorsCount + " Authors"));
            item.Text = row["CategoryName"].ToString() + " (" + subTextAuthor + ")";
            item.ForeColor = Color.Gray;
            item.Checked = allChecked;
            alreadyAdded.Add("Category@" + row["CategoryID"].ToString(), row["CategoryName"].ToString());

            rootNode.Nodes.Add(item);

            DataRow[] subRows = dt.Select("ParentID = " + row["CategoryID"].ToString());
            if (subRows.Length > 0)
              PopulateSubCategories(item, dt, subRows, alreadyAdded, ids);
          }
        }

        rootNode.Expand();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void PopulateSubCategories(TreeNode node, DataTable dt, DataRow[] rows, SortedList alreadyAdded, SortedList ids) 
    {
      try 
      {
        foreach (DataRow row in rows) 
        {
          if (!alreadyAdded.ContainsKey("Category@" + row["CategoryID"].ToString())) 
          {
            TreeNode item = new TreeNode();
            item.Tag = "CategoryID@" + row["CategoryID"].ToString();

            bool allChecked = true;
            int authorsCount = 0;
            DataRow[] rowsAuthors = dt.Select("AuthorCategoryID = " + row["CategoryID"]);
            foreach (DataRow rowAuthor in rowsAuthors) 
            {
              if (!alreadyAdded.ContainsKey("Author@" + rowAuthor["AuthorID"].ToString()) )
              {
                string authorName = rowAuthor["FirstName"].ToString() + " " + rowAuthor["LastName"].ToString();

                TreeNode itemAuthor = new TreeNode();
                itemAuthor.Tag = "AuthorID@" + rowAuthor["AuthorID"].ToString();
                alreadyAdded.Add("Author@" + rowAuthor["AuthorID"].ToString(), authorName);

                bool allCheckedBooks = true;
                int booksCounter = 0;
                DataRow[] rowsBooks = dt.Select("BookAuthorID = " + rowAuthor["AuthorID"].ToString(), "BookTitle");
                if (rowsBooks.Length == 0)
                  allCheckedBooks = false;
                foreach (DataRow rowBook in rowsBooks) 
                {
                  if (!alreadyAdded.ContainsKey("Book@" + rowBook["BookID"].ToString())) 
                  {
                    TreeNode itemBook = new TreeNode();
                    itemBook.Text = rowBook["BookTitle"].ToString();
                    itemBook.Tag = "BookID@" + rowBook["BookID"].ToString();
                    if (ids.ContainsKey(rowBook["BookID"].ToString())) 
                      itemBook.Checked = true;
                    else 
                    {
                      itemBook.Checked = false;
                      allCheckedBooks = false;
                    }
                    booksCounter++;
                    alreadyAdded.Add("Book@" + rowBook["BookID"].ToString(), rowBook["BookTitle"].ToString());
                    itemAuthor.Nodes.Add(itemBook);
                  }
                }
                string subTextBook = ((booksCounter == 1) ? "1 Book" : ((booksCounter == 0) ? "No Books" : booksCounter + " Books"));
                itemAuthor.Text = authorName.Trim() + " (" + subTextBook + ")";
                itemAuthor.ForeColor = Color.Gray;
                itemAuthor.Checked = allCheckedBooks;
                if (!allCheckedBooks)
                  allChecked = false;
                item.Nodes.Add(itemAuthor);
                authorsCount++;
              }
            }
            string subTextAuthor = ((authorsCount == 1) ? "1 Author" : ((authorsCount == 0) ? "No Authors" : authorsCount + " Authors"));
            item.Text = row["CategoryName"].ToString() + " (" + subTextAuthor + ")";
            item.ForeColor = Color.Gray;
            item.Checked = allChecked;
            alreadyAdded.Add("Category@" + row["CategoryID"].ToString(), row["CategoryName"].ToString());

            node.Nodes.Add(item);

            DataRow[] subRows = dt.Select("ParentID = " + row["CategoryID"]);
            if (subRows.Length > 0)
              PopulateSubCategories(item, dt, subRows, alreadyAdded, ids);
          }
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void button_View_Click(object sender, System.EventArgs e)
    {
      if (this.treeView_RB.SelectedNode != null) 
        ((RooBooks)this.parentForm).ShowRelatedBookData(int.Parse(this.treeView_RB.SelectedNode.Tag.ToString().Replace("BookID@", "")));
      button_Cancel_Click(null, null);
    }

    private void button_Save_Click(object sender, System.EventArgs e)
    {
      try 
      {
        this.worker.RemoveRelatedBooks(this.BookID);
        foreach (TreeNode node in this.treeView_RB.Nodes) 
        {
          if (node.Checked) 
          {
            string destID = node.Tag.ToString();
            if (destID.StartsWith("BookID@") && int.Parse(destID.Replace("BookID@", "")) != this.BookID)
              this.worker.AddRelatedBook(this.BookID, int.Parse(destID.Replace("BookID@", "")));
          }
          if (node.Nodes.Count > 0)
            RecursiveAddRelatedBooks(node);
        }
        button_Cancel_Click(null, null);
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void RecursiveAddRelatedBooks(TreeNode node) 
    {
      try 
      {
        foreach (TreeNode sub in node.Nodes) 
        {
          Console.WriteLine(node.Text);
          if (sub.Checked) 
          {
            string destID = sub.Tag.ToString();
            if (destID.StartsWith("BookID@"))
              this.worker.AddRelatedBook(this.BookID, int.Parse(destID.Replace("BookID@", "")));
          }
          if (sub.Nodes.Count > 0)
            RecursiveAddRelatedBooks(sub);
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void button_Cancel_Click(object sender, System.EventArgs e)
    {
      this.Close();
    }

    private void treeView_RB_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
    {
      if (e.Action != TreeViewAction.Unknown) 
      {
        if (e.Node.Tag.ToString().StartsWith("BookID@"))
          this.button_View.Enabled = true;
        else
          this.button_View.Enabled = false;
      }
    }

    private void treeView_RB_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
    {
      if(e.Action != TreeViewAction.Unknown) 
      {
        if (e.Node.Parent != null)
          e.Node.Parent.Checked = e.Node.Checked;
        if (e.Node.Nodes.Count > 0) 
        {
          CheckAllChildNodes(e.Node, e.Node.Checked);
        }
      }
    }
    private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
    {
      foreach (TreeNode node in treeNode.Nodes)
      {
        node.Checked = nodeChecked;
        if(node.Nodes.Count > 0)
          this.CheckAllChildNodes(node, nodeChecked);
      }
    }
    public void MsgError(Exception ex, int errorLevel) 
    {
      string mbText = ((errorLevel == 1) ? ex.Message : ex.StackTrace);
      string mbCaption = "Exception occured";
      MessageBox.Show(this, mbText, mbCaption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }


	}
}
