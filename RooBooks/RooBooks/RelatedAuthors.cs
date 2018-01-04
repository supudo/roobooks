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
	/// Summary description for RooBooks_RelatedAuthors.
	/// </summary>
	public class RelatedAuthors : System.Windows.Forms.Form
	{
    private System.Windows.Forms.GroupBox groupBox_RelatedAuthors;
    private System.Windows.Forms.Label label_RA;
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.Button button_Save;
    private System.ComponentModel.IContainer components;
    private System.Windows.Forms.TreeView treeView_RA;
    private System.Windows.Forms.Button button_View;
    private System.Windows.Forms.Form parentForm;
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
    
    private int authorID = 0;
    public int AuthorID 
    {
      get 
      {
        return authorID;
      }
      set 
      {
        authorID = value;
      }
    }

		public RelatedAuthors(System.Windows.Forms.Form pf)
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
		protected override void Dispose(bool disposing)
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
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RelatedAuthors));
      this.groupBox_RelatedAuthors = new System.Windows.Forms.GroupBox();
      this.treeView_RA = new System.Windows.Forms.TreeView();
      this.label_RA = new System.Windows.Forms.Label();
      this.button_Cancel = new System.Windows.Forms.Button();
      this.button_Save = new System.Windows.Forms.Button();
      this.button_View = new System.Windows.Forms.Button();
      this.groupBox_RelatedAuthors.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox_RelatedAuthors
      // 
      this.groupBox_RelatedAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_RelatedAuthors.Controls.Add(this.treeView_RA);
      this.groupBox_RelatedAuthors.Controls.Add(this.label_RA);
      this.groupBox_RelatedAuthors.Location = new System.Drawing.Point(12, 12);
      this.groupBox_RelatedAuthors.Name = "groupBox_RelatedAuthors";
      this.groupBox_RelatedAuthors.Size = new System.Drawing.Size(280, 376);
      this.groupBox_RelatedAuthors.TabIndex = 0;
      this.groupBox_RelatedAuthors.TabStop = false;
      this.groupBox_RelatedAuthors.Text = "Related authors for :";
      // 
      // treeView_RA
      // 
      this.treeView_RA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.treeView_RA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.treeView_RA.CheckBoxes = true;
      this.treeView_RA.ImageIndex = -1;
      this.treeView_RA.Location = new System.Drawing.Point(12, 64);
      this.treeView_RA.Name = "treeView_RA";
      this.treeView_RA.SelectedImageIndex = -1;
      this.treeView_RA.Size = new System.Drawing.Size(256, 296);
      this.treeView_RA.TabIndex = 1;
      this.treeView_RA.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_RA_AfterCheck);
      this.treeView_RA.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_RA_AfterSelect);
      // 
      // label_RA
      // 
      this.label_RA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.label_RA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label_RA.Location = new System.Drawing.Point(12, 28);
      this.label_RA.Name = "label_RA";
      this.label_RA.Size = new System.Drawing.Size(256, 24);
      this.label_RA.TabIndex = 0;
      this.label_RA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // button_Cancel
      // 
      this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_Cancel.Location = new System.Drawing.Point(240, 400);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(52, 24);
      this.button_Cancel.TabIndex = 1;
      this.button_Cancel.Text = "Cancel";
      this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
      // 
      // button_Save
      // 
      this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_Save.Location = new System.Drawing.Point(176, 400);
      this.button_Save.Name = "button_Save";
      this.button_Save.Size = new System.Drawing.Size(52, 24);
      this.button_Save.TabIndex = 2;
      this.button_Save.Text = "Save";
      this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
      // 
      // button_View
      // 
      this.button_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_View.Enabled = false;
      this.button_View.Location = new System.Drawing.Point(112, 400);
      this.button_View.Name = "button_View";
      this.button_View.Size = new System.Drawing.Size(52, 24);
      this.button_View.TabIndex = 3;
      this.button_View.Text = "View";
      this.button_View.Click += new System.EventHandler(this.button_View_Click);
      // 
      // RooBooks_RelatedAuthors
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(304, 433);
      this.Controls.Add(this.button_View);
      this.Controls.Add(this.button_Save);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.groupBox_RelatedAuthors);
      this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RooBooks_RelatedAuthors";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Related Authors";
      this.Load += new System.EventHandler(this.RooBooks_RelatedAuthors_Load);
      this.groupBox_RelatedAuthors.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

    private void RooBooks_RelatedAuthors_Load(object sender, System.EventArgs e)
    {
      try 
      {
        this.rbSettings = new Settings();
        this.worker = new DB();
        DataTable dt = this.worker.GetAuthorData(this.AuthorID);
        string authorName = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
        this.label_RA.Text = authorName.Trim();
        LoadSettings();
        PopulateRelatedAuthors();
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

    private void PopulateRelatedAuthors() 
    {
      try 
      {
        this.treeView_RA.Nodes.Clear();

        DataTable dta = this.worker.GetRelatedAuthors(this.AuthorID);
        SortedList ids = new SortedList();
        foreach (DataRow dr in dta.Rows) 
        {
          ids.Add(dr["DestinationAuthorID"].ToString(), dr["RelatedAuthorsID"].ToString());
        }
        this.treeView_RA.Nodes.Clear();

        DataTable dt = this.worker.GetCategoriesTree();

        TreeNode rootNode = new TreeNode("Select Related Authors");
        rootNode.Tag = "Category@0";
        this.treeView_RA.Nodes.Add(rootNode);

        SortedList alreadyAdded = new SortedList();
        alreadyAdded.Add("AuthorID@" + this.AuthorID, "CURRENT AUTHOR");

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
            if (rowsAuthors.Length == 0)
              allChecked = false;
            foreach (DataRow rowAuthor in rowsAuthors) 
            {
              if (!alreadyAdded.ContainsKey("Author@" + rowAuthor["AuthorID"].ToString()) )
              {
                string raName = rowAuthor["FirstName"].ToString() + " " + rowAuthor["LastName"].ToString();

                TreeNode itemAuthor = new TreeNode();
                itemAuthor.Text = raName.Trim();
                itemAuthor.Tag = "AuthorID@" + rowAuthor["AuthorID"].ToString();
                if (ids.ContainsKey(rowAuthor["AuthorID"].ToString())) 
                  itemAuthor.Checked = true;
                else 
                {
                  itemAuthor.Checked = false;
                  allChecked = false;
                }
                alreadyAdded.Add("Author@" + rowAuthor["AuthorID"].ToString(), raName);
                authorsCount++;
                item.Nodes.Add(itemAuthor);
              }
            }
            string subText = ((authorsCount == 1) ? "1 Author" : ((authorsCount == 0) ? "No Authors" : authorsCount + " Authors"));
            item.Text = row["CategoryName"].ToString() + " (" + subText + ")";
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
            if (rowsAuthors.Length == 0)
              allChecked = false;
            foreach (DataRow rowAuthor in rowsAuthors) 
            {
              if (!alreadyAdded.ContainsKey("Author@" + rowAuthor["AuthorID"].ToString())) 
              {
                string raName = rowAuthor["FirstName"].ToString() + " " + rowAuthor["LastName"].ToString();
                TreeNode itemAuthor = new TreeNode();
                itemAuthor.Text = raName.Trim();
                itemAuthor.Tag = "AuthorID@" + rowAuthor["AuthorID"].ToString();
                if (ids.ContainsKey(rowAuthor["AuthorID"].ToString())) 
                  itemAuthor.Checked = true;
                else 
                {
                  itemAuthor.Checked = false;
                  allChecked = false;
                }
                alreadyAdded.Add("Author@" + rowAuthor["AuthorID"].ToString(), raName);
                authorsCount++;
                item.Nodes.Add(itemAuthor);
              }
            }
            string subText = ((authorsCount == 1) ? "1 Author" : ((authorsCount == 0) ? "No Authors" : authorsCount + " Authors"));
            item.Text = row["CategoryName"].ToString() + " (" + subText + ")";
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

    public void MsgError(Exception ex, int errorLevel) 
    {
      string mbText = ((errorLevel == 1) ? ex.Message : ex.StackTrace);
      string mbCaption = "Exception occured";
      MessageBox.Show(this, mbText, mbCaption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }

    private void button_Cancel_Click(object sender, System.EventArgs e)
    {
      this.Close();
    }

    private void button_Save_Click(object sender, System.EventArgs e)
    {
      try 
      {
        this.worker.RemoveRelatedAuthors(this.AuthorID);
        foreach (TreeNode node in this.treeView_RA.Nodes) 
        {
          if (node.Checked) 
          {
            string destID = node.Tag.ToString();
            if (destID.StartsWith("Author@") && int.Parse(destID.Replace("AuthorID@", "")) != this.AuthorID)
              this.worker.AddRelatedAuthor(this.AuthorID, int.Parse(destID.Replace("AuthorID@", "")));
          }
          if (node.Nodes.Count > 0)
            RecursiveAddRelatedAuthors(node);
        }
        button_Cancel_Click(null, null);
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void RecursiveAddRelatedAuthors(TreeNode node) 
    {
      try 
      {
        foreach (TreeNode sub in node.Nodes) 
        {
          if (sub.Checked) 
          {
            string destID = sub.Tag.ToString();
            if (destID.StartsWith("AuthorID@"))
              this.worker.AddRelatedAuthor(this.AuthorID, int.Parse(destID.Replace("AuthorID@", "")));
          }
          if (sub.Nodes.Count > 0)
            RecursiveAddRelatedAuthors(sub);
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void treeView_RA_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
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

    private void treeView_RA_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
    {
      if (e.Action != TreeViewAction.Unknown) 
      {
        if (e.Node.Tag.ToString().StartsWith("AuthorID@"))
          this.button_View.Enabled = true;
        else
          this.button_View.Enabled = false;
      }
    }

    private void button_View_Click(object sender, System.EventArgs e)
    {
      if (this.treeView_RA.SelectedNode != null) 
      {
        ((RooBooks)this.parentForm).ShowRelatedAuthorData(int.Parse(this.treeView_RA.SelectedNode.Tag.ToString().Replace("AuthorID@", "")));
      }
      button_Cancel_Click(null, null);
    }

	}
}
