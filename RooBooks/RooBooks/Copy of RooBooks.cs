using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

using RooBooks.Library;
using RooBooks.UI;


namespace RooBooks.UI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
  public class RooBooks : System.Windows.Forms.Form
  {

    #region Windows Designer Declarations
    private System.Windows.Forms.Panel panel_Book;
    private System.Windows.Forms.GroupBox groupBox_sbPublished;
    private System.Windows.Forms.DateTimePicker dateTimePicker_sbPublishedFrom;
    private System.Windows.Forms.DateTimePicker dateTimePicker_sbPublishedTo;
    private System.Windows.Forms.GroupBox groupBox_sbName;
    private System.Windows.Forms.ColumnHeader columnHeader_AB_Published;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dateTimePicker_BD_Published;
    private System.Windows.Forms.TextBox textBox_sbName;
    private System.Windows.Forms.GroupBox groupBox_sbNationality;
    private System.Windows.Forms.TextBox textBox_sbNationality;
    private System.Windows.Forms.ColumnHeader columnHeader_sra_Category;
    private System.Windows.Forms.ColumnHeader columnHeader_srb_Author;
    private TD.SandDock.DocumentContainer documentContainer_Data;
    private TD.SandDock.DockControl dockControl_Data;
    private TD.SandDock.DockControl dockControl_Search;
    private System.Windows.Forms.GroupBox groupBox_sb_Keyword;
    private System.Windows.Forms.GroupBox groupBox_sb_Notes;
    private System.Windows.Forms.GroupBox groupBox_sb_In;
    private System.Windows.Forms.ColumnHeader columnHeader_sra_ID;
    private System.Windows.Forms.ColumnHeader columnHeader_sra_Name;
    private System.Windows.Forms.ColumnHeader columnHeader_sra_Nationality;
    private System.Windows.Forms.ColumnHeader columnHeader_sra_BirthPlace;
    private System.Windows.Forms.ColumnHeader columnHeader_sra_Modified;
    private System.Windows.Forms.ColumnHeader columnHeader_sra_Created;
    private System.Windows.Forms.ColumnHeader columnHeader_srb_ID;
    private System.Windows.Forms.ColumnHeader columnHeader_srb_Title;
    private System.Windows.Forms.ColumnHeader columnHeader_srb_Genre;
    private System.Windows.Forms.ColumnHeader columnHeader_srb_Modified;
    private System.Windows.Forms.ColumnHeader columnHeader_srb_Created;
    private TD.SandDock.DocumentContainer documentContainer_SearchResults;
    private TD.SandDock.DockControl dockControl_Authors;
    private TD.SandDock.DockControl dockControl_Books;
    private System.Windows.Forms.Panel panel_sr_Authors;
    private System.Windows.Forms.Panel panel_sr_Books;
    private System.Windows.Forms.ListView listView_sr_Authors;
    private System.Windows.Forms.ListView listView_sr_Books;
    private System.Windows.Forms.Panel panel_sr_AuthorsBottom;
    private System.Windows.Forms.Button button_sr_ViewAuthor;
    private System.Windows.Forms.Panel panel_sr_Books_Bottom;
    private System.Windows.Forms.Button button_sr_ViewBook;
    private System.Windows.Forms.TextBox textBox_sbKeyword;
    private System.Windows.Forms.TextBox textBox_sbNotes;
    private System.Windows.Forms.ComboBox comboBox_sbIn;
    private System.Windows.Forms.Button button_Search;
    private System.Windows.Forms.Panel panel_Search;
    private System.Windows.Forms.Panel panel_Author;
    private System.Windows.Forms.Splitter splitter_Book;
    private System.Windows.Forms.Label label_BD_Edit;
    private System.Windows.Forms.GroupBox groupBox_BT_BT;
    private System.Windows.Forms.Label label_BD_Summary;
    private System.Windows.Forms.Label label_BD_Genre;
    private System.Windows.Forms.ComboBox comboBox_BD_Genres;
    private System.Windows.Forms.TextBox textBox_BD_Keywords;
    private System.Windows.Forms.Label label_BD_Keywords;
    private System.Windows.Forms.TextBox textBox_BD_Title;
    private System.Windows.Forms.Label label_BD_Title;
    private System.Windows.Forms.TextBox textBox_BD_Summary;
    private System.Windows.Forms.GroupBox groupBox_BD_Notes;
    private System.Windows.Forms.RichTextBox richTextBox_BD_Notes;
    private System.Windows.Forms.Button button_BD_Save;
    private System.Windows.Forms.ListView listView_Books;
    private System.Windows.Forms.ColumnHeader columnHeader_AB_ID;
    private System.Windows.Forms.ColumnHeader columnHeader_AB_Title;
    private System.Windows.Forms.ColumnHeader columnHeader_AB_Genre;
    private System.Windows.Forms.ColumnHeader columnHeader_AB_ModifiedDate;
    private System.Windows.Forms.ColumnHeader columnHeader_AB_CreatedDate;
    private System.Windows.Forms.Panel panel_Category;
    private System.Windows.Forms.Panel panel_Category_Top;
    private System.Windows.Forms.Panel panel_Category_Bottom;
    private System.Windows.Forms.Splitter splitter_Category;
    private System.Windows.Forms.Panel panel_Author_Bottom;
    private System.Windows.Forms.Panel panel_Author_Top;
    private System.Windows.Forms.Label label_CategoryLabel;
    private System.Windows.Forms.Panel panel_MainTop;
    private System.Windows.Forms.Panel panel_MainBottom;
    private System.Windows.Forms.GroupBox groupBox_AD_PD;
    private System.Windows.Forms.GroupBox groupBox_AD_N;
    private System.Windows.Forms.RichTextBox richTextBox_AuthorData_Notes;
    private System.Windows.Forms.Splitter splitter_Left_Right;
    private System.Windows.Forms.Label label_AU_Edit;
    private System.Windows.Forms.ListView listView_Authors;
    private System.Windows.Forms.ColumnHeader columnHeader_AC_ID;
    private System.Windows.Forms.ColumnHeader columnHeader_AC_Name;
    private System.Windows.Forms.ColumnHeader columnHeader_AC_Nationality;
    private System.Windows.Forms.ColumnHeader columnHeader_AC_BirthPlace;
    private System.Windows.Forms.ColumnHeader columnHeader_AC_ModifiedDate;
    private System.Windows.Forms.ColumnHeader columnHeader_AC_CreatedDate;
    private System.Windows.Forms.MenuItem menuItem_AuthorBooks_Sep2;
    private System.Windows.Forms.MenuItem menuItem_AuthorBooks_ReletadBooks;
    private System.Windows.Forms.MenuItem contextMenu_CategoryAuthors_RelatedAuthors;
    private System.Windows.Forms.Label label_AuthorData8;
    private System.Windows.Forms.TextBox textBox_AuthorData_Keywords;
    private System.Windows.Forms.MenuItem contextMenu_Categories_New_Category;
    private System.Windows.Forms.MenuItem contextMenu_Categories_New_Author;
    private System.Windows.Forms.MenuItem contextMenu_Categories_New_Book;
    private System.Windows.Forms.MenuItem contextMenu_Categories_Sep2;
    private System.Windows.Forms.MenuItem contextMenu_Categories_ToggleGridlines;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.MenuItem contextMenu_Categories_New;
    private System.Windows.Forms.MenuItem contextMenu_Categories_Sep1;
    private System.Windows.Forms.MenuItem contextMenu_Categories_Delete;
    private UtilityLibrary.CommandBars.ReBar reBar_MainMenu;
    private UtilityLibrary.CommandBars.ToolBarEx toolBarEx_MainMenu;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_File;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Edit;
    private UtilityLibrary.CommandBars.ToolBarItem toolBarItem_Help;
    private UtilityLibrary.Menus.MenuItemEx menuItemEx_New;
    private UtilityLibrary.Menus.MenuItemEx menuItemEx_Sep1;
    private UtilityLibrary.Menus.MenuItemEx menuItemEx_Exit;
    private UtilityLibrary.Menus.MenuItemEx menuItemEx_Sep2;
    private UtilityLibrary.Menus.MenuItemEx menuItemEx_Print;
    private UtilityLibrary.Menus.MenuItemEx menuItemEx_PrintPreview;
    private UtilityLibrary.Menus.MenuItemEx menuItemEx_About;
    private UtilityLibrary.Menus.MenuItemEx menuItemEx_Preferences;
    private System.Windows.Forms.StatusBar statusBar;
    private System.Windows.Forms.StatusBarPanel statusBarPanel_Main;
    private System.Windows.Forms.StatusBarPanel statusBarPanel_Secondary;
    private System.Windows.Forms.Timer timer_StatusBar;
    private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    private System.Windows.Forms.PrintDialog printDialog;
    private System.Windows.Forms.NotifyIcon notifyIcon;
    private System.Windows.Forms.ContextMenu contextMenu_NotifyIcon;
    private System.Drawing.Printing.PrintDocument printDocument;
    private System.Windows.Forms.MenuItem NotifyIcon_RestoreMinimze;
    private System.Windows.Forms.MenuItem NotifyIcon_About;
    private System.Windows.Forms.MenuItem NotifyIcon_Sep1;
    private System.Windows.Forms.MenuItem NotifyIcon_Preferences;
    private System.Windows.Forms.MenuItem NotifyIcon_Sep2;
    private System.Windows.Forms.MenuItem NotifyIcon_Exit;
    private System.Windows.Forms.Panel panel_Left;
    private System.Windows.Forms.Panel panel_Right;
    private System.ComponentModel.IContainer components;
    private System.Windows.Forms.TreeListView treeListView_Categories;
    private System.Windows.Forms.ContextMenu contextMenu_Categories;
    private System.Windows.Forms.ImageList imageList;
    private System.Windows.Forms.ColumnHeader columnHeader_Category;
    private System.Windows.Forms.ColumnHeader columnHeader_Summary;
    private System.Windows.Forms.MenuItem contextMenu_Categories_Refresh;
    private System.Windows.Forms.Panel panel_Start;
    private System.Windows.Forms.MenuItem contextMenu_Categories_Sep3;
    private System.Windows.Forms.MenuItem contextMenu_Categories_ShrinkAuthors;
    private System.Windows.Forms.MenuItem contextMenu_Categories_ShowAll;
    private System.Windows.Forms.MenuItem contextMenu_CategoryAuthors_AddNew;
    private System.Windows.Forms.MenuItem contextMenu_CategoryAuthors_DeleteThis;
    private System.Windows.Forms.MenuItem contextMenu_CategoryAuthors_ToggleGridlines;
    private System.Windows.Forms.ToolTip toolTip_LV_Authors;
    private System.Windows.Forms.Label label_AuthorData1;
    private System.Windows.Forms.Label label_AuthorData2;
    private System.Windows.Forms.Label label_AuthorData3;
    private System.Windows.Forms.Label label_AuthorData4;
    private System.Windows.Forms.Label label_AuthorData5;
    private System.Windows.Forms.Label label_AuthorData6;
    private System.Windows.Forms.TextBox textBox_AuthorData_Nationality;
    private System.Windows.Forms.TextBox textBox_AuthorData_BirthPlace;
    private System.Windows.Forms.TextBox textBox_AuthorData_Summary;
    private System.Windows.Forms.DateTimePicker dateTimePicker_AuthorData_BirthDate;
    private System.Windows.Forms.DateTimePicker dateTimePicker_AuthorData_DateOfDeath;
    private System.Windows.Forms.Button button_Save;
    private System.Windows.Forms.TextBox textBox_AuthorData_FirstName;
    private System.Windows.Forms.Label label_AuthorData7;
    private System.Windows.Forms.TextBox textBox_AuthorData_LastName;
    private System.Windows.Forms.ContextMenu contextMenu_AuthorBooks;
    private System.Windows.Forms.MenuItem menuItem_AuthorBooks_AddNew;
    private System.Windows.Forms.MenuItem menuItem_AuthorBooks_DeleteThis;
    private System.Windows.Forms.MenuItem menuItem_AuthorBooks_Sep1;
    private System.Windows.Forms.MenuItem menuItem_AuthorBooks_ToggleGridlines;
    private System.Windows.Forms.ContextMenu contextMenu_CategoryAuthors;
    private System.Windows.Forms.MenuItem contextMenu_CategoryAuthors_Sep2;
    private System.Windows.Forms.MenuItem contextMenu_CategoryAuthors_Sep1;
    private System.Windows.Forms.MenuItem contextMenu_CategoryAuthors_ViewBooks;
    #endregion

    #region Own Declarations
    private StringReader printStringReader = null;
    private DataSet dataset_Categories = null;
    private DataSet dataset_CategoryAuthors = null;
    private DataTable dtAuthors = null;
    private DataTable dtBooks = null;
    private SortedList bookGenres = null;
    private DB rbWorker = null;
    private Settings rbSettings = null;
    private ListViewColumnSorter lvwColumnSorter = null;
    private UI.TextEditor bookDataEditor = null;
    #endregion

    #region Properties
    private TreeListViewItem selectedTreeItem = null;
    public TreeListViewItem SelectedTreeItem 
    {
      get 
      {
        return selectedTreeItem;
      }
      set 
      {
        selectedTreeItem = value;
      }
    }
    private string registryPath = "";
    public string RegistryPath 
    {
      get 
      {
        return registryPath;
      }
      set 
      {
        registryPath = value;
      }
    }
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
    private bool expandCategories = false;  
    public bool ExpandCategories
    {
      get 
      {
        return expandCategories;
      }
      set 
      {
        expandCategories = value;
      }
    }
    private int currentCategoryID = 0;
    public int CurrentCategoryID
    {
      get 
      {
        return currentCategoryID;
      }
      set 
      {
        currentCategoryID = value;
      }
    }
    private string currentCategoryName = "";
    public string CurrentCategoryName
    {
      get 
      {
        return currentCategoryName;
      }
      set 
      {
        currentCategoryName = value;
      }
    }
    private int currentAuthorID = 0;
    public int CurrentAuthorID
    {
      get 
      {
        return currentAuthorID;
      }
      set 
      {
        currentAuthorID = value;
      }
    }
    private int currentBookID = 0;
    public int CurrentBookID
    {
      get 
      {
        return currentBookID;
      }
      set 
      {
        currentBookID = value;
      }
    }
    private bool hasCategoryChanges = false;
    public bool HasCategoryChanges
    {
      get 
      {
        return hasCategoryChanges;
      }
      set 
      {
        hasCategoryChanges = value;
      }
    }
    private bool hasAuthorChanges = false;      
    public bool HasAuthorChanges
    {
      get 
      {
        return hasAuthorChanges;
      }
      set 
      {
        hasAuthorChanges = value;
      }
    }
    private bool hasBookChanges = false;    
    public bool HasBookChanges
    {
      get 
      {
        return hasBookChanges;
      }
      set 
      {
        hasBookChanges = value;
      }
    }
    private int genresGeneralCategoryID = 0;
    public int GenresGeneralCategoryID
    {
      get 
      {
        return genresGeneralCategoryID;
      }
      set 
      {
        genresGeneralCategoryID = value;
      }
    }
    private bool showRelatedAuthor = false;
    private System.Windows.Forms.StatusBarPanel statusBarPanel_Icon;
                        
    public bool ShowRelatedAuthor
    {
      get 
      {
        return showRelatedAuthor;
      }
      set 
      {
        showRelatedAuthor = value;
      }
    }
    private bool showRelatedBook = false;
    public bool ShowRelatedBook
    {
      get 
      {
        return showRelatedBook;
      }
      set 
      {
        showRelatedBook = value;
      }
    }
    #endregion

    public RooBooks()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      //
      // TODO: Add any constructor code after InitializeComponent call
      //
    }


    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if (components != null) 
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
      this.components = new System.ComponentModel.Container();
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RooBooks));
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
      this.bookDataEditor = new TextEditor();
      this.reBar_MainMenu = new UtilityLibrary.CommandBars.ReBar();
      this.toolBarEx_MainMenu = new UtilityLibrary.CommandBars.ToolBarEx();
      this.toolBarItem_File = new UtilityLibrary.CommandBars.ToolBarItem();
      this.menuItemEx_New = new UtilityLibrary.Menus.MenuItemEx();
      this.menuItemEx_Sep1 = new UtilityLibrary.Menus.MenuItemEx();
      this.menuItemEx_Print = new UtilityLibrary.Menus.MenuItemEx();
      this.menuItemEx_PrintPreview = new UtilityLibrary.Menus.MenuItemEx();
      this.menuItemEx_Sep2 = new UtilityLibrary.Menus.MenuItemEx();
      this.menuItemEx_Exit = new UtilityLibrary.Menus.MenuItemEx();
      this.toolBarItem_Edit = new UtilityLibrary.CommandBars.ToolBarItem();
      this.menuItemEx_Preferences = new UtilityLibrary.Menus.MenuItemEx();
      this.toolBarItem_Help = new UtilityLibrary.CommandBars.ToolBarItem();
      this.menuItemEx_About = new UtilityLibrary.Menus.MenuItemEx();
      this.statusBar = new System.Windows.Forms.StatusBar();
      this.statusBarPanel_Icon = new System.Windows.Forms.StatusBarPanel();
      this.statusBarPanel_Main = new System.Windows.Forms.StatusBarPanel();
      this.statusBarPanel_Secondary = new System.Windows.Forms.StatusBarPanel();
      this.timer_StatusBar = new System.Windows.Forms.Timer(this.components);
      this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
      this.printDocument = new System.Drawing.Printing.PrintDocument();
      this.printDialog = new System.Windows.Forms.PrintDialog();
      this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenu_NotifyIcon = new System.Windows.Forms.ContextMenu();
      this.NotifyIcon_RestoreMinimze = new System.Windows.Forms.MenuItem();
      this.NotifyIcon_About = new System.Windows.Forms.MenuItem();
      this.NotifyIcon_Sep1 = new System.Windows.Forms.MenuItem();
      this.NotifyIcon_Preferences = new System.Windows.Forms.MenuItem();
      this.NotifyIcon_Sep2 = new System.Windows.Forms.MenuItem();
      this.NotifyIcon_Exit = new System.Windows.Forms.MenuItem();
      this.panel_Left = new System.Windows.Forms.Panel();
      this.documentContainer_Data = new TD.SandDock.DocumentContainer();
      this.dockControl_Data = new TD.SandDock.DockControl();
      this.treeListView_Categories = new System.Windows.Forms.TreeListView();
      this.columnHeader_Category = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_Summary = new System.Windows.Forms.ColumnHeader();
      this.contextMenu_Categories = new System.Windows.Forms.ContextMenu();
      this.contextMenu_Categories_New = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_New_Category = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_New_Author = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_New_Book = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_Sep1 = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_Delete = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_Sep2 = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_Refresh = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_ToggleGridlines = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_Sep3 = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_ShrinkAuthors = new System.Windows.Forms.MenuItem();
      this.contextMenu_Categories_ShowAll = new System.Windows.Forms.MenuItem();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.dockControl_Search = new TD.SandDock.DockControl();
      this.groupBox_sb_Keyword = new System.Windows.Forms.GroupBox();
      this.textBox_sbKeyword = new System.Windows.Forms.TextBox();
      this.button_Search = new System.Windows.Forms.Button();
      this.groupBox_sb_Notes = new System.Windows.Forms.GroupBox();
      this.textBox_sbNotes = new System.Windows.Forms.TextBox();
      this.groupBox_sb_In = new System.Windows.Forms.GroupBox();
      this.comboBox_sbIn = new System.Windows.Forms.ComboBox();
      this.groupBox_sbName = new System.Windows.Forms.GroupBox();
      this.textBox_sbName = new System.Windows.Forms.TextBox();
      this.groupBox_sbNationality = new System.Windows.Forms.GroupBox();
      this.textBox_sbNationality = new System.Windows.Forms.TextBox();
      this.groupBox_sbPublished = new System.Windows.Forms.GroupBox();
      this.dateTimePicker_sbPublishedTo = new System.Windows.Forms.DateTimePicker();
      this.dateTimePicker_sbPublishedFrom = new System.Windows.Forms.DateTimePicker();
      this.panel_Right = new System.Windows.Forms.Panel();
      this.panel_Start = new System.Windows.Forms.Panel();
      this.panel_MainTop = new System.Windows.Forms.Panel();
      this.label_CategoryLabel = new System.Windows.Forms.Label();
      this.panel_MainBottom = new System.Windows.Forms.Panel();
      this.panel_Search = new System.Windows.Forms.Panel();
      this.documentContainer_SearchResults = new TD.SandDock.DocumentContainer();
      this.dockControl_Authors = new TD.SandDock.DockControl();
      this.panel_sr_AuthorsBottom = new System.Windows.Forms.Panel();
      this.button_sr_ViewAuthor = new System.Windows.Forms.Button();
      this.panel_sr_Authors = new System.Windows.Forms.Panel();
      this.listView_sr_Authors = new System.Windows.Forms.ListView();
      this.columnHeader_sra_ID = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_sra_Name = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_sra_Category = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_sra_Nationality = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_sra_BirthPlace = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_sra_Modified = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_sra_Created = new System.Windows.Forms.ColumnHeader();
      this.dockControl_Books = new TD.SandDock.DockControl();
      this.panel_sr_Books = new System.Windows.Forms.Panel();
      this.listView_sr_Books = new System.Windows.Forms.ListView();
      this.columnHeader_srb_ID = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_srb_Title = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_srb_Author = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_srb_Genre = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_srb_Modified = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_srb_Created = new System.Windows.Forms.ColumnHeader();
      this.panel_sr_Books_Bottom = new System.Windows.Forms.Panel();
      this.button_sr_ViewBook = new System.Windows.Forms.Button();
      this.panel_Author = new System.Windows.Forms.Panel();
      this.splitter_Book = new System.Windows.Forms.Splitter();
      this.panel_Author_Bottom = new System.Windows.Forms.Panel();
      this.label_BD_Edit = new System.Windows.Forms.Label();
      this.groupBox_BT_BT = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dateTimePicker_BD_Published = new System.Windows.Forms.DateTimePicker();
      this.label_BD_Summary = new System.Windows.Forms.Label();
      this.label_BD_Genre = new System.Windows.Forms.Label();
      this.comboBox_BD_Genres = new System.Windows.Forms.ComboBox();
      this.textBox_BD_Keywords = new System.Windows.Forms.TextBox();
      this.label_BD_Keywords = new System.Windows.Forms.Label();
      this.textBox_BD_Title = new System.Windows.Forms.TextBox();
      this.label_BD_Title = new System.Windows.Forms.Label();
      this.textBox_BD_Summary = new System.Windows.Forms.TextBox();
      this.groupBox_BD_Notes = new System.Windows.Forms.GroupBox();
      this.richTextBox_BD_Notes = new System.Windows.Forms.RichTextBox();
      this.button_BD_Save = new System.Windows.Forms.Button();
      this.panel_Author_Top = new System.Windows.Forms.Panel();
      this.listView_Books = new System.Windows.Forms.ListView();
      this.columnHeader_AB_ID = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AB_Title = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AB_Genre = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AB_Published = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AB_ModifiedDate = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AB_CreatedDate = new System.Windows.Forms.ColumnHeader();
      this.contextMenu_AuthorBooks = new System.Windows.Forms.ContextMenu();
      this.menuItem_AuthorBooks_AddNew = new System.Windows.Forms.MenuItem();
      this.menuItem_AuthorBooks_DeleteThis = new System.Windows.Forms.MenuItem();
      this.menuItem_AuthorBooks_Sep1 = new System.Windows.Forms.MenuItem();
      this.menuItem_AuthorBooks_ReletadBooks = new System.Windows.Forms.MenuItem();
      this.menuItem_AuthorBooks_Sep2 = new System.Windows.Forms.MenuItem();
      this.menuItem_AuthorBooks_ToggleGridlines = new System.Windows.Forms.MenuItem();
      this.panel_Category = new System.Windows.Forms.Panel();
      this.splitter_Category = new System.Windows.Forms.Splitter();
      this.panel_Category_Bottom = new System.Windows.Forms.Panel();
      this.label_AU_Edit = new System.Windows.Forms.Label();
      this.groupBox_AD_PD = new System.Windows.Forms.GroupBox();
      this.label_AuthorData8 = new System.Windows.Forms.Label();
      this.label_AuthorData1 = new System.Windows.Forms.Label();
      this.label_AuthorData6 = new System.Windows.Forms.Label();
      this.label_AuthorData4 = new System.Windows.Forms.Label();
      this.label_AuthorData2 = new System.Windows.Forms.Label();
      this.textBox_AuthorData_Nationality = new System.Windows.Forms.TextBox();
      this.textBox_AuthorData_FirstName = new System.Windows.Forms.TextBox();
      this.dateTimePicker_AuthorData_BirthDate = new System.Windows.Forms.DateTimePicker();
      this.textBox_AuthorData_Summary = new System.Windows.Forms.TextBox();
      this.textBox_AuthorData_Keywords = new System.Windows.Forms.TextBox();
      this.label_AuthorData7 = new System.Windows.Forms.Label();
      this.label_AuthorData3 = new System.Windows.Forms.Label();
      this.label_AuthorData5 = new System.Windows.Forms.Label();
      this.textBox_AuthorData_LastName = new System.Windows.Forms.TextBox();
      this.textBox_AuthorData_BirthPlace = new System.Windows.Forms.TextBox();
      this.dateTimePicker_AuthorData_DateOfDeath = new System.Windows.Forms.DateTimePicker();
      this.groupBox_AD_N = new System.Windows.Forms.GroupBox();
      this.richTextBox_AuthorData_Notes = new System.Windows.Forms.RichTextBox();
      this.button_Save = new System.Windows.Forms.Button();
      this.panel_Category_Top = new System.Windows.Forms.Panel();
      this.listView_Authors = new System.Windows.Forms.ListView();
      this.columnHeader_AC_ID = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AC_Name = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AC_Nationality = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AC_BirthPlace = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AC_ModifiedDate = new System.Windows.Forms.ColumnHeader();
      this.columnHeader_AC_CreatedDate = new System.Windows.Forms.ColumnHeader();
      this.contextMenu_CategoryAuthors = new System.Windows.Forms.ContextMenu();
      this.contextMenu_CategoryAuthors_AddNew = new System.Windows.Forms.MenuItem();
      this.contextMenu_CategoryAuthors_DeleteThis = new System.Windows.Forms.MenuItem();
      this.contextMenu_CategoryAuthors_Sep1 = new System.Windows.Forms.MenuItem();
      this.contextMenu_CategoryAuthors_ViewBooks = new System.Windows.Forms.MenuItem();
      this.contextMenu_CategoryAuthors_RelatedAuthors = new System.Windows.Forms.MenuItem();
      this.contextMenu_CategoryAuthors_Sep2 = new System.Windows.Forms.MenuItem();
      this.contextMenu_CategoryAuthors_ToggleGridlines = new System.Windows.Forms.MenuItem();
      this.panel_Book = new System.Windows.Forms.Panel();
      this.splitter_Left_Right = new System.Windows.Forms.Splitter();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.toolTip_LV_Authors = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_Icon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_Main)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_Secondary)).BeginInit();
      this.panel_Left.SuspendLayout();
      this.documentContainer_Data.SuspendLayout();
      this.dockControl_Data.SuspendLayout();
      this.dockControl_Search.SuspendLayout();
      this.groupBox_sb_Keyword.SuspendLayout();
      this.groupBox_sb_Notes.SuspendLayout();
      this.groupBox_sb_In.SuspendLayout();
      this.groupBox_sbName.SuspendLayout();
      this.groupBox_sbNationality.SuspendLayout();
      this.groupBox_sbPublished.SuspendLayout();
      this.panel_Right.SuspendLayout();
      this.panel_Start.SuspendLayout();
      this.panel_MainTop.SuspendLayout();
      this.panel_MainBottom.SuspendLayout();
      this.panel_Search.SuspendLayout();
      this.documentContainer_SearchResults.SuspendLayout();
      this.dockControl_Authors.SuspendLayout();
      this.panel_sr_AuthorsBottom.SuspendLayout();
      this.panel_sr_Authors.SuspendLayout();
      this.dockControl_Books.SuspendLayout();
      this.panel_sr_Books.SuspendLayout();
      this.panel_sr_Books_Bottom.SuspendLayout();
      this.panel_Author.SuspendLayout();
      this.panel_Author_Bottom.SuspendLayout();
      this.groupBox_BT_BT.SuspendLayout();
      this.groupBox_BD_Notes.SuspendLayout();
      this.panel_Author_Top.SuspendLayout();
      this.panel_Category.SuspendLayout();
      this.panel_Category_Bottom.SuspendLayout();
      this.groupBox_AD_PD.SuspendLayout();
      this.groupBox_AD_N.SuspendLayout();
      this.panel_Category_Top.SuspendLayout();
      this.panel_Book.SuspendLayout();
      this.SuspendLayout();
      // 
      // bookDataEditor
      // 
      this.bookDataEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.bookDataEditor.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.bookDataEditor.FontFamilySelected = "Trebuchet MS";
      this.bookDataEditor.FontSizeSelected = 8.25F;
      this.bookDataEditor.Location = new System.Drawing.Point(0, 0);
      this.bookDataEditor.Name = "bookDataEditor";
      this.bookDataEditor.Size = new System.Drawing.Size(659, 460);
      this.bookDataEditor.TabIndex = 1;
      // 
      // reBar_MainMenu
      // 
      this.reBar_MainMenu.Bands.Add(this.toolBarEx_MainMenu);
      this.reBar_MainMenu.Dock = System.Windows.Forms.DockStyle.Top;
      this.reBar_MainMenu.Location = new System.Drawing.Point(0, 0);
      this.reBar_MainMenu.Name = "reBar_MainMenu";
      this.reBar_MainMenu.Size = new System.Drawing.Size(956, 24);
      this.reBar_MainMenu.TabIndex = 0;
      this.reBar_MainMenu.TabStop = false;
      // 
      // toolBarEx_MainMenu
      // 
      this.toolBarEx_MainMenu.BarType = UtilityLibrary.CommandBars.BarType.MenuBar;
      this.toolBarEx_MainMenu.Dock = System.Windows.Forms.DockStyle.Top;
      this.toolBarEx_MainMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.toolBarEx_MainMenu.ImageList = null;
      this.toolBarEx_MainMenu.Items.AddRange(new UtilityLibrary.CommandBars.ToolBarItem[] {
                                                                                            this.toolBarItem_File,
                                                                                            this.toolBarItem_Edit,
                                                                                            this.toolBarItem_Help});
      this.toolBarEx_MainMenu.Location = new System.Drawing.Point(9, 2);
      this.toolBarEx_MainMenu.Name = "toolBarEx_MainMenu";
      this.toolBarEx_MainMenu.Size = new System.Drawing.Size(943, 20);
      this.toolBarEx_MainMenu.TabIndex = 0;
      this.toolBarEx_MainMenu.TabStop = false;
      // 
      // toolBarItem_File
      // 
      this.toolBarItem_File.Checked = false;
      this.toolBarItem_File.ClickHandler = null;
      this.toolBarItem_File.ComboBox = null;
      this.toolBarItem_File.Dropped = false;
      this.toolBarItem_File.Enabled = true;
      this.toolBarItem_File.Image = null;
      this.toolBarItem_File.ImageListIndex = -1;
      this.toolBarItem_File.Index = 0;
      this.toolBarItem_File.MenuItems.Add(this.menuItemEx_New);
      this.toolBarItem_File.MenuItems.Add(this.menuItemEx_Sep1);
      this.toolBarItem_File.MenuItems.Add(this.menuItemEx_Print);
      this.toolBarItem_File.MenuItems.Add(this.menuItemEx_PrintPreview);
      this.toolBarItem_File.MenuItems.Add(this.menuItemEx_Sep2);
      this.toolBarItem_File.MenuItems.Add(this.menuItemEx_Exit);
      this.toolBarItem_File.Shortcut = System.Windows.Forms.Keys.None;
      this.toolBarItem_File.Style = UtilityLibrary.CommandBars.ToolBarItemStyle.PushButton;
      this.toolBarItem_File.Tag = null;
      this.toolBarItem_File.Text = "&File";
      this.toolBarItem_File.ToolBar = this.toolBarEx_MainMenu;
      this.toolBarItem_File.ToolTip = null;
      this.toolBarItem_File.Visible = true;
      this.toolBarItem_File.DropDown += new System.EventHandler(this.toolBarItem_File_DropDown);
      // 
      // menuItemEx_New
      // 
      this.menuItemEx_New.ClickHandler = null;
      this.menuItemEx_New.Icon = ((System.Drawing.Bitmap)(resources.GetObject("menuItemEx_New.Icon")));
      this.menuItemEx_New.IconTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(128)));
      this.menuItemEx_New.ImageIndex = -1;
      this.menuItemEx_New.ImageList = null;
      this.menuItemEx_New.Index = 0;
      this.menuItemEx_New.OwnerDraw = true;
      this.menuItemEx_New.ShortcutText = "";
      this.menuItemEx_New.Text = "New...";
      this.menuItemEx_New.Click += new System.EventHandler(this.menuItemEx_New_Click);
      // 
      // menuItemEx_Sep1
      // 
      this.menuItemEx_Sep1.ClickHandler = null;
      this.menuItemEx_Sep1.Icon = null;
      this.menuItemEx_Sep1.IconTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(128)));
      this.menuItemEx_Sep1.ImageIndex = -1;
      this.menuItemEx_Sep1.ImageList = null;
      this.menuItemEx_Sep1.Index = 1;
      this.menuItemEx_Sep1.OwnerDraw = true;
      this.menuItemEx_Sep1.ShortcutText = "";
      this.menuItemEx_Sep1.Text = "-";
      // 
      // menuItemEx_Print
      // 
      this.menuItemEx_Print.ClickHandler = null;
      this.menuItemEx_Print.Icon = ((System.Drawing.Bitmap)(resources.GetObject("menuItemEx_Print.Icon")));
      this.menuItemEx_Print.IconTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(128)));
      this.menuItemEx_Print.ImageIndex = -1;
      this.menuItemEx_Print.ImageList = null;
      this.menuItemEx_Print.Index = 2;
      this.menuItemEx_Print.OwnerDraw = true;
      this.menuItemEx_Print.ShortcutText = "";
      this.menuItemEx_Print.Text = "Print...";
      this.menuItemEx_Print.Click += new System.EventHandler(this.menuItemEx_Print_Click);
      // 
      // menuItemEx_PrintPreview
      // 
      this.menuItemEx_PrintPreview.ClickHandler = null;
      this.menuItemEx_PrintPreview.Icon = null;
      this.menuItemEx_PrintPreview.IconTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(128)));
      this.menuItemEx_PrintPreview.ImageIndex = -1;
      this.menuItemEx_PrintPreview.ImageList = null;
      this.menuItemEx_PrintPreview.Index = 3;
      this.menuItemEx_PrintPreview.OwnerDraw = true;
      this.menuItemEx_PrintPreview.ShortcutText = "";
      this.menuItemEx_PrintPreview.Text = "Print Preview...";
      this.menuItemEx_PrintPreview.Click += new System.EventHandler(this.menuItemEx_PrintPreview_Click);
      // 
      // menuItemEx_Sep2
      // 
      this.menuItemEx_Sep2.ClickHandler = null;
      this.menuItemEx_Sep2.Icon = null;
      this.menuItemEx_Sep2.IconTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(128)));
      this.menuItemEx_Sep2.ImageIndex = -1;
      this.menuItemEx_Sep2.ImageList = null;
      this.menuItemEx_Sep2.Index = 4;
      this.menuItemEx_Sep2.OwnerDraw = true;
      this.menuItemEx_Sep2.ShortcutText = "";
      this.menuItemEx_Sep2.Text = "-";
      // 
      // menuItemEx_Exit
      // 
      this.menuItemEx_Exit.ClickHandler = null;
      this.menuItemEx_Exit.Icon = ((System.Drawing.Bitmap)(resources.GetObject("menuItemEx_Exit.Icon")));
      this.menuItemEx_Exit.IconTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(128)));
      this.menuItemEx_Exit.ImageIndex = -1;
      this.menuItemEx_Exit.ImageList = null;
      this.menuItemEx_Exit.Index = 5;
      this.menuItemEx_Exit.OwnerDraw = true;
      this.menuItemEx_Exit.ShortcutText = "";
      this.menuItemEx_Exit.Text = "Exit";
      this.menuItemEx_Exit.Click += new System.EventHandler(this.CloseApp);
      // 
      // toolBarItem_Edit
      // 
      this.toolBarItem_Edit.Checked = false;
      this.toolBarItem_Edit.ClickHandler = null;
      this.toolBarItem_Edit.ComboBox = null;
      this.toolBarItem_Edit.Dropped = false;
      this.toolBarItem_Edit.Enabled = true;
      this.toolBarItem_Edit.Image = null;
      this.toolBarItem_Edit.ImageListIndex = -1;
      this.toolBarItem_Edit.Index = 1;
      this.toolBarItem_Edit.MenuItems.Add(this.menuItemEx_Preferences);
      this.toolBarItem_Edit.Shortcut = System.Windows.Forms.Keys.None;
      this.toolBarItem_Edit.Style = UtilityLibrary.CommandBars.ToolBarItemStyle.PushButton;
      this.toolBarItem_Edit.Tag = null;
      this.toolBarItem_Edit.Text = "&Edit";
      this.toolBarItem_Edit.ToolBar = this.toolBarEx_MainMenu;
      this.toolBarItem_Edit.ToolTip = null;
      this.toolBarItem_Edit.Visible = true;
      // 
      // menuItemEx_Preferences
      // 
      this.menuItemEx_Preferences.ClickHandler = null;
      this.menuItemEx_Preferences.Icon = ((System.Drawing.Bitmap)(resources.GetObject("menuItemEx_Preferences.Icon")));
      this.menuItemEx_Preferences.IconTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(128)));
      this.menuItemEx_Preferences.ImageIndex = -1;
      this.menuItemEx_Preferences.ImageList = null;
      this.menuItemEx_Preferences.Index = 0;
      this.menuItemEx_Preferences.OwnerDraw = true;
      this.menuItemEx_Preferences.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
      this.menuItemEx_Preferences.ShortcutText = "Ctrl + P";
      this.menuItemEx_Preferences.Text = "Preferences";
      this.menuItemEx_Preferences.Click += new System.EventHandler(this.ShowPreferences);
      // 
      // toolBarItem_Help
      // 
      this.toolBarItem_Help.Checked = false;
      this.toolBarItem_Help.ClickHandler = null;
      this.toolBarItem_Help.ComboBox = null;
      this.toolBarItem_Help.Dropped = false;
      this.toolBarItem_Help.Enabled = true;
      this.toolBarItem_Help.Image = null;
      this.toolBarItem_Help.ImageListIndex = -1;
      this.toolBarItem_Help.Index = 2;
      this.toolBarItem_Help.MenuItems.Add(this.menuItemEx_About);
      this.toolBarItem_Help.Shortcut = System.Windows.Forms.Keys.None;
      this.toolBarItem_Help.Style = UtilityLibrary.CommandBars.ToolBarItemStyle.PushButton;
      this.toolBarItem_Help.Tag = null;
      this.toolBarItem_Help.Text = "&Help";
      this.toolBarItem_Help.ToolBar = this.toolBarEx_MainMenu;
      this.toolBarItem_Help.ToolTip = null;
      this.toolBarItem_Help.Visible = true;
      // 
      // menuItemEx_About
      // 
      this.menuItemEx_About.ClickHandler = null;
      this.menuItemEx_About.Icon = ((System.Drawing.Bitmap)(resources.GetObject("menuItemEx_About.Icon")));
      this.menuItemEx_About.IconTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(128)), ((System.Byte)(128)));
      this.menuItemEx_About.ImageIndex = -1;
      this.menuItemEx_About.ImageList = null;
      this.menuItemEx_About.Index = 0;
      this.menuItemEx_About.OwnerDraw = true;
      this.menuItemEx_About.Shortcut = System.Windows.Forms.Shortcut.F1;
      this.menuItemEx_About.ShortcutText = "F1";
      this.menuItemEx_About.Text = "About";
      this.menuItemEx_About.Click += new System.EventHandler(this.ShowAbout);
      // 
      // statusBar
      // 
      this.statusBar.Location = new System.Drawing.Point(0, 525);
      this.statusBar.Name = "statusBar";
      this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
                                                                                 this.statusBarPanel_Icon,
                                                                                 this.statusBarPanel_Main,
                                                                                 this.statusBarPanel_Secondary});
      this.statusBar.ShowPanels = true;
      this.statusBar.Size = new System.Drawing.Size(956, 20);
      this.statusBar.TabIndex = 1;
      // 
      // statusBarPanel_Icon
      // 
      this.statusBarPanel_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel_Icon.Icon")));
      this.statusBarPanel_Icon.Text = "statusBarPanel_Icon";
      this.statusBarPanel_Icon.Width = 20;
      // 
      // statusBarPanel_Main
      // 
      this.statusBarPanel_Main.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
      this.statusBarPanel_Main.Text = "RooBooks";
      this.statusBarPanel_Main.Width = 860;
      // 
      // statusBarPanel_Secondary
      // 
      this.statusBarPanel_Secondary.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
      this.statusBarPanel_Secondary.MinWidth = 60;
      this.statusBarPanel_Secondary.Width = 60;
      // 
      // timer_StatusBar
      // 
      this.timer_StatusBar.Enabled = true;
      this.timer_StatusBar.Tick += new System.EventHandler(this.timer_StatusBar_Tick);
      // 
      // printPreviewDialog
      // 
      this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
      this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
      this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
      this.printPreviewDialog.Document = this.printDocument;
      this.printPreviewDialog.Enabled = true;
      this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
      this.printPreviewDialog.Location = new System.Drawing.Point(152, 17);
      this.printPreviewDialog.MinimumSize = new System.Drawing.Size(375, 250);
      this.printPreviewDialog.Name = "printPreviewDialog";
      this.printPreviewDialog.TransparencyKey = System.Drawing.Color.Empty;
      this.printPreviewDialog.Visible = false;
      // 
      // printDocument
      // 
      this.printDocument.DocumentName = "printDoc";
      this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
      // 
      // printDialog
      // 
      this.printDialog.AllowSelection = true;
      this.printDialog.AllowSomePages = true;
      this.printDialog.Document = this.printDocument;
      this.printDialog.ShowHelp = true;
      // 
      // notifyIcon
      // 
      this.notifyIcon.ContextMenu = this.contextMenu_NotifyIcon;
      this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
      this.notifyIcon.Text = "";
      this.notifyIcon.Visible = true;
      // 
      // contextMenu_NotifyIcon
      // 
      this.contextMenu_NotifyIcon.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                           this.NotifyIcon_RestoreMinimze,
                                                                                           this.NotifyIcon_About,
                                                                                           this.NotifyIcon_Sep1,
                                                                                           this.NotifyIcon_Preferences,
                                                                                           this.NotifyIcon_Sep2,
                                                                                           this.NotifyIcon_Exit});
      // 
      // NotifyIcon_RestoreMinimze
      // 
      this.NotifyIcon_RestoreMinimze.Index = 0;
      this.NotifyIcon_RestoreMinimze.Text = "Restore/Minimize";
      this.NotifyIcon_RestoreMinimze.Click += new System.EventHandler(this.NotifyIcon_RestoreMinimze_Click);
      // 
      // NotifyIcon_About
      // 
      this.NotifyIcon_About.Index = 1;
      this.NotifyIcon_About.Text = "About";
      this.NotifyIcon_About.Click += new System.EventHandler(this.ShowAbout);
      // 
      // NotifyIcon_Sep1
      // 
      this.NotifyIcon_Sep1.Index = 2;
      this.NotifyIcon_Sep1.Text = "-";
      // 
      // NotifyIcon_Preferences
      // 
      this.NotifyIcon_Preferences.Index = 3;
      this.NotifyIcon_Preferences.Text = "Preferences";
      this.NotifyIcon_Preferences.Click += new System.EventHandler(this.ShowPreferences);
      // 
      // NotifyIcon_Sep2
      // 
      this.NotifyIcon_Sep2.Index = 4;
      this.NotifyIcon_Sep2.Text = "-";
      // 
      // NotifyIcon_Exit
      // 
      this.NotifyIcon_Exit.Index = 5;
      this.NotifyIcon_Exit.Text = "Exit";
      this.NotifyIcon_Exit.Click += new System.EventHandler(this.CloseApp);
      // 
      // panel_Left
      // 
      this.panel_Left.Controls.Add(this.documentContainer_Data);
      this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel_Left.Location = new System.Drawing.Point(0, 24);
      this.panel_Left.Name = "panel_Left";
      this.panel_Left.Size = new System.Drawing.Size(292, 501);
      this.panel_Left.TabIndex = 2;
      // 
      // documentContainer_Data
      // 
      this.documentContainer_Data.Controls.Add(this.dockControl_Data);
      this.documentContainer_Data.Controls.Add(this.dockControl_Search);
      this.documentContainer_Data.Cursor = System.Windows.Forms.Cursors.Default;
      this.documentContainer_Data.Guid = new System.Guid("76f4c2cc-ccf3-4b15-876f-c07812e72f7a");
      this.documentContainer_Data.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
                                                                                                                                                                               new TD.SandDock.DocumentLayoutSystem(290, 499, new TD.SandDock.DockControl[] {
                                                                                                                                                                                                                                                              this.dockControl_Data,
                                                                                                                                                                                                                                                              this.dockControl_Search}, this.dockControl_Data)});
      this.documentContainer_Data.Location = new System.Drawing.Point(0, 0);
      this.documentContainer_Data.Manager = null;
      this.documentContainer_Data.Name = "documentContainer_Data";
      this.documentContainer_Data.Renderer = new TD.SandDock.Rendering.WhidbeyRenderer();
      this.documentContainer_Data.Size = new System.Drawing.Size(292, 501);
      this.documentContainer_Data.TabIndex = 1;
      this.documentContainer_Data.ActiveDocumentChanged += new TD.SandDock.ActiveDocumentEventHandler(this.documentContainer_Data_ActiveDocumentChanged);
      // 
      // dockControl_Data
      // 
      this.dockControl_Data.Closable = false;
      this.dockControl_Data.Controls.Add(this.treeListView_Categories);
      this.dockControl_Data.Guid = new System.Guid("5d2ee9eb-65c4-4c1e-8d23-7430679905ec");
      this.dockControl_Data.Location = new System.Drawing.Point(3, 23);
      this.dockControl_Data.Name = "dockControl_Data";
      this.dockControl_Data.Size = new System.Drawing.Size(286, 475);
      this.dockControl_Data.TabImage = ((System.Drawing.Image)(resources.GetObject("dockControl_Data.TabImage")));
      this.dockControl_Data.TabIndex = 0;
      this.dockControl_Data.Tag = "0";
      this.dockControl_Data.Text = "Data";
      // 
      // treeListView_Categories
      // 
      this.treeListView_Categories.AllowColumnReorder = true;
      this.treeListView_Categories.AutoArrange = false;
      this.treeListView_Categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.treeListView_Categories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                              this.columnHeader_Category,
                                                                                              this.columnHeader_Summary});
      this.treeListView_Categories.ContextMenu = this.contextMenu_Categories;
      this.treeListView_Categories.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeListView_Categories.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.treeListView_Categories.GridLines = true;
      this.treeListView_Categories.HideSelection = false;
      this.treeListView_Categories.LabelWrap = false;
      this.treeListView_Categories.Location = new System.Drawing.Point(0, 0);
      this.treeListView_Categories.Name = "treeListView_Categories";
      this.treeListView_Categories.Size = new System.Drawing.Size(286, 475);
      this.treeListView_Categories.SmallImageList = this.imageList;
      this.treeListView_Categories.TabIndex = 0;
      this.toolTip.SetToolTip(this.treeListView_Categories, "Categories, Authors and Books");
      this.treeListView_Categories.UseXPHighlightStyle = false;
      this.treeListView_Categories.SelectedIndexChanged += new System.EventHandler(this.treeListView_Categories_SelectedIndexChanged);
      this.treeListView_Categories.Enter += new System.EventHandler(this.treeListView_Categories_Enter);
      // 
      // columnHeader_Category
      // 
      this.columnHeader_Category.Text = "Category";
      this.columnHeader_Category.Width = 200;
      // 
      // columnHeader_Summary
      // 
      this.columnHeader_Summary.Text = "Statistics";
      this.columnHeader_Summary.Width = 70;
      // 
      // contextMenu_Categories
      // 
      this.contextMenu_Categories.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                           this.contextMenu_Categories_New,
                                                                                           this.contextMenu_Categories_Sep1,
                                                                                           this.contextMenu_Categories_Delete,
                                                                                           this.contextMenu_Categories_Sep2,
                                                                                           this.contextMenu_Categories_Refresh,
                                                                                           this.contextMenu_Categories_ToggleGridlines,
                                                                                           this.contextMenu_Categories_Sep3,
                                                                                           this.contextMenu_Categories_ShrinkAuthors,
                                                                                           this.contextMenu_Categories_ShowAll});
      this.contextMenu_Categories.Popup += new System.EventHandler(this.contextMenu_Categories_Popup);
      // 
      // contextMenu_Categories_New
      // 
      this.contextMenu_Categories_New.Index = 0;
      this.contextMenu_Categories_New.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                               this.contextMenu_Categories_New_Category,
                                                                                               this.contextMenu_Categories_New_Author,
                                                                                               this.contextMenu_Categories_New_Book});
      this.contextMenu_Categories_New.Text = "New...";
      this.contextMenu_Categories_New.Popup += new System.EventHandler(this.contextMenu_Categories_New_Popup);
      // 
      // contextMenu_Categories_New_Category
      // 
      this.contextMenu_Categories_New_Category.Index = 0;
      this.contextMenu_Categories_New_Category.Text = "Category";
      this.contextMenu_Categories_New_Category.Click += new System.EventHandler(this.contextMenu_Categories_New_Category_Click);
      // 
      // contextMenu_Categories_New_Author
      // 
      this.contextMenu_Categories_New_Author.Index = 1;
      this.contextMenu_Categories_New_Author.Text = "Author";
      this.contextMenu_Categories_New_Author.Click += new System.EventHandler(this.contextMenu_Categories_New_Author_Click);
      // 
      // contextMenu_Categories_New_Book
      // 
      this.contextMenu_Categories_New_Book.Index = 2;
      this.contextMenu_Categories_New_Book.Text = "Book";
      this.contextMenu_Categories_New_Book.Click += new System.EventHandler(this.contextMenu_Categories_New_Book_Click);
      // 
      // contextMenu_Categories_Sep1
      // 
      this.contextMenu_Categories_Sep1.Index = 1;
      this.contextMenu_Categories_Sep1.Text = "-";
      // 
      // contextMenu_Categories_Delete
      // 
      this.contextMenu_Categories_Delete.Index = 2;
      this.contextMenu_Categories_Delete.Shortcut = System.Windows.Forms.Shortcut.Del;
      this.contextMenu_Categories_Delete.Text = "Delete";
      this.contextMenu_Categories_Delete.Click += new System.EventHandler(this.contextMenu_Categories_Delete_Click);
      // 
      // contextMenu_Categories_Sep2
      // 
      this.contextMenu_Categories_Sep2.Index = 3;
      this.contextMenu_Categories_Sep2.Text = "-";
      // 
      // contextMenu_Categories_Refresh
      // 
      this.contextMenu_Categories_Refresh.Index = 4;
      this.contextMenu_Categories_Refresh.Text = "Refresh";
      this.contextMenu_Categories_Refresh.Click += new System.EventHandler(this.contextMenu_Categories_Refresh_Click);
      // 
      // contextMenu_Categories_ToggleGridlines
      // 
      this.contextMenu_Categories_ToggleGridlines.Index = 5;
      this.contextMenu_Categories_ToggleGridlines.Text = "Toggle Gridlines";
      this.contextMenu_Categories_ToggleGridlines.Click += new System.EventHandler(this.contextMenu_Categories_ToggleGridlines_Click);
      // 
      // contextMenu_Categories_Sep3
      // 
      this.contextMenu_Categories_Sep3.Index = 6;
      this.contextMenu_Categories_Sep3.Text = "-";
      // 
      // contextMenu_Categories_ShrinkAuthors
      // 
      this.contextMenu_Categories_ShrinkAuthors.Index = 7;
      this.contextMenu_Categories_ShrinkAuthors.Text = "Shrink to/View only Authors";
      this.contextMenu_Categories_ShrinkAuthors.Click += new System.EventHandler(this.contextMenu_Categories_ShrinkAuthors_Click);
      // 
      // contextMenu_Categories_ShowAll
      // 
      this.contextMenu_Categories_ShowAll.Index = 8;
      this.contextMenu_Categories_ShowAll.Text = "Expand/Collapse...";
      this.contextMenu_Categories_ShowAll.Click += new System.EventHandler(this.contextMenu_Categories_ShowAll_Click);
      // 
      // imageList
      // 
      this.imageList.ImageSize = new System.Drawing.Size(16, 16);
      this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
      this.imageList.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // dockControl_Search
      // 
      this.dockControl_Search.Closable = false;
      this.dockControl_Search.Controls.Add(this.groupBox_sb_Keyword);
      this.dockControl_Search.Controls.Add(this.button_Search);
      this.dockControl_Search.Controls.Add(this.groupBox_sb_Notes);
      this.dockControl_Search.Controls.Add(this.groupBox_sb_In);
      this.dockControl_Search.Controls.Add(this.groupBox_sbName);
      this.dockControl_Search.Controls.Add(this.groupBox_sbNationality);
      this.dockControl_Search.Controls.Add(this.groupBox_sbPublished);
      this.dockControl_Search.Guid = new System.Guid("23641ae2-6b8b-41e0-bce3-69d2237bc856");
      this.dockControl_Search.Location = new System.Drawing.Point(3, 23);
      this.dockControl_Search.Name = "dockControl_Search";
      this.dockControl_Search.Size = new System.Drawing.Size(286, 475);
      this.dockControl_Search.TabImage = ((System.Drawing.Image)(resources.GetObject("dockControl_Search.TabImage")));
      this.dockControl_Search.TabIndex = 1;
      this.dockControl_Search.Tag = "1";
      this.dockControl_Search.Text = "Search";
      // 
      // groupBox_sb_Keyword
      // 
      this.groupBox_sb_Keyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_sb_Keyword.Controls.Add(this.textBox_sbKeyword);
      this.groupBox_sb_Keyword.Location = new System.Drawing.Point(8, 8);
      this.groupBox_sb_Keyword.Name = "groupBox_sb_Keyword";
      this.groupBox_sb_Keyword.Size = new System.Drawing.Size(272, 52);
      this.groupBox_sb_Keyword.TabIndex = 8;
      this.groupBox_sb_Keyword.TabStop = false;
      this.groupBox_sb_Keyword.Text = "Search by keyword";
      // 
      // textBox_sbKeyword
      // 
      this.textBox_sbKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_sbKeyword.Location = new System.Drawing.Point(8, 24);
      this.textBox_sbKeyword.MaxLength = 255;
      this.textBox_sbKeyword.Name = "textBox_sbKeyword";
      this.textBox_sbKeyword.Size = new System.Drawing.Size(252, 20);
      this.textBox_sbKeyword.TabIndex = 1;
      this.textBox_sbKeyword.Text = "";
      this.toolTip.SetToolTip(this.textBox_sbKeyword, "Max length is 255 symbols");
      this.textBox_sbKeyword.WordWrap = false;
      // 
      // button_Search
      // 
      this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.button_Search.Location = new System.Drawing.Point(8, 436);
      this.button_Search.Name = "button_Search";
      this.button_Search.Size = new System.Drawing.Size(272, 28);
      this.button_Search.TabIndex = 7;
      this.button_Search.Text = "Search";
      this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
      // 
      // groupBox_sb_Notes
      // 
      this.groupBox_sb_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_sb_Notes.Controls.Add(this.textBox_sbNotes);
      this.groupBox_sb_Notes.Location = new System.Drawing.Point(8, 68);
      this.groupBox_sb_Notes.Name = "groupBox_sb_Notes";
      this.groupBox_sb_Notes.Size = new System.Drawing.Size(272, 52);
      this.groupBox_sb_Notes.TabIndex = 9;
      this.groupBox_sb_Notes.TabStop = false;
      this.groupBox_sb_Notes.Text = "Search in notes";
      // 
      // textBox_sbNotes
      // 
      this.textBox_sbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_sbNotes.Location = new System.Drawing.Point(8, 24);
      this.textBox_sbNotes.MaxLength = 255;
      this.textBox_sbNotes.Name = "textBox_sbNotes";
      this.textBox_sbNotes.Size = new System.Drawing.Size(252, 20);
      this.textBox_sbNotes.TabIndex = 3;
      this.textBox_sbNotes.Text = "";
      this.toolTip.SetToolTip(this.textBox_sbNotes, "Max length is 255 symbols");
      this.textBox_sbNotes.WordWrap = false;
      // 
      // groupBox_sb_In
      // 
      this.groupBox_sb_In.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_sb_In.Controls.Add(this.comboBox_sbIn);
      this.groupBox_sb_In.Location = new System.Drawing.Point(8, 376);
      this.groupBox_sb_In.Name = "groupBox_sb_In";
      this.groupBox_sb_In.Size = new System.Drawing.Size(272, 52);
      this.groupBox_sb_In.TabIndex = 10;
      this.groupBox_sb_In.TabStop = false;
      this.groupBox_sb_In.Text = "Search only in";
      // 
      // comboBox_sbIn
      // 
      this.comboBox_sbIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox_sbIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox_sbIn.Location = new System.Drawing.Point(8, 20);
      this.comboBox_sbIn.Name = "comboBox_sbIn";
      this.comboBox_sbIn.Size = new System.Drawing.Size(252, 24);
      this.comboBox_sbIn.TabIndex = 6;
      // 
      // groupBox_sbName
      // 
      this.groupBox_sbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_sbName.Controls.Add(this.textBox_sbName);
      this.groupBox_sbName.Location = new System.Drawing.Point(8, 128);
      this.groupBox_sbName.Name = "groupBox_sbName";
      this.groupBox_sbName.Size = new System.Drawing.Size(272, 52);
      this.groupBox_sbName.TabIndex = 11;
      this.groupBox_sbName.TabStop = false;
      this.groupBox_sbName.Text = "Search by author name / book title";
      // 
      // textBox_sbName
      // 
      this.textBox_sbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_sbName.Location = new System.Drawing.Point(8, 24);
      this.textBox_sbName.MaxLength = 255;
      this.textBox_sbName.Name = "textBox_sbName";
      this.textBox_sbName.Size = new System.Drawing.Size(252, 20);
      this.textBox_sbName.TabIndex = 4;
      this.textBox_sbName.Text = "";
      this.toolTip.SetToolTip(this.textBox_sbName, "Max length is 255 symbols");
      this.textBox_sbName.WordWrap = false;
      // 
      // groupBox_sbNationality
      // 
      this.groupBox_sbNationality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_sbNationality.Controls.Add(this.textBox_sbNationality);
      this.groupBox_sbNationality.Location = new System.Drawing.Point(8, 188);
      this.groupBox_sbNationality.Name = "groupBox_sbNationality";
      this.groupBox_sbNationality.Size = new System.Drawing.Size(272, 52);
      this.groupBox_sbNationality.TabIndex = 12;
      this.groupBox_sbNationality.TabStop = false;
      this.groupBox_sbNationality.Text = "Search by nationality";
      // 
      // textBox_sbNationality
      // 
      this.textBox_sbNationality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_sbNationality.Location = new System.Drawing.Point(8, 24);
      this.textBox_sbNationality.MaxLength = 255;
      this.textBox_sbNationality.Name = "textBox_sbNationality";
      this.textBox_sbNationality.Size = new System.Drawing.Size(252, 20);
      this.textBox_sbNationality.TabIndex = 4;
      this.textBox_sbNationality.Text = "";
      this.toolTip.SetToolTip(this.textBox_sbNationality, "Max length is 255 symbols");
      this.textBox_sbNationality.WordWrap = false;
      // 
      // groupBox_sbPublished
      // 
      this.groupBox_sbPublished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_sbPublished.Controls.Add(this.dateTimePicker_sbPublishedTo);
      this.groupBox_sbPublished.Controls.Add(this.dateTimePicker_sbPublishedFrom);
      this.groupBox_sbPublished.Location = new System.Drawing.Point(8, 248);
      this.groupBox_sbPublished.Name = "groupBox_sbPublished";
      this.groupBox_sbPublished.Size = new System.Drawing.Size(272, 88);
      this.groupBox_sbPublished.TabIndex = 13;
      this.groupBox_sbPublished.TabStop = false;
      this.groupBox_sbPublished.Text = "Search by nationality";
      // 
      // dateTimePicker_sbPublishedTo
      // 
      this.dateTimePicker_sbPublishedTo.Location = new System.Drawing.Point(8, 56);
      this.dateTimePicker_sbPublishedTo.Name = "dateTimePicker_sbPublishedTo";
      this.dateTimePicker_sbPublishedTo.Size = new System.Drawing.Size(252, 20);
      this.dateTimePicker_sbPublishedTo.TabIndex = 1;
      // 
      // dateTimePicker_sbPublishedFrom
      // 
      this.dateTimePicker_sbPublishedFrom.Location = new System.Drawing.Point(8, 24);
      this.dateTimePicker_sbPublishedFrom.Name = "dateTimePicker_sbPublishedFrom";
      this.dateTimePicker_sbPublishedFrom.Size = new System.Drawing.Size(252, 20);
      this.dateTimePicker_sbPublishedFrom.TabIndex = 0;
      // 
      // panel_Right
      // 
      this.panel_Right.Controls.Add(this.panel_Start);
      this.panel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Right.Location = new System.Drawing.Point(292, 24);
      this.panel_Right.Name = "panel_Right";
      this.panel_Right.Size = new System.Drawing.Size(664, 501);
      this.panel_Right.TabIndex = 3;
      // 
      // panel_Start
      // 
      this.panel_Start.Controls.Add(this.panel_MainTop);
      this.panel_Start.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Start.DockPadding.Left = 5;
      this.panel_Start.Location = new System.Drawing.Point(0, 0);
      this.panel_Start.Name = "panel_Start";
      this.panel_Start.Size = new System.Drawing.Size(664, 501);
      this.panel_Start.TabIndex = 1;
      // 
      // panel_MainTop
      // 
      this.panel_MainTop.Controls.Add(this.label_CategoryLabel);
      this.panel_MainTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel_MainTop.Location = new System.Drawing.Point(5, 0);
      this.panel_MainTop.Name = "panel_MainTop";
      this.panel_MainTop.Size = new System.Drawing.Size(659, 41);
      this.panel_MainTop.TabIndex = 15;
      // 
      // label_CategoryLabel
      // 
      this.label_CategoryLabel.BackColor = System.Drawing.Color.Navy;
      this.label_CategoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label_CategoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label_CategoryLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_CategoryLabel.ForeColor = System.Drawing.Color.White;
      this.label_CategoryLabel.Location = new System.Drawing.Point(0, 0);
      this.label_CategoryLabel.Name = "label_CategoryLabel";
      this.label_CategoryLabel.Size = new System.Drawing.Size(659, 41);
      this.label_CategoryLabel.TabIndex = 13;
      this.label_CategoryLabel.Text = "   RooBooks";
      this.label_CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel_MainBottom
      // 
      this.panel_MainBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.panel_MainBottom.Controls.Add(this.panel_Search);
      this.panel_MainBottom.Controls.Add(this.panel_Author);
      this.panel_MainBottom.Controls.Add(this.panel_Category);
      this.panel_MainBottom.Controls.Add(this.panel_Book);
      this.panel_MainBottom.Location = new System.Drawing.Point(5, 41);
      this.panel_MainBottom.Name = "panel_MainBottom";
      this.panel_MainBottom.Size = new System.Drawing.Size(659, 460);
      this.panel_MainBottom.TabIndex = 16;
      // 
      // panel_Search
      // 
      this.panel_Search.Controls.Add(this.documentContainer_SearchResults);
      this.panel_Search.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Search.Location = new System.Drawing.Point(0, 0);
      this.panel_Search.Name = "panel_Search";
      this.panel_Search.Size = new System.Drawing.Size(659, 460);
      this.panel_Search.TabIndex = 0;
      this.panel_Search.Visible = false;
      // 
      // documentContainer_SearchResults
      // 
      this.documentContainer_SearchResults.Controls.Add(this.dockControl_Authors);
      this.documentContainer_SearchResults.Controls.Add(this.dockControl_Books);
      this.documentContainer_SearchResults.Cursor = System.Windows.Forms.Cursors.Default;
      this.documentContainer_SearchResults.Guid = new System.Guid("4fc23aa3-61e9-451f-9bac-3aa5cc982627");
      this.documentContainer_SearchResults.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
                                                                                                                                                                                        new TD.SandDock.DocumentLayoutSystem(657, 458, new TD.SandDock.DockControl[] {
                                                                                                                                                                                                                                                                       this.dockControl_Authors,
                                                                                                                                                                                                                                                                       this.dockControl_Books}, this.dockControl_Authors)});
      this.documentContainer_SearchResults.Location = new System.Drawing.Point(0, 0);
      this.documentContainer_SearchResults.Manager = null;
      this.documentContainer_SearchResults.Name = "documentContainer_SearchResults";
      this.documentContainer_SearchResults.Size = new System.Drawing.Size(659, 460);
      this.documentContainer_SearchResults.TabIndex = 0;
      // 
      // dockControl_Authors
      // 
      this.dockControl_Authors.Closable = false;
      this.dockControl_Authors.Collapsible = false;
      this.dockControl_Authors.Controls.Add(this.panel_sr_AuthorsBottom);
      this.dockControl_Authors.Controls.Add(this.panel_sr_Authors);
      this.dockControl_Authors.Cursor = System.Windows.Forms.Cursors.Default;
      this.dockControl_Authors.Guid = new System.Guid("76706cca-bf7f-4d3d-bc33-1f61b6285eb2");
      this.dockControl_Authors.Location = new System.Drawing.Point(3, 23);
      this.dockControl_Authors.Name = "dockControl_Authors";
      this.dockControl_Authors.Size = new System.Drawing.Size(653, 434);
      this.dockControl_Authors.TabImage = ((System.Drawing.Image)(resources.GetObject("dockControl_Authors.TabImage")));
      this.dockControl_Authors.TabIndex = 0;
      this.dockControl_Authors.Text = "Authors";
      // 
      // panel_sr_AuthorsBottom
      // 
      this.panel_sr_AuthorsBottom.Controls.Add(this.button_sr_ViewAuthor);
      this.panel_sr_AuthorsBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel_sr_AuthorsBottom.Location = new System.Drawing.Point(0, 388);
      this.panel_sr_AuthorsBottom.Name = "panel_sr_AuthorsBottom";
      this.panel_sr_AuthorsBottom.Size = new System.Drawing.Size(653, 46);
      this.panel_sr_AuthorsBottom.TabIndex = 2;
      // 
      // button_sr_ViewAuthor
      // 
      this.button_sr_ViewAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button_sr_ViewAuthor.Enabled = false;
      this.button_sr_ViewAuthor.Location = new System.Drawing.Point(572, 12);
      this.button_sr_ViewAuthor.Name = "button_sr_ViewAuthor";
      this.button_sr_ViewAuthor.Size = new System.Drawing.Size(72, 23);
      this.button_sr_ViewAuthor.TabIndex = 0;
      this.button_sr_ViewAuthor.Text = "View";
      this.button_sr_ViewAuthor.Click += new System.EventHandler(this.button_sr_ViewAuthor_Click);
      // 
      // panel_sr_Authors
      // 
      this.panel_sr_Authors.Controls.Add(this.listView_sr_Authors);
      this.panel_sr_Authors.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_sr_Authors.Location = new System.Drawing.Point(0, 0);
      this.panel_sr_Authors.Name = "panel_sr_Authors";
      this.panel_sr_Authors.Size = new System.Drawing.Size(653, 434);
      this.panel_sr_Authors.TabIndex = 1;
      // 
      // listView_sr_Authors
      // 
      this.listView_sr_Authors.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listView_sr_Authors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                          this.columnHeader_sra_ID,
                                                                                          this.columnHeader_sra_Name,
                                                                                          this.columnHeader_sra_Category,
                                                                                          this.columnHeader_sra_Nationality,
                                                                                          this.columnHeader_sra_BirthPlace,
                                                                                          this.columnHeader_sra_Modified,
                                                                                          this.columnHeader_sra_Created});
      this.listView_sr_Authors.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listView_sr_Authors.FullRowSelect = true;
      this.listView_sr_Authors.GridLines = true;
      this.listView_sr_Authors.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
                                                                                        listViewItem1,
                                                                                        listViewItem2,
                                                                                        listViewItem3});
      this.listView_sr_Authors.Location = new System.Drawing.Point(0, 0);
      this.listView_sr_Authors.Name = "listView_sr_Authors";
      this.listView_sr_Authors.Size = new System.Drawing.Size(653, 434);
      this.listView_sr_Authors.TabIndex = 0;
      this.listView_sr_Authors.View = System.Windows.Forms.View.Details;
      this.listView_sr_Authors.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_sr_Authors_ColumnClick);
      // 
      // columnHeader_sra_ID
      // 
      this.columnHeader_sra_ID.Text = "ID";
      this.columnHeader_sra_ID.Width = 0;
      // 
      // columnHeader_sra_Name
      // 
      this.columnHeader_sra_Name.Text = "Name";
      this.columnHeader_sra_Name.Width = 180;
      // 
      // columnHeader_sra_Category
      // 
      this.columnHeader_sra_Category.Text = "Category";
      // 
      // columnHeader_sra_Nationality
      // 
      this.columnHeader_sra_Nationality.Text = "Nationality";
      this.columnHeader_sra_Nationality.Width = 135;
      // 
      // columnHeader_sra_BirthPlace
      // 
      this.columnHeader_sra_BirthPlace.Text = "BirthPlace";
      this.columnHeader_sra_BirthPlace.Width = 131;
      // 
      // columnHeader_sra_Modified
      // 
      this.columnHeader_sra_Modified.Text = "Modified @";
      this.columnHeader_sra_Modified.Width = 70;
      // 
      // columnHeader_sra_Created
      // 
      this.columnHeader_sra_Created.Text = "Created @";
      this.columnHeader_sra_Created.Width = 71;
      // 
      // dockControl_Books
      // 
      this.dockControl_Books.Closable = false;
      this.dockControl_Books.Collapsible = false;
      this.dockControl_Books.Controls.Add(this.panel_sr_Books);
      this.dockControl_Books.Controls.Add(this.panel_sr_Books_Bottom);
      this.dockControl_Books.Guid = new System.Guid("10969cd3-f244-4e03-ad9e-91bcc827f9ab");
      this.dockControl_Books.Location = new System.Drawing.Point(3, 23);
      this.dockControl_Books.Name = "dockControl_Books";
      this.dockControl_Books.Size = new System.Drawing.Size(653, 434);
      this.dockControl_Books.TabImage = ((System.Drawing.Image)(resources.GetObject("dockControl_Books.TabImage")));
      this.dockControl_Books.TabIndex = 1;
      this.dockControl_Books.Text = "Books";
      // 
      // panel_sr_Books
      // 
      this.panel_sr_Books.Controls.Add(this.listView_sr_Books);
      this.panel_sr_Books.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_sr_Books.Location = new System.Drawing.Point(0, 0);
      this.panel_sr_Books.Name = "panel_sr_Books";
      this.panel_sr_Books.Size = new System.Drawing.Size(653, 388);
      this.panel_sr_Books.TabIndex = 2;
      // 
      // listView_sr_Books
      // 
      this.listView_sr_Books.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listView_sr_Books.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                        this.columnHeader_srb_ID,
                                                                                        this.columnHeader_srb_Title,
                                                                                        this.columnHeader_srb_Author,
                                                                                        this.columnHeader_srb_Genre,
                                                                                        this.columnHeader_srb_Modified,
                                                                                        this.columnHeader_srb_Created});
      this.listView_sr_Books.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listView_sr_Books.FullRowSelect = true;
      this.listView_sr_Books.GridLines = true;
      this.listView_sr_Books.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
                                                                                      listViewItem4,
                                                                                      listViewItem5,
                                                                                      listViewItem6});
      this.listView_sr_Books.Location = new System.Drawing.Point(0, 0);
      this.listView_sr_Books.Name = "listView_sr_Books";
      this.listView_sr_Books.Size = new System.Drawing.Size(653, 388);
      this.listView_sr_Books.TabIndex = 0;
      this.listView_sr_Books.View = System.Windows.Forms.View.Details;
      this.listView_sr_Books.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_sr_Books_ColumnClick);
      // 
      // columnHeader_srb_ID
      // 
      this.columnHeader_srb_ID.Text = "ID";
      this.columnHeader_srb_ID.Width = 0;
      // 
      // columnHeader_srb_Title
      // 
      this.columnHeader_srb_Title.Text = "Title";
      this.columnHeader_srb_Title.Width = 328;
      // 
      // columnHeader_srb_Author
      // 
      this.columnHeader_srb_Author.Text = "Author";
      // 
      // columnHeader_srb_Genre
      // 
      this.columnHeader_srb_Genre.Text = "Genre";
      this.columnHeader_srb_Genre.Width = 163;
      // 
      // columnHeader_srb_Modified
      // 
      this.columnHeader_srb_Modified.Text = "Modified @";
      this.columnHeader_srb_Modified.Width = 78;
      // 
      // columnHeader_srb_Created
      // 
      this.columnHeader_srb_Created.Text = "Created @";
      this.columnHeader_srb_Created.Width = 77;
      // 
      // panel_sr_Books_Bottom
      // 
      this.panel_sr_Books_Bottom.Controls.Add(this.button_sr_ViewBook);
      this.panel_sr_Books_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel_sr_Books_Bottom.Location = new System.Drawing.Point(0, 388);
      this.panel_sr_Books_Bottom.Name = "panel_sr_Books_Bottom";
      this.panel_sr_Books_Bottom.Size = new System.Drawing.Size(653, 46);
      this.panel_sr_Books_Bottom.TabIndex = 3;
      // 
      // button_sr_ViewBook
      // 
      this.button_sr_ViewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button_sr_ViewBook.Enabled = false;
      this.button_sr_ViewBook.Location = new System.Drawing.Point(572, 12);
      this.button_sr_ViewBook.Name = "button_sr_ViewBook";
      this.button_sr_ViewBook.Size = new System.Drawing.Size(72, 23);
      this.button_sr_ViewBook.TabIndex = 0;
      this.button_sr_ViewBook.Text = "View";
      this.button_sr_ViewBook.Click += new System.EventHandler(this.button_sr_ViewBook_Click);
      // 
      // panel_Author
      // 
      this.panel_Author.Controls.Add(this.splitter_Book);
      this.panel_Author.Controls.Add(this.panel_Author_Bottom);
      this.panel_Author.Controls.Add(this.panel_Author_Top);
      this.panel_Author.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Author.Location = new System.Drawing.Point(0, 0);
      this.panel_Author.Name = "panel_Author";
      this.panel_Author.Size = new System.Drawing.Size(659, 460);
      this.panel_Author.TabIndex = 1;
      // 
      // splitter_Book
      // 
      this.splitter_Book.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter_Book.Location = new System.Drawing.Point(0, 124);
      this.splitter_Book.Name = "splitter_Book";
      this.splitter_Book.Size = new System.Drawing.Size(659, 3);
      this.splitter_Book.TabIndex = 5;
      this.splitter_Book.TabStop = false;
      // 
      // panel_Author_Bottom
      // 
      this.panel_Author_Bottom.Controls.Add(this.label_BD_Edit);
      this.panel_Author_Bottom.Controls.Add(this.groupBox_BT_BT);
      this.panel_Author_Bottom.Controls.Add(this.groupBox_BD_Notes);
      this.panel_Author_Bottom.Controls.Add(this.button_BD_Save);
      this.panel_Author_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Author_Bottom.Location = new System.Drawing.Point(0, 124);
      this.panel_Author_Bottom.Name = "panel_Author_Bottom";
      this.panel_Author_Bottom.Size = new System.Drawing.Size(659, 336);
      this.panel_Author_Bottom.TabIndex = 4;
      // 
      // label_BD_Edit
      // 
      this.label_BD_Edit.BackColor = System.Drawing.SystemColors.Info;
      this.label_BD_Edit.Dock = System.Windows.Forms.DockStyle.Top;
      this.label_BD_Edit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_BD_Edit.Location = new System.Drawing.Point(0, 0);
      this.label_BD_Edit.Name = "label_BD_Edit";
      this.label_BD_Edit.Size = new System.Drawing.Size(659, 35);
      this.label_BD_Edit.TabIndex = 7;
      this.label_BD_Edit.Text = "   Edit";
      this.label_BD_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // groupBox_BT_BT
      // 
      this.groupBox_BT_BT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_BT_BT.Controls.Add(this.label1);
      this.groupBox_BT_BT.Controls.Add(this.dateTimePicker_BD_Published);
      this.groupBox_BT_BT.Controls.Add(this.label_BD_Summary);
      this.groupBox_BT_BT.Controls.Add(this.label_BD_Genre);
      this.groupBox_BT_BT.Controls.Add(this.comboBox_BD_Genres);
      this.groupBox_BT_BT.Controls.Add(this.textBox_BD_Keywords);
      this.groupBox_BT_BT.Controls.Add(this.label_BD_Keywords);
      this.groupBox_BT_BT.Controls.Add(this.textBox_BD_Title);
      this.groupBox_BT_BT.Controls.Add(this.label_BD_Title);
      this.groupBox_BT_BT.Controls.Add(this.textBox_BD_Summary);
      this.groupBox_BT_BT.Location = new System.Drawing.Point(376, 36);
      this.groupBox_BT_BT.Name = "groupBox_BT_BT";
      this.groupBox_BT_BT.Size = new System.Drawing.Size(280, 176);
      this.groupBox_BT_BT.TabIndex = 5;
      this.groupBox_BT_BT.TabStop = false;
      this.groupBox_BT_BT.Text = "Book Data";
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label1.Location = new System.Drawing.Point(9, 143);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(88, 20);
      this.label1.TabIndex = 14;
      this.label1.Text = "Publish Date :";
      // 
      // dateTimePicker_BD_Published
      // 
      this.dateTimePicker_BD_Published.CustomFormat = "dd/MM/yyyy";
      this.dateTimePicker_BD_Published.Enabled = false;
      this.dateTimePicker_BD_Published.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.dateTimePicker_BD_Published.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTimePicker_BD_Published.Location = new System.Drawing.Point(108, 143);
      this.dateTimePicker_BD_Published.Name = "dateTimePicker_BD_Published";
      this.dateTimePicker_BD_Published.Size = new System.Drawing.Size(166, 20);
      this.dateTimePicker_BD_Published.TabIndex = 15;
      this.toolTip.SetToolTip(this.dateTimePicker_BD_Published, "Choose date of birth");
      // 
      // label_BD_Summary
      // 
      this.label_BD_Summary.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_BD_Summary.Location = new System.Drawing.Point(9, 83);
      this.label_BD_Summary.Name = "label_BD_Summary";
      this.label_BD_Summary.Size = new System.Drawing.Size(88, 20);
      this.label_BD_Summary.TabIndex = 12;
      this.label_BD_Summary.Text = "Summary :";
      this.label_BD_Summary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label_BD_Genre
      // 
      this.label_BD_Genre.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_BD_Genre.Location = new System.Drawing.Point(9, 53);
      this.label_BD_Genre.Name = "label_BD_Genre";
      this.label_BD_Genre.Size = new System.Drawing.Size(88, 20);
      this.label_BD_Genre.TabIndex = 2;
      this.label_BD_Genre.Text = "Genre :";
      this.label_BD_Genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // comboBox_BD_Genres
      // 
      this.comboBox_BD_Genres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox_BD_Genres.Enabled = false;
      this.comboBox_BD_Genres.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.comboBox_BD_Genres.ItemHeight = 16;
      this.comboBox_BD_Genres.Location = new System.Drawing.Point(108, 53);
      this.comboBox_BD_Genres.Name = "comboBox_BD_Genres";
      this.comboBox_BD_Genres.Size = new System.Drawing.Size(166, 24);
      this.comboBox_BD_Genres.TabIndex = 9;
      this.toolTip.SetToolTip(this.comboBox_BD_Genres, "Enter book\'s genre");
      // 
      // textBox_BD_Keywords
      // 
      this.textBox_BD_Keywords.Enabled = false;
      this.textBox_BD_Keywords.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.textBox_BD_Keywords.Location = new System.Drawing.Point(108, 113);
      this.textBox_BD_Keywords.Name = "textBox_BD_Keywords";
      this.textBox_BD_Keywords.Size = new System.Drawing.Size(166, 20);
      this.textBox_BD_Keywords.TabIndex = 11;
      this.textBox_BD_Keywords.Text = "";
      this.toolTip.SetToolTip(this.textBox_BD_Keywords, "Enter search keywords");
      // 
      // label_BD_Keywords
      // 
      this.label_BD_Keywords.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_BD_Keywords.Location = new System.Drawing.Point(9, 113);
      this.label_BD_Keywords.Name = "label_BD_Keywords";
      this.label_BD_Keywords.Size = new System.Drawing.Size(88, 20);
      this.label_BD_Keywords.TabIndex = 10;
      this.label_BD_Keywords.Text = "Keywords :";
      this.label_BD_Keywords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // textBox_BD_Title
      // 
      this.textBox_BD_Title.Enabled = false;
      this.textBox_BD_Title.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.textBox_BD_Title.Location = new System.Drawing.Point(108, 23);
      this.textBox_BD_Title.Name = "textBox_BD_Title";
      this.textBox_BD_Title.Size = new System.Drawing.Size(166, 20);
      this.textBox_BD_Title.TabIndex = 1;
      this.textBox_BD_Title.Text = "";
      this.toolTip.SetToolTip(this.textBox_BD_Title, "Enter book\'s title");
      // 
      // label_BD_Title
      // 
      this.label_BD_Title.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_BD_Title.Location = new System.Drawing.Point(9, 23);
      this.label_BD_Title.Name = "label_BD_Title";
      this.label_BD_Title.Size = new System.Drawing.Size(88, 20);
      this.label_BD_Title.TabIndex = 0;
      this.label_BD_Title.Text = "Book Title :";
      this.label_BD_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // textBox_BD_Summary
      // 
      this.textBox_BD_Summary.Enabled = false;
      this.textBox_BD_Summary.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.textBox_BD_Summary.Location = new System.Drawing.Point(108, 83);
      this.textBox_BD_Summary.Name = "textBox_BD_Summary";
      this.textBox_BD_Summary.Size = new System.Drawing.Size(166, 20);
      this.textBox_BD_Summary.TabIndex = 8;
      this.textBox_BD_Summary.Text = "";
      this.toolTip.SetToolTip(this.textBox_BD_Summary, "Enter brief summary");
      // 
      // groupBox_BD_Notes
      // 
      this.groupBox_BD_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_BD_Notes.Controls.Add(this.richTextBox_BD_Notes);
      this.groupBox_BD_Notes.Location = new System.Drawing.Point(3, 36);
      this.groupBox_BD_Notes.Name = "groupBox_BD_Notes";
      this.groupBox_BD_Notes.Size = new System.Drawing.Size(372, 299);
      this.groupBox_BD_Notes.TabIndex = 6;
      this.groupBox_BD_Notes.TabStop = false;
      this.groupBox_BD_Notes.Text = "Notes";
      // 
      // richTextBox_BD_Notes
      // 
      this.richTextBox_BD_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox_BD_Notes.Enabled = false;
      this.richTextBox_BD_Notes.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.richTextBox_BD_Notes.Location = new System.Drawing.Point(3, 16);
      this.richTextBox_BD_Notes.Name = "richTextBox_BD_Notes";
      this.richTextBox_BD_Notes.Size = new System.Drawing.Size(366, 280);
      this.richTextBox_BD_Notes.TabIndex = 4;
      this.richTextBox_BD_Notes.Text = "";
      this.toolTip.SetToolTip(this.richTextBox_BD_Notes, "Enter notes here");
      // 
      // button_BD_Save
      // 
      this.button_BD_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_BD_Save.Enabled = false;
      this.button_BD_Save.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.button_BD_Save.Location = new System.Drawing.Point(380, 300);
      this.button_BD_Save.Name = "button_BD_Save";
      this.button_BD_Save.Size = new System.Drawing.Size(272, 30);
      this.button_BD_Save.TabIndex = 5;
      this.button_BD_Save.Text = "Save";
      this.toolTip.SetToolTip(this.button_BD_Save, "Save changes");
      this.button_BD_Save.Click += new System.EventHandler(this.button_BD_Save_Click);
      // 
      // panel_Author_Top
      // 
      this.panel_Author_Top.Controls.Add(this.listView_Books);
      this.panel_Author_Top.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel_Author_Top.Location = new System.Drawing.Point(0, 0);
      this.panel_Author_Top.Name = "panel_Author_Top";
      this.panel_Author_Top.Size = new System.Drawing.Size(659, 124);
      this.panel_Author_Top.TabIndex = 3;
      // 
      // listView_Books
      // 
      this.listView_Books.AllowColumnReorder = true;
      this.listView_Books.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listView_Books.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                     this.columnHeader_AB_ID,
                                                                                     this.columnHeader_AB_Title,
                                                                                     this.columnHeader_AB_Genre,
                                                                                     this.columnHeader_AB_Published,
                                                                                     this.columnHeader_AB_ModifiedDate,
                                                                                     this.columnHeader_AB_CreatedDate});
      this.listView_Books.ContextMenu = this.contextMenu_AuthorBooks;
      this.listView_Books.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listView_Books.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.listView_Books.FullRowSelect = true;
      this.listView_Books.GridLines = true;
      this.listView_Books.LabelWrap = false;
      this.listView_Books.Location = new System.Drawing.Point(0, 0);
      this.listView_Books.Name = "listView_Books";
      this.listView_Books.Size = new System.Drawing.Size(659, 124);
      this.listView_Books.TabIndex = 1;
      this.listView_Books.View = System.Windows.Forms.View.Details;
      this.listView_Books.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Books_ColumnClick);
      this.listView_Books.Enter += new System.EventHandler(this.listView_Books_Enter);
      this.listView_Books.SelectedIndexChanged += new System.EventHandler(this.listView_Books_SelectedIndexChanged);
      // 
      // columnHeader_AB_ID
      // 
      this.columnHeader_AB_ID.Text = "ID";
      this.columnHeader_AB_ID.Width = 0;
      // 
      // columnHeader_AB_Title
      // 
      this.columnHeader_AB_Title.Text = "Title";
      this.columnHeader_AB_Title.Width = 200;
      // 
      // columnHeader_AB_Genre
      // 
      this.columnHeader_AB_Genre.Text = "Genre";
      this.columnHeader_AB_Genre.Width = 131;
      // 
      // columnHeader_AB_Published
      // 
      this.columnHeader_AB_Published.Text = "Published @";
      this.columnHeader_AB_Published.Width = 78;
      // 
      // columnHeader_AB_ModifiedDate
      // 
      this.columnHeader_AB_ModifiedDate.Text = "Modified @";
      this.columnHeader_AB_ModifiedDate.Width = 71;
      // 
      // columnHeader_AB_CreatedDate
      // 
      this.columnHeader_AB_CreatedDate.Text = "Created @";
      this.columnHeader_AB_CreatedDate.Width = 71;
      // 
      // contextMenu_AuthorBooks
      // 
      this.contextMenu_AuthorBooks.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                            this.menuItem_AuthorBooks_AddNew,
                                                                                            this.menuItem_AuthorBooks_DeleteThis,
                                                                                            this.menuItem_AuthorBooks_Sep1,
                                                                                            this.menuItem_AuthorBooks_ReletadBooks,
                                                                                            this.menuItem_AuthorBooks_Sep2,
                                                                                            this.menuItem_AuthorBooks_ToggleGridlines});
      this.contextMenu_AuthorBooks.Popup += new System.EventHandler(this.contextMenu_AuthorBooks_Popup);
      // 
      // menuItem_AuthorBooks_AddNew
      // 
      this.menuItem_AuthorBooks_AddNew.Index = 0;
      this.menuItem_AuthorBooks_AddNew.Text = "Add new Book";
      this.menuItem_AuthorBooks_AddNew.Click += new System.EventHandler(this.menuItem_AuthorBooks_AddNew_Click);
      // 
      // menuItem_AuthorBooks_DeleteThis
      // 
      this.menuItem_AuthorBooks_DeleteThis.Index = 1;
      this.menuItem_AuthorBooks_DeleteThis.Text = "Delete this Book";
      this.menuItem_AuthorBooks_DeleteThis.Click += new System.EventHandler(this.menuItem_AuthorBooks_DeleteThis_Click);
      // 
      // menuItem_AuthorBooks_Sep1
      // 
      this.menuItem_AuthorBooks_Sep1.Index = 2;
      this.menuItem_AuthorBooks_Sep1.Text = "-";
      // 
      // menuItem_AuthorBooks_ReletadBooks
      // 
      this.menuItem_AuthorBooks_ReletadBooks.Index = 3;
      this.menuItem_AuthorBooks_ReletadBooks.Text = "Related Books";
      this.menuItem_AuthorBooks_ReletadBooks.Click += new System.EventHandler(this.menuItem_AuthorBooks_ReletadBooks_Click);
      // 
      // menuItem_AuthorBooks_Sep2
      // 
      this.menuItem_AuthorBooks_Sep2.Index = 4;
      this.menuItem_AuthorBooks_Sep2.Text = "-";
      // 
      // menuItem_AuthorBooks_ToggleGridlines
      // 
      this.menuItem_AuthorBooks_ToggleGridlines.Index = 5;
      this.menuItem_AuthorBooks_ToggleGridlines.Text = "Toggle Gridlines";
      this.menuItem_AuthorBooks_ToggleGridlines.Click += new System.EventHandler(this.menuItem_AuthorBooks_ToggleGridlines_Click);
      // 
      // panel_Category
      // 
      this.panel_Category.Controls.Add(this.splitter_Category);
      this.panel_Category.Controls.Add(this.panel_Category_Bottom);
      this.panel_Category.Controls.Add(this.panel_Category_Top);
      this.panel_Category.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Category.Location = new System.Drawing.Point(0, 0);
      this.panel_Category.Name = "panel_Category";
      this.panel_Category.Size = new System.Drawing.Size(659, 460);
      this.panel_Category.TabIndex = 15;
      // 
      // splitter_Category
      // 
      this.splitter_Category.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter_Category.Location = new System.Drawing.Point(0, 124);
      this.splitter_Category.Name = "splitter_Category";
      this.splitter_Category.Size = new System.Drawing.Size(659, 3);
      this.splitter_Category.TabIndex = 14;
      this.splitter_Category.TabStop = false;
      // 
      // panel_Category_Bottom
      // 
      this.panel_Category_Bottom.Controls.Add(this.label_AU_Edit);
      this.panel_Category_Bottom.Controls.Add(this.groupBox_AD_PD);
      this.panel_Category_Bottom.Controls.Add(this.groupBox_AD_N);
      this.panel_Category_Bottom.Controls.Add(this.button_Save);
      this.panel_Category_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Category_Bottom.Location = new System.Drawing.Point(0, 124);
      this.panel_Category_Bottom.Name = "panel_Category_Bottom";
      this.panel_Category_Bottom.Size = new System.Drawing.Size(659, 336);
      this.panel_Category_Bottom.TabIndex = 13;
      // 
      // label_AU_Edit
      // 
      this.label_AU_Edit.BackColor = System.Drawing.SystemColors.Info;
      this.label_AU_Edit.Dock = System.Windows.Forms.DockStyle.Top;
      this.label_AU_Edit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_AU_Edit.Location = new System.Drawing.Point(0, 0);
      this.label_AU_Edit.Name = "label_AU_Edit";
      this.label_AU_Edit.Size = new System.Drawing.Size(659, 35);
      this.label_AU_Edit.TabIndex = 17;
      this.label_AU_Edit.Text = "   Edit";
      this.label_AU_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // groupBox_AD_PD
      // 
      this.groupBox_AD_PD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_AD_PD.Controls.Add(this.label_AuthorData8);
      this.groupBox_AD_PD.Controls.Add(this.label_AuthorData1);
      this.groupBox_AD_PD.Controls.Add(this.label_AuthorData6);
      this.groupBox_AD_PD.Controls.Add(this.label_AuthorData4);
      this.groupBox_AD_PD.Controls.Add(this.label_AuthorData2);
      this.groupBox_AD_PD.Controls.Add(this.textBox_AuthorData_Nationality);
      this.groupBox_AD_PD.Controls.Add(this.textBox_AuthorData_FirstName);
      this.groupBox_AD_PD.Controls.Add(this.dateTimePicker_AuthorData_BirthDate);
      this.groupBox_AD_PD.Controls.Add(this.textBox_AuthorData_Summary);
      this.groupBox_AD_PD.Controls.Add(this.textBox_AuthorData_Keywords);
      this.groupBox_AD_PD.Controls.Add(this.label_AuthorData7);
      this.groupBox_AD_PD.Controls.Add(this.label_AuthorData3);
      this.groupBox_AD_PD.Controls.Add(this.label_AuthorData5);
      this.groupBox_AD_PD.Controls.Add(this.textBox_AuthorData_LastName);
      this.groupBox_AD_PD.Controls.Add(this.textBox_AuthorData_BirthPlace);
      this.groupBox_AD_PD.Controls.Add(this.dateTimePicker_AuthorData_DateOfDeath);
      this.groupBox_AD_PD.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.groupBox_AD_PD.Location = new System.Drawing.Point(376, 36);
      this.groupBox_AD_PD.Name = "groupBox_AD_PD";
      this.groupBox_AD_PD.Size = new System.Drawing.Size(280, 260);
      this.groupBox_AD_PD.TabIndex = 16;
      this.groupBox_AD_PD.TabStop = false;
      this.groupBox_AD_PD.Text = "Personal Data";
      // 
      // label_AuthorData8
      // 
      this.label_AuthorData8.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_AuthorData8.Location = new System.Drawing.Point(9, 203);
      this.label_AuthorData8.Name = "label_AuthorData8";
      this.label_AuthorData8.Size = new System.Drawing.Size(88, 20);
      this.label_AuthorData8.TabIndex = 19;
      this.label_AuthorData8.Text = "Keywords :";
      this.toolTip.SetToolTip(this.label_AuthorData8, "Separated with commas (,)");
      // 
      // label_AuthorData1
      // 
      this.label_AuthorData1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_AuthorData1.Location = new System.Drawing.Point(9, 23);
      this.label_AuthorData1.Name = "label_AuthorData1";
      this.label_AuthorData1.Size = new System.Drawing.Size(88, 20);
      this.label_AuthorData1.TabIndex = 3;
      this.label_AuthorData1.Text = "First Name :";
      // 
      // label_AuthorData6
      // 
      this.label_AuthorData6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_AuthorData6.Location = new System.Drawing.Point(9, 233);
      this.label_AuthorData6.Name = "label_AuthorData6";
      this.label_AuthorData6.Size = new System.Drawing.Size(88, 20);
      this.label_AuthorData6.TabIndex = 9;
      this.label_AuthorData6.Text = "Summary :";
      // 
      // label_AuthorData4
      // 
      this.label_AuthorData4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_AuthorData4.Location = new System.Drawing.Point(9, 143);
      this.label_AuthorData4.Name = "label_AuthorData4";
      this.label_AuthorData4.Size = new System.Drawing.Size(88, 20);
      this.label_AuthorData4.TabIndex = 7;
      this.label_AuthorData4.Text = "Birth Date :";
      // 
      // label_AuthorData2
      // 
      this.label_AuthorData2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_AuthorData2.Location = new System.Drawing.Point(9, 83);
      this.label_AuthorData2.Name = "label_AuthorData2";
      this.label_AuthorData2.Size = new System.Drawing.Size(88, 20);
      this.label_AuthorData2.TabIndex = 5;
      this.label_AuthorData2.Text = "Nationality :";
      // 
      // textBox_AuthorData_Nationality
      // 
      this.textBox_AuthorData_Nationality.Enabled = false;
      this.textBox_AuthorData_Nationality.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.textBox_AuthorData_Nationality.Location = new System.Drawing.Point(108, 83);
      this.textBox_AuthorData_Nationality.Name = "textBox_AuthorData_Nationality";
      this.textBox_AuthorData_Nationality.Size = new System.Drawing.Size(166, 20);
      this.textBox_AuthorData_Nationality.TabIndex = 11;
      this.textBox_AuthorData_Nationality.Text = "";
      this.toolTip.SetToolTip(this.textBox_AuthorData_Nationality, "Enter nationality");
      // 
      // textBox_AuthorData_FirstName
      // 
      this.textBox_AuthorData_FirstName.Enabled = false;
      this.textBox_AuthorData_FirstName.Location = new System.Drawing.Point(108, 23);
      this.textBox_AuthorData_FirstName.Name = "textBox_AuthorData_FirstName";
      this.textBox_AuthorData_FirstName.Size = new System.Drawing.Size(166, 20);
      this.textBox_AuthorData_FirstName.TabIndex = 10;
      this.textBox_AuthorData_FirstName.Text = "";
      this.toolTip.SetToolTip(this.textBox_AuthorData_FirstName, "Enter first name");
      // 
      // dateTimePicker_AuthorData_BirthDate
      // 
      this.dateTimePicker_AuthorData_BirthDate.CustomFormat = "dd/MM/yyyy";
      this.dateTimePicker_AuthorData_BirthDate.Enabled = false;
      this.dateTimePicker_AuthorData_BirthDate.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.dateTimePicker_AuthorData_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTimePicker_AuthorData_BirthDate.Location = new System.Drawing.Point(108, 143);
      this.dateTimePicker_AuthorData_BirthDate.Name = "dateTimePicker_AuthorData_BirthDate";
      this.dateTimePicker_AuthorData_BirthDate.Size = new System.Drawing.Size(166, 20);
      this.dateTimePicker_AuthorData_BirthDate.TabIndex = 13;
      this.toolTip.SetToolTip(this.dateTimePicker_AuthorData_BirthDate, "Choose date of birth");
      // 
      // textBox_AuthorData_Summary
      // 
      this.textBox_AuthorData_Summary.Enabled = false;
      this.textBox_AuthorData_Summary.Location = new System.Drawing.Point(108, 233);
      this.textBox_AuthorData_Summary.Name = "textBox_AuthorData_Summary";
      this.textBox_AuthorData_Summary.Size = new System.Drawing.Size(166, 20);
      this.textBox_AuthorData_Summary.TabIndex = 15;
      this.textBox_AuthorData_Summary.Text = "";
      this.toolTip.SetToolTip(this.textBox_AuthorData_Summary, "ENter brief summary");
      // 
      // textBox_AuthorData_Keywords
      // 
      this.textBox_AuthorData_Keywords.Enabled = false;
      this.textBox_AuthorData_Keywords.Location = new System.Drawing.Point(108, 203);
      this.textBox_AuthorData_Keywords.Name = "textBox_AuthorData_Keywords";
      this.textBox_AuthorData_Keywords.Size = new System.Drawing.Size(166, 20);
      this.textBox_AuthorData_Keywords.TabIndex = 20;
      this.textBox_AuthorData_Keywords.Text = "";
      this.toolTip.SetToolTip(this.textBox_AuthorData_Keywords, "Enter search keywords separated by comma");
      // 
      // label_AuthorData7
      // 
      this.label_AuthorData7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_AuthorData7.Location = new System.Drawing.Point(9, 53);
      this.label_AuthorData7.Name = "label_AuthorData7";
      this.label_AuthorData7.Size = new System.Drawing.Size(88, 20);
      this.label_AuthorData7.TabIndex = 17;
      this.label_AuthorData7.Text = "Last Name :";
      // 
      // label_AuthorData3
      // 
      this.label_AuthorData3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_AuthorData3.Location = new System.Drawing.Point(9, 113);
      this.label_AuthorData3.Name = "label_AuthorData3";
      this.label_AuthorData3.Size = new System.Drawing.Size(88, 20);
      this.label_AuthorData3.TabIndex = 6;
      this.label_AuthorData3.Text = "Birth Place :";
      // 
      // label_AuthorData5
      // 
      this.label_AuthorData5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.label_AuthorData5.Location = new System.Drawing.Point(9, 173);
      this.label_AuthorData5.Name = "label_AuthorData5";
      this.label_AuthorData5.Size = new System.Drawing.Size(88, 20);
      this.label_AuthorData5.TabIndex = 8;
      this.label_AuthorData5.Text = "Date of Death :";
      // 
      // textBox_AuthorData_LastName
      // 
      this.textBox_AuthorData_LastName.Enabled = false;
      this.textBox_AuthorData_LastName.Location = new System.Drawing.Point(108, 53);
      this.textBox_AuthorData_LastName.Name = "textBox_AuthorData_LastName";
      this.textBox_AuthorData_LastName.Size = new System.Drawing.Size(166, 20);
      this.textBox_AuthorData_LastName.TabIndex = 18;
      this.textBox_AuthorData_LastName.Text = "";
      this.toolTip.SetToolTip(this.textBox_AuthorData_LastName, "Enter last name");
      // 
      // textBox_AuthorData_BirthPlace
      // 
      this.textBox_AuthorData_BirthPlace.Enabled = false;
      this.textBox_AuthorData_BirthPlace.Location = new System.Drawing.Point(108, 113);
      this.textBox_AuthorData_BirthPlace.Name = "textBox_AuthorData_BirthPlace";
      this.textBox_AuthorData_BirthPlace.Size = new System.Drawing.Size(166, 20);
      this.textBox_AuthorData_BirthPlace.TabIndex = 12;
      this.textBox_AuthorData_BirthPlace.Text = "";
      this.toolTip.SetToolTip(this.textBox_AuthorData_BirthPlace, "Enter place of birth");
      // 
      // dateTimePicker_AuthorData_DateOfDeath
      // 
      this.dateTimePicker_AuthorData_DateOfDeath.CustomFormat = "dd/MM/yyyy";
      this.dateTimePicker_AuthorData_DateOfDeath.Enabled = false;
      this.dateTimePicker_AuthorData_DateOfDeath.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.dateTimePicker_AuthorData_DateOfDeath.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTimePicker_AuthorData_DateOfDeath.Location = new System.Drawing.Point(108, 173);
      this.dateTimePicker_AuthorData_DateOfDeath.Name = "dateTimePicker_AuthorData_DateOfDeath";
      this.dateTimePicker_AuthorData_DateOfDeath.Size = new System.Drawing.Size(166, 20);
      this.dateTimePicker_AuthorData_DateOfDeath.TabIndex = 12;
      this.toolTip.SetToolTip(this.dateTimePicker_AuthorData_DateOfDeath, "Enter date of death");
      // 
      // groupBox_AD_N
      // 
      this.groupBox_AD_N.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_AD_N.Controls.Add(this.richTextBox_AuthorData_Notes);
      this.groupBox_AD_N.Location = new System.Drawing.Point(3, 36);
      this.groupBox_AD_N.Name = "groupBox_AD_N";
      this.groupBox_AD_N.Size = new System.Drawing.Size(372, 300);
      this.groupBox_AD_N.TabIndex = 0;
      this.groupBox_AD_N.TabStop = false;
      this.groupBox_AD_N.Text = "Notes";
      // 
      // richTextBox_AuthorData_Notes
      // 
      this.richTextBox_AuthorData_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox_AuthorData_Notes.Enabled = false;
      this.richTextBox_AuthorData_Notes.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.richTextBox_AuthorData_Notes.Location = new System.Drawing.Point(3, 16);
      this.richTextBox_AuthorData_Notes.Name = "richTextBox_AuthorData_Notes";
      this.richTextBox_AuthorData_Notes.Size = new System.Drawing.Size(366, 281);
      this.richTextBox_AuthorData_Notes.TabIndex = 0;
      this.richTextBox_AuthorData_Notes.Text = "";
      this.toolTip.SetToolTip(this.richTextBox_AuthorData_Notes, "Enter notes here");
      // 
      // button_Save
      // 
      this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button_Save.Enabled = false;
      this.button_Save.Location = new System.Drawing.Point(380, 300);
      this.button_Save.Name = "button_Save";
      this.button_Save.Size = new System.Drawing.Size(272, 30);
      this.button_Save.TabIndex = 13;
      this.button_Save.Text = "Save";
      this.toolTip.SetToolTip(this.button_Save, "Save changes");
      this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
      // 
      // panel_Category_Top
      // 
      this.panel_Category_Top.Controls.Add(this.listView_Authors);
      this.panel_Category_Top.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel_Category_Top.Location = new System.Drawing.Point(0, 0);
      this.panel_Category_Top.Name = "panel_Category_Top";
      this.panel_Category_Top.Size = new System.Drawing.Size(659, 124);
      this.panel_Category_Top.TabIndex = 12;
      // 
      // listView_Authors
      // 
      this.listView_Authors.AllowColumnReorder = true;
      this.listView_Authors.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listView_Authors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                       this.columnHeader_AC_ID,
                                                                                       this.columnHeader_AC_Name,
                                                                                       this.columnHeader_AC_Nationality,
                                                                                       this.columnHeader_AC_BirthPlace,
                                                                                       this.columnHeader_AC_ModifiedDate,
                                                                                       this.columnHeader_AC_CreatedDate});
      this.listView_Authors.ContextMenu = this.contextMenu_CategoryAuthors;
      this.listView_Authors.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listView_Authors.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.listView_Authors.FullRowSelect = true;
      this.listView_Authors.GridLines = true;
      this.listView_Authors.LabelWrap = false;
      this.listView_Authors.Location = new System.Drawing.Point(0, 0);
      this.listView_Authors.Name = "listView_Authors";
      this.listView_Authors.Size = new System.Drawing.Size(659, 124);
      this.listView_Authors.TabIndex = 0;
      this.listView_Authors.View = System.Windows.Forms.View.Details;
      this.listView_Authors.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Authors_ColumnClick);
      this.listView_Authors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView_Authors_MouseMove);
      this.listView_Authors.Enter += new System.EventHandler(this.listView_Authors_Enter);
      this.listView_Authors.SelectedIndexChanged += new System.EventHandler(this.listView_Authors_SelectedIndexChanged);
      // 
      // columnHeader_AC_ID
      // 
      this.columnHeader_AC_ID.Text = "ID";
      this.columnHeader_AC_ID.Width = 0;
      // 
      // columnHeader_AC_Name
      // 
      this.columnHeader_AC_Name.Text = "Name";
      this.columnHeader_AC_Name.Width = 200;
      // 
      // columnHeader_AC_Nationality
      // 
      this.columnHeader_AC_Nationality.Text = "Nationality";
      this.columnHeader_AC_Nationality.Width = 138;
      // 
      // columnHeader_AC_BirthPlace
      // 
      this.columnHeader_AC_BirthPlace.Text = "Birth Place";
      this.columnHeader_AC_BirthPlace.Width = 131;
      // 
      // columnHeader_AC_ModifiedDate
      // 
      this.columnHeader_AC_ModifiedDate.Text = "Modified @";
      this.columnHeader_AC_ModifiedDate.Width = 71;
      // 
      // columnHeader_AC_CreatedDate
      // 
      this.columnHeader_AC_CreatedDate.Text = "Created @";
      this.columnHeader_AC_CreatedDate.Width = 71;
      // 
      // contextMenu_CategoryAuthors
      // 
      this.contextMenu_CategoryAuthors.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                                this.contextMenu_CategoryAuthors_AddNew,
                                                                                                this.contextMenu_CategoryAuthors_DeleteThis,
                                                                                                this.contextMenu_CategoryAuthors_Sep1,
                                                                                                this.contextMenu_CategoryAuthors_ViewBooks,
                                                                                                this.contextMenu_CategoryAuthors_RelatedAuthors,
                                                                                                this.contextMenu_CategoryAuthors_Sep2,
                                                                                                this.contextMenu_CategoryAuthors_ToggleGridlines});
      this.contextMenu_CategoryAuthors.Popup += new System.EventHandler(this.contextMenu_CategoryAuthors_Popup);
      // 
      // contextMenu_CategoryAuthors_AddNew
      // 
      this.contextMenu_CategoryAuthors_AddNew.Index = 0;
      this.contextMenu_CategoryAuthors_AddNew.Text = "Add new Author";
      this.contextMenu_CategoryAuthors_AddNew.Click += new System.EventHandler(this.contextMenu_CategoryAuthors_AddNew_Click);
      // 
      // contextMenu_CategoryAuthors_DeleteThis
      // 
      this.contextMenu_CategoryAuthors_DeleteThis.Index = 1;
      this.contextMenu_CategoryAuthors_DeleteThis.Text = "Delete this Author";
      this.contextMenu_CategoryAuthors_DeleteThis.Click += new System.EventHandler(this.contextMenu_CategoryAuthors_DeleteThis_Click);
      // 
      // contextMenu_CategoryAuthors_Sep1
      // 
      this.contextMenu_CategoryAuthors_Sep1.Index = 2;
      this.contextMenu_CategoryAuthors_Sep1.Text = "-";
      // 
      // contextMenu_CategoryAuthors_ViewBooks
      // 
      this.contextMenu_CategoryAuthors_ViewBooks.Index = 3;
      this.contextMenu_CategoryAuthors_ViewBooks.Text = "View Books";
      this.contextMenu_CategoryAuthors_ViewBooks.Click += new System.EventHandler(this.contextMenu_CategoryAuthors_ViewBooks_Click);
      // 
      // contextMenu_CategoryAuthors_RelatedAuthors
      // 
      this.contextMenu_CategoryAuthors_RelatedAuthors.Index = 4;
      this.contextMenu_CategoryAuthors_RelatedAuthors.Text = "Related Authors";
      this.contextMenu_CategoryAuthors_RelatedAuthors.Click += new System.EventHandler(this.contextMenu_CategoryAuthors_RelatedAuthors_Click);
      // 
      // contextMenu_CategoryAuthors_Sep2
      // 
      this.contextMenu_CategoryAuthors_Sep2.Index = 5;
      this.contextMenu_CategoryAuthors_Sep2.Text = "-";
      // 
      // contextMenu_CategoryAuthors_ToggleGridlines
      // 
      this.contextMenu_CategoryAuthors_ToggleGridlines.Index = 6;
      this.contextMenu_CategoryAuthors_ToggleGridlines.Text = "Toggle Gridlines";
      this.contextMenu_CategoryAuthors_ToggleGridlines.Click += new System.EventHandler(this.contextMenu_CategoryAuthors_ToggleGridlines_Click);
      // 
      // panel_Book
      // 
      this.panel_Book.Controls.Add(this.bookDataEditor);
      this.panel_Book.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_Book.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.panel_Book.Location = new System.Drawing.Point(0, 0);
      this.panel_Book.Name = "panel_Book";
      this.panel_Book.Size = new System.Drawing.Size(659, 460);
      this.panel_Book.TabIndex = 2;
      // 
      // splitter_Left_Right
      // 
      this.splitter_Left_Right.Location = new System.Drawing.Point(292, 24);
      this.splitter_Left_Right.Name = "splitter_Left_Right";
      this.splitter_Left_Right.Size = new System.Drawing.Size(4, 501);
      this.splitter_Left_Right.TabIndex = 4;
      this.splitter_Left_Right.TabStop = false;
      // 
      // RooBooks
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(956, 545);
      this.Controls.Add(this.splitter_Left_Right);
      this.Controls.Add(this.panel_Right);
      this.Controls.Add(this.panel_Left);
      this.Controls.Add(this.statusBar);
      this.Controls.Add(this.reBar_MainMenu);
      this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "RooBooks";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RooBooks";
      this.Closing += new System.ComponentModel.CancelEventHandler(this.RooBooks_Closing);
      this.Load += new System.EventHandler(this.RooBooks_Load);
      ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_Icon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_Main)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel_Secondary)).EndInit();
      this.panel_Left.ResumeLayout(false);
      this.documentContainer_Data.ResumeLayout(false);
      this.dockControl_Data.ResumeLayout(false);
      this.dockControl_Search.ResumeLayout(false);
      this.groupBox_sb_Keyword.ResumeLayout(false);
      this.groupBox_sb_Notes.ResumeLayout(false);
      this.groupBox_sb_In.ResumeLayout(false);
      this.groupBox_sbName.ResumeLayout(false);
      this.groupBox_sbNationality.ResumeLayout(false);
      this.groupBox_sbPublished.ResumeLayout(false);
      this.panel_Right.ResumeLayout(false);
      this.panel_Start.ResumeLayout(false);
      this.panel_MainTop.ResumeLayout(false);
      this.panel_MainBottom.ResumeLayout(false);
      this.panel_Search.ResumeLayout(false);
      this.documentContainer_SearchResults.ResumeLayout(false);
      this.dockControl_Authors.ResumeLayout(false);
      this.panel_sr_AuthorsBottom.ResumeLayout(false);
      this.panel_sr_Authors.ResumeLayout(false);
      this.dockControl_Books.ResumeLayout(false);
      this.panel_sr_Books.ResumeLayout(false);
      this.panel_sr_Books_Bottom.ResumeLayout(false);
      this.panel_Author.ResumeLayout(false);
      this.panel_Author_Bottom.ResumeLayout(false);
      this.groupBox_BT_BT.ResumeLayout(false);
      this.groupBox_BD_Notes.ResumeLayout(false);
      this.panel_Author_Top.ResumeLayout(false);
      this.panel_Category.ResumeLayout(false);
      this.panel_Category_Bottom.ResumeLayout(false);
      this.groupBox_AD_PD.ResumeLayout(false);
      this.groupBox_AD_N.ResumeLayout(false);
      this.panel_Category_Top.ResumeLayout(false);
      this.panel_Book.ResumeLayout(false);
      this.ResumeLayout(false);

    }
    #endregion

    [STAThread]
    static void Main() 
    {
      Application.Run(new RooBooks());
    }


    private void RooBooks_Load(object sender, System.EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      try 
      {
        SplashScreen splash = new SplashScreen();
        splash.Show();
        Application.DoEvents();
        Thread.Sleep(5000);	
        splash.Close();

        this.rbSettings = new Settings();
        this.rbWorker = new DB();
        // ==============================================================================
        this.GenresGeneralCategoryID = int.Parse(this.rbSettings.getSetting("Genres_General_Category_ID"));
        // ==============================================================================
        this.AppPath = (string)this.rbSettings.getRegistrySetting("ApplicationInstallPath");
        this.RegistryPath = this.rbSettings.getSetting("RegistryPath");
        this.dataset_Categories = new DataSet("Categories");
        this.dataset_CategoryAuthors = new DataSet("CategoryAuthors");
        // ==============================================================================
        this.panel_Book.Visible = false;
        this.panel_Author.Visible = false;
        this.panel_Category.Visible = false;
        this.panel_Search.Visible = false;
        this.panel_Start.Visible = true;
        // ==============================================================================
        LoadSettings();
        // ==============================================================================
        PopulateCategories();
        // ==============================================================================
        FillSearchInCriterias();
        // ==============================================================================
        this.lvwColumnSorter = new ListViewColumnSorter();
        this.listView_Authors.ListViewItemSorter = this.lvwColumnSorter;
        this.listView_Books.ListViewItemSorter = this.lvwColumnSorter;
        this.listView_sr_Authors.ListViewItemSorter = this.lvwColumnSorter;
        this.listView_sr_Books.ListViewItemSorter = this.lvwColumnSorter;
        this.label_CategoryLabel.Text = "   RooBooks";
      }
      catch (Exception ex)
      {
        MsgError(ex, 1);
      }
      this.Cursor = Cursors.Default;
    }


    #region Loading Settings
    private void LoadSettings() 
    {
      try 
      {
        ///~ common settings
        this.Height = int.Parse(this.rbSettings.getRegistrySetting("WindowHeight").ToString());
        this.Width = int.Parse(this.rbSettings.getRegistrySetting("WindowWidth").ToString());
        this.Left = int.Parse(this.rbSettings.getRegistrySetting("WindowLeft").ToString());
        this.Top = int.Parse(this.rbSettings.getRegistrySetting("WindowTop").ToString());
        this.treeListView_Categories.GridLines = bool.Parse(this.rbSettings.getRegistrySetting("CategoriesTreeGridlines").ToString());
        this.listView_Authors.GridLines = bool.Parse(this.rbSettings.getRegistrySetting("AuthorListViewGridLines").ToString());
        this.listView_sr_Authors.GridLines = bool.Parse(this.rbSettings.getRegistrySetting("AuthorListViewGridLines").ToString());
        this.listView_Books.GridLines = bool.Parse(this.rbSettings.getRegistrySetting("BooksListViewGridLines").ToString());
        this.listView_sr_Books.GridLines = bool.Parse(this.rbSettings.getRegistrySetting("BooksListViewGridLines").ToString());
        
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
 
    public void SetControlsFont(Font font) 
    {
      try 
      {
        SetControlsFont(this, font);
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
          if (c.Name == "label_CategoryLabel")
            c.Font = new Font(font.FontFamily, font.Size + 6F, font.Style);
          else if (c.Name == "label_AU_Edit" || c.Name == "label_BD_Edit")
            c.Font = new Font(font.FontFamily, font.Size + 4F, font.Style);
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

    #region Common event-handlers
    private void CloseApp(object sender, System.EventArgs e) 
    {
      this.Dispose();
      this.Close();
      this.notifyIcon.Dispose();
    }

    private void ShowAbout(object sender, System.EventArgs e) 
    {
      About about = new About();
      about.ShowDialog();
    }

    private void ShowPreferences(object sender, System.EventArgs e) 
    {
      RooBooks_Preferences preferences = new RooBooks_Preferences(this);
      preferences.ShowDialog();
    }
    #endregion

    #region Simple event handlers
    public void contextMenu_Categories_Refresh_Click(object sender, System.EventArgs e)
    {
      PopulateCategories();
    }

    private void RooBooks_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      try 
      {
        SaveRBSettings();
        this.rbWorker.FreeAll();
        this.notifyIcon.Dispose();
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void menuItemEx_Print_Click(object sender, System.EventArgs e)
    {
      try 
      {
        this.printStringReader = new StringReader("");
        if (this.printDialog.ShowDialog() == DialogResult.OK)
        {
          this.printDocument.Print();
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void menuItemEx_PrintPreview_Click(object sender, System.EventArgs e)
    {
      try
      {
        this.printStringReader = new StringReader("");
        this.printPreviewDialog.FormBorderStyle = FormBorderStyle.Fixed3D;
        this.printPreviewDialog.ShowDialog();
      }
      catch(Exception ex)
      {
        MsgError(ex, 1);
      }
    }

    private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      int count = 0;
      float linesPerPage = 0;
      float yPosition = 0;
      float leftMargin = e.MarginBounds.Left;
      float topMargin = e.MarginBounds.Top;
      string line = null;

      Font printFont = new Font(FontFamily.GenericSansSerif, 8);
      SolidBrush printBrush = new SolidBrush(Color.Black);

      // Work out the number of lines per page, using the MarginBounds.
      linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

      // Iterate over the string using the StringReader, printing each line.
      while(count < linesPerPage && ((line = this.printStringReader.ReadLine()) != null)) 
      {
        // calculate the next line position based on 
        // the height of the font according to the printing device
        yPosition = topMargin + (count * printFont.GetHeight(e.Graphics));

        // draw the next line in the rich edit control
				
        e.Graphics.DrawString(line, printFont, printBrush, leftMargin, yPosition, new StringFormat());
        count++;
      }

      // If there are more lines, print another page.
      if(line != null)
        e.HasMorePages = true;
      else
        e.HasMorePages = false;

      printBrush.Dispose();
    }

    private void timer_StatusBar_Tick(object sender, System.EventArgs e)
    {
      DateTimePicker dtp = new DateTimePicker();
      dtp.Format = DateTimePickerFormat.Custom;
      String time = (String)dtp.Value.ToLongTimeString();
      this.statusBarPanel_Secondary.Text = time;
    }

    private void contextMenu_Categories_ToggleGridlines_Click(object sender, System.EventArgs e)
    {
      if (this.treeListView_Categories.GridLines)
        this.treeListView_Categories.GridLines = false;
      else
        this.treeListView_Categories.GridLines = true;
    }
    private void contextMenu_Categories_New_Category_Click(object sender, System.EventArgs e)
    {
      try 
      {
        TreeListViewItem item = this.treeListView_Categories.SelectedItems[0];
        if (item != null) 
        {
          if (item.Tag != null) 
            AddTreeCategory(int.Parse(item.Tag.ToString().Split('@')[1]));
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void contextMenu_CategoryAuthors_AddNew_Click(object sender, System.EventArgs e)
    {
      try 
      {
        TreeListViewItem item = this.treeListView_Categories.SelectedItems[0];
        if (item != null) 
        {
          if (item.Tag != null) 
            AddTreeCategory(int.Parse(item.Tag.ToString().Split('@')[1]));
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }
    private void contextMenu_Categories_New_Author_Click(object sender, System.EventArgs e)
    {
      try 
      {
        TreeListViewItem item = this.treeListView_Categories.SelectedItems[0];
        if (item != null) 
        {
          if (item.Tag != null) 
            AddTreeAuthor(int.Parse(item.Tag.ToString().Split('@')[1]));
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }
    private void menuItem_AuthorBooks_AddNew_Click(object sender, System.EventArgs e)
    {
      try 
      {
        TreeListViewItem item = this.treeListView_Categories.SelectedItems[0];
        if (item != null) 
        {
          if (item.Tag != null) 
            AddTreeAuthor(int.Parse(item.Tag.ToString().Split('@')[1]));
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }
    private void contextMenu_Categories_New_Book_Click(object sender, System.EventArgs e)
    {
      try 
      {
        TreeListViewItem item = this.treeListView_Categories.SelectedItems[0];
        if (item != null) 
        {
          if (item.Tag != null) 
          {
            AddTreeBook(int.Parse(item.Tag.ToString().Split('@')[1]));
          }
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void contextMenu_Categories_Delete_Click(object sender, System.EventArgs e)
    {
      try 
      {
        TreeListViewItem item = this.treeListView_Categories.SelectedItems[0];
        if (item != null) 
        {
          if (item.Tag != null) 
          {
            this.SelectedTreeItem = item;
            string tag = CheckTreeItem(item.Tag.ToString());
            string mbText = "";
            string mbTitle = "";
            if (tag == "category") 
            {
              mbText = "Are you sure you want to delete this category ?\n(All authors and books in it will be deleted too)";
              mbTitle = "Warning";
            }
            if (tag == "author") 
            {
              mbText = "Are you sure you want to delete this author ?\n(All books in it will be deleted too)";
              mbTitle = "Warning";
            }
            if (tag == "book") 
            {
              mbText = "Are you sure you want to delete this book ?";
              mbTitle = "Warning";
            }
            DialogResult res = MessageBox.Show(this, mbText, mbTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes) 
            {
              this.rbWorker.RemoveItemID = this.SelectedTreeItem.Tag.ToString();
              Thread work = new Thread(new ThreadStart(this.rbWorker.RemoveItem));
              work.Start();
              while (work.ThreadState.Equals(work.IsAlive)) 
              {
                Application.DoEvents();
              }
              item.Remove();
            }
          }
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void contextMenu_Categories_ShrinkAuthors_Click(object sender, System.EventArgs e)
    {
      this.treeListView_Categories.SelectedItems[0].CollapseAll();
      this.treeListView_Categories.SelectedItems[0].Expand();
    }

    private void contextMenu_Categories_ShowAll_Click(object sender, System.EventArgs e)
    {
      if (this.expandCategories) 
      {
        this.treeListView_Categories.FocusedItem.Collapse();
        this.expandCategories = false;
      }
      else 
      {
        this.treeListView_Categories.FocusedItem.Expand();
        this.expandCategories = true;
      }
    }

    private void treeListView_Categories_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      try 
      {
        if (this.treeListView_Categories.SelectedItems.Count > 0) 
        {
          TreeListViewItem item = this.treeListView_Categories.SelectedItems[0];
          if (item != null && item.Tag != null) 
          {
            string selectedTag = item.Tag.ToString();
            if (selectedTag.IndexOf("Category") >= 0) 
            {
              this.label_CategoryLabel.Text = "   " + item.Text;
              ShowCategoryData(int.Parse(selectedTag.Replace("CategoryID@", "")));
              ToggleBookDataForm(false);
              ToggleAuthorDataForm(false);
            }
            else if (selectedTag.IndexOf("Author") >= 0) 
            {
              ShowAuthorData(int.Parse(selectedTag.Replace("AuthorID@", "")));
              ToggleBookDataForm(false);
            }
            else if (selectedTag.IndexOf("Book") >= 0) 
              ShowBookData(int.Parse(selectedTag.Replace("BookID@", "")));
            else 
            {
              this.panel_Category.Visible = false;
              this.panel_Book.Visible = false;
              this.panel_Author.Visible = false;
            }
          }
        }
        else 
        {
          this.label_CategoryLabel.Text = "   RooBooks";
          this.listView_Authors.Items.Clear();
          this.listView_Books.Items.Clear();
          this.panel_Category.Visible = false;
          this.panel_Author.Visible = false;
          this.panel_Book.Visible = false;
          this.panel_Start.Visible = true;
          ToggleBookDataForm(false);
          ToggleAuthorDataForm(false);
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void contextMenu_CategoryAuthors_ToggleGridlines_Click(object sender, System.EventArgs e)
    {
      if (this.listView_Authors.GridLines)
        this.listView_Authors.GridLines = false;
      else
        this.listView_Authors.GridLines = true;
    }

    private void listView_Authors_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
    {
      try 
      {
        ToolTipOnAuthors(sender, e);
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }
    
    private void listView_Authors_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      try 
      {
        ToggleBookDataForm(true);
        if (this.ShowRelatedAuthor) 
        {
          this.ShowRelatedAuthor = false;
          ShowEditAuthorData(this.CurrentAuthorID);
          PositionTrees();
        }
        else if (this.listView_Authors.SelectedItems.Count > 0) 
        {
          ListViewItem item = this.listView_Authors.SelectedItems[0];
          if (item != null) 
          {
            this.CurrentAuthorID = int.Parse(item.SubItems[0].Text);
            ShowEditAuthorData(this.CurrentAuthorID);
          }
        }
        else if (this.CurrentAuthorID > 0) 
          ShowEditAuthorData(this.CurrentAuthorID);
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void button_Save_Click(object sender, System.EventArgs e)
    {
      try 
      {
        this.Cursor = Cursors.WaitCursor;
        if (this.currentAuthorID > 0) 
        {
          this.button_Save.Enabled = false;
          SaveAuthorData(this.currentAuthorID);
          this.button_Save.Enabled = true;
        }
        this.Cursor = Cursors.Default;
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void menuItem_AuthorBooks_ToggleGridlines_Click(object sender, System.EventArgs e)
    {
      if (this.listView_Books.GridLines)
        this.listView_Books.GridLines = false;
      else
        this.listView_Books.GridLines = true;
    }

    private void contextMenu_CategoryAuthors_ViewBooks_Click(object sender, System.EventArgs e)
    {
      try 
      {
        if (this.listView_Authors.SelectedItems.Count > 0) 
        {
          ListViewItem item = this.listView_Authors.SelectedItems[0];
          if (item != null) 
          {
            this.currentAuthorID = int.Parse(item.SubItems[0].Text);
            ShowAuthorData(this.currentAuthorID);
          }
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void menuItem_AuthorBooks_DeleteThis_Click(object sender, System.EventArgs e)
    {
      try 
      {
        if (this.listView_Books.SelectedItems.Count > 0) 
        {
          ListViewItem item = this.listView_Books.SelectedItems[0];
          if (item != null) 
            DeleteBook(int.Parse(item.SubItems[0].Text));
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void contextMenu_CategoryAuthors_DeleteThis_Click(object sender, System.EventArgs e)
    {
      try 
      {
        if (this.listView_Authors.SelectedItems.Count > 0) 
        {
          ListViewItem item = this.listView_Authors.SelectedItems[0];
          if (item != null) 
            DeleteAuthor(int.Parse(item.SubItems[0].Text));
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void listView_Books_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      try 
      {
        if (this.ShowRelatedBook) 
        {
          ShowEditBookData(this.CurrentBookID);
          PositionTrees();
        }
        else if (this.listView_Books.SelectedItems.Count > 0) 
        {
          ListViewItem item = this.listView_Books.SelectedItems[0];
          if (item != null) 
          {
            this.CurrentBookID = int.Parse(item.SubItems[0].Text);
            ShowEditBookData(int.Parse(item.SubItems[0].Text));
          }
        }
        else if (this.CurrentBookID > 0)
          ShowEditBookData(this.CurrentBookID);
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void button_BD_Save_Click(object sender, System.EventArgs e)
    {
      try 
      {
        this.Cursor = Cursors.WaitCursor;
        SaveBookData(this.CurrentBookID);
        this.Cursor = Cursors.Default;
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void menuItem_AuthorBooks_ReletadBooks_Click(object sender, System.EventArgs e)
    {
      RelatedBooks box = new RelatedBooks(this);
      box.BookID = this.CurrentBookID;
      box.AppPath = this.AppPath;
      box.ShowDialog();
    }

    private void contextMenu_CategoryAuthors_RelatedAuthors_Click(object sender, System.EventArgs e)
    {
      RelatedAuthors box = new RelatedAuthors(this);
      box.AuthorID = this.CurrentAuthorID;
      box.AppPath = this.AppPath;
      box.ShowDialog();
    }

    private void contextMenu_Categories_New_Popup(object sender, System.EventArgs e)
    {
      try 
      {
        if (this.treeListView_Categories.SelectedItems.Count > 0) 
        {
          TreeListViewItem item = this.treeListView_Categories.SelectedItems[0];
          if (item != null) 
          {
            string tag = CheckTreeItem(item.Tag.ToString());
            if (tag == "category") 
            {
              this.contextMenu_Categories_New_Category.Enabled = true;
              this.contextMenu_Categories_New_Author.Enabled = true;
              this.contextMenu_Categories_New_Book.Enabled = false;
            }
            if (tag == "author") 
            {
              this.contextMenu_Categories_New_Category.Enabled = false;
              this.contextMenu_Categories_New_Author.Enabled = false;
              this.contextMenu_Categories_New_Book.Enabled = true;
            }
            if (tag == "book") 
            {
              this.contextMenu_Categories_New_Category.Enabled = false;
              this.contextMenu_Categories_New_Author.Enabled = false;
              this.contextMenu_Categories_New_Book.Enabled = false;
            }
          }
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void NotifyIcon_RestoreMinimze_Click(object sender, System.EventArgs e)
    {
      switch(WindowState) 
      {
        case FormWindowState.Minimized:
          this.WindowState = FormWindowState.Normal;
          this.ShowInTaskbar = true;
          PopulateCategories();
          PositionTrees();
          break;
        case FormWindowState.Normal:
          this.WindowState = FormWindowState.Minimized;
          this.ShowInTaskbar = false;
          break;
      }
    }

    private void treeListView_Categories_Enter(object sender, System.EventArgs e)
    {
      ToggleBookDataForm(false);
      ToggleAuthorDataForm(false);
    }
    private void listView_Books_Enter(object sender, System.EventArgs e)
    {
      listView_Books_SelectedIndexChanged(sender, e);
    }

    private void listView_Authors_Enter(object sender, System.EventArgs e)
    {
      listView_Authors_SelectedIndexChanged(sender, e);
    }
    private void button_Search_Click(object sender, System.EventArgs e)
    {
      try 
      {
        ConductSearch(this.textBox_sbKeyword.Text, this.textBox_sbNotes.Text);
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void documentContainer_Data_ActiveDocumentChanged(object sender, TD.SandDock.ActiveDocumentEventArgs e)
    {
      ToggleAuthorDataForm(false);
      ToggleBookDataForm(false);
      this.panel_Category.Visible = false;
      this.panel_Author.Visible = false;
      this.panel_Book.Visible = false;
      this.panel_Search.Visible = false;
      if (e.NewActiveDocument.Tag.ToString() == "0") 
      {
        this.panel_Category.Visible = true;
        this.panel_Author.Visible = true;
        this.panel_Book.Visible = true;
      }
      else if (e.NewActiveDocument.Tag.ToString() == "1")
      {
        this.panel_Search.Visible = true;
        this.dockControl_Authors.Text = "Authors";
        this.dockControl_Books.Text = "Books";
        this.textBox_sbKeyword.Text = "";
        this.textBox_sbNotes.Text = "";
        this.listView_sr_Authors.Items.Clear();
        this.listView_sr_Books.Items.Clear();
        FillSearchInCriterias();
      }
    }

    private void button_sr_ViewAuthor_Click(object sender, System.EventArgs e)
    {
      ShowFoundAuthor(int.Parse(this.listView_sr_Authors.SelectedItems[0].SubItems[0].Text));
    }

    private void button_sr_ViewBook_Click(object sender, System.EventArgs e)
    {
      this.panel_Category.Visible = true;
      this.panel_Author.Visible = true;
      this.panel_Book.Visible = true;
      this.panel_Search.Visible = false;
      ShowFoundBook(int.Parse(this.listView_sr_Books.SelectedItems[0].SubItems[0].Text));
    }

    private void listView_Authors_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
    {
      SortListView(e, ref this.listView_Authors);
    }

    private void listView_Books_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
    {
      SortListView(e, ref this.listView_Books);
    }

    private void listView_sr_Authors_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
    {
      SortListView(e, ref this.listView_sr_Authors);
    }

    private void listView_sr_Books_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
    {
      SortListView(e, ref this.listView_sr_Books);
    }

    private void contextMenu_Categories_Popup(object sender, System.EventArgs e)
    {
      if (this.treeListView_Categories.SelectedItems.Count == 0) 
      {
        this.contextMenu_Categories.MenuItems[0].Enabled = false;
        this.contextMenu_Categories.MenuItems[2].Enabled = false;
        this.contextMenu_Categories.MenuItems[7].Enabled = false;
        this.contextMenu_Categories.MenuItems[8].Enabled = false;
      }
      else 
      {
        this.contextMenu_Categories.MenuItems[0].Enabled = true;
        this.contextMenu_Categories.MenuItems[2].Enabled = true;
        this.contextMenu_Categories.MenuItems[7].Enabled = true;
        this.contextMenu_Categories.MenuItems[8].Enabled = true;
      }
    }
    private void contextMenu_CategoryAuthors_Popup(object sender, System.EventArgs e)
    {
      if (this.listView_Authors.SelectedItems.Count == 0) 
      {
        this.contextMenu_CategoryAuthors.MenuItems[0].Enabled = false;
        this.contextMenu_CategoryAuthors.MenuItems[1].Enabled = false;
        this.contextMenu_CategoryAuthors.MenuItems[3].Enabled = false;
        this.contextMenu_CategoryAuthors.MenuItems[4].Enabled = false;
      }
      else 
      {
        this.contextMenu_CategoryAuthors.MenuItems[0].Enabled = true;
        this.contextMenu_CategoryAuthors.MenuItems[1].Enabled = true;
        this.contextMenu_CategoryAuthors.MenuItems[3].Enabled = true;
        this.contextMenu_CategoryAuthors.MenuItems[4].Enabled = true;
      }
    }

    private void contextMenu_AuthorBooks_Popup(object sender, System.EventArgs e)
    {
      if (this.listView_Books.SelectedItems.Count == 0) 
      {
        this.contextMenu_AuthorBooks.MenuItems[0].Enabled = false;
        this.contextMenu_AuthorBooks.MenuItems[1].Enabled = false;
        this.contextMenu_AuthorBooks.MenuItems[3].Enabled = false;
      }
      else 
      {
        this.contextMenu_AuthorBooks.MenuItems[0].Enabled = true;
        this.contextMenu_AuthorBooks.MenuItems[1].Enabled = true;
        this.contextMenu_AuthorBooks.MenuItems[3].Enabled = true;
      }
    }

    private void menuItemEx_New_Click(object sender, System.EventArgs e)
    {
      New n = new New(this, "choice");
      n.ParentID = 0;
      n.AppPath = this.appPath;
      n.ShowDialog();
    }
    private void toolBarItem_File_DropDown(object sender, System.EventArgs e)
    {
      if (this.treeListView_Categories.SelectedItems.Count == 0) 
      {
        this.toolBarItem_File.MenuItems[0].Enabled = false;
        this.toolBarItem_File.MenuItems[2].Enabled = false;
        this.toolBarItem_File.MenuItems[3].Enabled = false;
      }
      else 
      {
        this.toolBarItem_File.MenuItems[0].Enabled = true;
        this.toolBarItem_File.MenuItems[2].Enabled = true;
        this.toolBarItem_File.MenuItems[3].Enabled = true;
      }
    }

    #endregion

    #region rbWorkers
    public void PopulateCategories() 
    {
      try 
      {
        this.treeListView_Categories.Items.Clear();

        DataTable dt = this.rbWorker.GetCategoriesTree();
        this.dataset_Categories = dt.DataSet;

        TreeListViewItem rootNode = new TreeListViewItem("Data", 0);
        rootNode.Tag = "rootData";
        this.treeListView_Categories.Items.Add(rootNode);
        rootNode.Expand();

        SortedList alreadyAdded = new SortedList();

        DataRow[] rows = dt.Select("ParentID = 0", "CategoryName");
        foreach (DataRow row in rows) 
        {
          if (!alreadyAdded.ContainsKey("Category@" + row["CategoryID"].ToString())) 
          {
            TreeListViewItem item = new TreeListViewItem();
            item.Text = row["CategoryName"].ToString();
            item.Tag = "CategoryID@" + row["CategoryID"].ToString();
            item.ImageIndex = 1;
            item.BackColor = SystemColors.Control;
            alreadyAdded.Add("Category@" + row["CategoryID"].ToString(), row["CategoryName"].ToString());

            int authorsCount = 0;
            DataRow[] rowsAuthors = dt.Select("AuthorCategoryID=" + row["CategoryID"].ToString(), "FirstName, LastName");
            foreach (DataRow rowAuthor in rowsAuthors) 
            {
              if (!alreadyAdded.ContainsKey("Author@" + rowAuthor["AuthorID"].ToString()) )
              {
                string firstName = rowAuthor["FirstName"].ToString();
                string lastName = rowAuthor["LastName"].ToString();

                TreeListViewItem itemAuthor = new TreeListViewItem();
                itemAuthor.Text = ((firstName == "") ? lastName : lastName + ", " + firstName);
                itemAuthor.Tag = "AuthorID@" + rowAuthor["AuthorID"].ToString();
                itemAuthor.ImageIndex = 2;
                alreadyAdded.Add("Author@" + rowAuthor["AuthorID"].ToString(), lastName);

                int booksCounter = 0;
                DataRow[] rowsBooks = dt.Select("BookAuthorID=" + rowAuthor["AuthorID"].ToString(), "BookTitle");
                foreach (DataRow rowBook in rowsBooks) 
                {
                  if (!alreadyAdded.ContainsKey("Book@" + rowBook["BookID"].ToString()) )
                  {
                    TreeListViewItem itemBook = new TreeListViewItem();
                    itemBook.Text = rowBook["BookTitle"].ToString();
                    itemBook.Tag = "BookID@" + rowBook["BookID"].ToString();
                    itemBook.ImageIndex = 3;
                    itemAuthor.Items.Add(itemBook);
                    booksCounter++;
                    alreadyAdded.Add("Book@" + rowBook["BookID"].ToString(), rowBook["BookTitle"].ToString());
                  }
                }
                itemAuthor.SubItems.Add(((booksCounter == 1) ? "1 Book" : ((booksCounter == 0) ? "No Books" : booksCounter + " Books")));
                item.Items.Add(itemAuthor);
                authorsCount++;
              }
            }
            string subText = ((authorsCount == 1) ? "1 Author" : ((authorsCount == 0) ? "No Authors" : authorsCount + " Authors"));
            item.SubItems.Add(subText, item.ForeColor, SystemColors.Control, item.Font);

            rootNode.Items.Add(item);

            DataRow[] subRows = dt.Select("ParentID=" + row["CategoryID"].ToString());
            if (subRows.Length > 0)
              PopulateSubCategories(item, dt, subRows, alreadyAdded);
          }
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    public void ShowRelatedBookData(int BookID) 
    {
      this.ShowRelatedBook = true;
      this.CurrentBookID = BookID;
      listView_Books_SelectedIndexChanged(null, null);
    }
    public void ShowRelatedAuthorData(int AuthorID) 
    {
      this.ShowRelatedAuthor = true;
      this.CurrentAuthorID = AuthorID;
      listView_Authors_SelectedIndexChanged(null, null);
    }
    private void PopulateSubCategories(TreeListViewItem node, DataTable dt, DataRow[] rows, SortedList alreadyAdded) 
    {
      try 
      {
        foreach (DataRow row in rows) 
        {
          if (!alreadyAdded.ContainsKey("Category@" + row["CategoryID"].ToString())) 
          {
            TreeListViewItem item = new TreeListViewItem();
            item.Text = row["CategoryName"].ToString();
            item.Tag = "CategoryID@" + row["CategoryID"].ToString();
            item.ImageIndex = 1;
            item.BackColor = SystemColors.Control;
            alreadyAdded.Add("Category@" + row["CategoryID"].ToString(), row["CategoryName"].ToString());

            int authorsCount = 0;
            DataRow[] rowsAuthors = dt.Select("AuthorCategoryID=" + row["CategoryID"]);
            foreach (DataRow rowAuthor in rowsAuthors) 
            {
              if (!alreadyAdded.ContainsKey("Author@" + rowAuthor["AuthorID"].ToString())) 
              {
                string firstName = rowAuthor["FirstName"].ToString();
                string lastName = rowAuthor["LastName"].ToString();

                TreeListViewItem itemAuthor = new TreeListViewItem();
                itemAuthor.Text = ((firstName == "") ? lastName : lastName + ", " + firstName);
                itemAuthor.Tag = "AuthorID@" + rowAuthor["AuthorID"].ToString();
                itemAuthor.ImageIndex = 2;
                alreadyAdded.Add("Author@" + rowAuthor["AuthorID"].ToString(), lastName);

                int booksCounter = 0;
                DataRow[] rowsBooks = dt.Select("BookAuthorID=" + rowAuthor["AuthorID"].ToString());
                foreach (DataRow rowBook in rowsBooks) 
                {
                  if (!alreadyAdded.ContainsKey("Book@" + rowBook["BookID"].ToString()) )
                  {
                    TreeListViewItem itemBook = new TreeListViewItem();
                    itemBook.Text = rowBook["BookTitle"].ToString();
                    itemBook.Tag = "BookID@" + rowBook["BookID"].ToString();
                    itemBook.ImageIndex = 3;
                    itemAuthor.Items.Add(itemBook);
                    booksCounter++;
                    alreadyAdded.Add("Book@" + rowBook["BookID"].ToString(), rowBook["BookTitle"].ToString());
                  }
                }
                itemAuthor.SubItems.Add(((booksCounter == 1) ? "1 Book" : ((booksCounter == 0) ? "No Books" : booksCounter + " Books")));
                item.Items.Add(itemAuthor);
                authorsCount++;
              }
            }
            string subText = ((authorsCount == 1) ? "1 Author" : ((authorsCount == 0) ? "No Authors" : authorsCount + " Authors"));
            item.SubItems.Add(subText, item.ForeColor, SystemColors.Control, item.Font);

            node.Items.Add(item);

            DataRow[] subRows = dt.Select("ParentID=" + row["CategoryID"]);
            if (subRows.Length > 0)
              PopulateSubCategories(item, dt, subRows, alreadyAdded);
          }
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void AddTreeCategory(int parentID) 
    {
      try 
      {
        New n = new New(this, "category");
        n.ParentID = parentID;
        n.AppPath = this.appPath;
        n.ShowDialog();
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void AddTreeAuthor(int parentID) 
    {
      try 
      {
        New n = new New(this, "author");
        n.ParentID = parentID;
        n.AppPath = this.appPath;
        n.ShowDialog();
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    private void AddTreeBook(int parentID) 
    {
      try 
      {
        New n = new New(this, "book");
        n.ParentID = parentID;
        n.AppPath = this.appPath;
        n.ShowDialog();
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }
    private void SaveRBSettings() 
    {
      try 
      {
        this.rbSettings.SaveWindowSettings(this.Width, this.Height, this.Left, this.Top);
        this.rbSettings.SaveGridsSettings(this.treeListView_Categories.GridLines, this.listView_Authors.GridLines, this.listView_Books.GridLines);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void ShowCategoryData(int CategoryID) 
    {
      try 
      {
        ClearTexts();
        this.panel_Author.Visible = false;
        this.panel_Book.Visible = false;
        this.panel_Category.Visible = true;

        this.listView_Authors.Items.Clear();
        if (this.CurrentCategoryID != CategoryID || this.HasAuthorChanges) 
        {
          this.HasAuthorChanges = false;
          this.dtAuthors = this.rbWorker.GetCategoryAuthors(CategoryID);
          this.CurrentCategoryID = CategoryID;
        }
        DataRow[] rows = this.dtAuthors.Select("CategoryID = " + CategoryID);
        if (rows.Length > 0) 
        {
          foreach (DataRow row in rows) 
          {
            string[] subItems = new string[6];
            subItems[0] = row["AuthorID"].ToString().Trim();
            subItems[1] = row["FirstName"].ToString().Trim() + ((row["FirstName"].ToString().Equals("")) ? "" : " ") + row["LastName"].ToString().Trim();
            subItems[2] = ((row["Nationality"].ToString().Trim().Equals("")) ? "N/A" : row["Nationality"].ToString().Trim());
            subItems[3] = ((row["Birthplace"].ToString().Trim().Equals("")) ? "N/A" : row["Birthplace"].ToString().Trim());
            subItems[4] = ((row["ModifiedDate"].ToString().Trim().Equals("")) ? "N/A" : row["ModifiedDate"].ToString().Trim());
            subItems[5] = ((row["CreatedDate"].ToString().Trim().Equals("")) ? "N/A" : row["CreatedDate"].ToString().Trim());
            ListViewItem item = new ListViewItem(subItems);
            // 22.3.2004 ã. 00:00:00
            item.Tag = subItems[1] + " (last modified @ " + subItems[4] + ")";
            if (this.CurrentAuthorID == int.Parse(row["AuthorID"].ToString())) 
            {
              item.Selected = true;
              item.Focused = true;
            }
            this.listView_Authors.Items.Add(item);
          }
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void ShowAuthorData(int AuthorID) 
    {
      try 
      {
        ClearTexts();
        this.panel_Book.Visible = false;
        this.panel_Category.Visible = false;
        this.panel_Author.Visible = true;
        ToggleAuthorDataForm(false);

        this.listView_Books.Items.Clear();
        this.HasBookChanges = false;
        this.dtBooks = this.rbWorker.GetAuthorBooks(AuthorID);
        this.CurrentAuthorID = AuthorID;
        this.label_CategoryLabel.Text = "   " + this.rbWorker.getAuthorCategory(this.CurrentAuthorID).Rows[0]["CategoryName"].ToString();

        if (this.dtBooks.Rows.Count > 0) 
        {
          foreach (Control c in this.panel_Author.Controls) 
          {
            c.Visible = true;
          }
          foreach (DataRow row in dtBooks.Rows) 
          {
            string[] subItems = new string[6];
            subItems[0] = row["BookID"].ToString().Trim();
            subItems[1] = row["BookTitle"].ToString().Trim();
            subItems[2] = row["GenreTx"].ToString().Trim();
            subItems[3] = ((row["PublishDate"].ToString().Trim().Equals("")) ? "N/A" : row["PublishDate"].ToString().Trim());
            subItems[4] = ((row["ModifiedDate"].ToString().Trim().Equals("")) ? "N/A" : row["ModifiedDate"].ToString().Trim());
            subItems[5] = ((row["CreatedDate"].ToString().Trim().Equals("")) ? "N/A" : row["CreatedDate"].ToString().Trim());
            ListViewItem item = new ListViewItem(subItems);
            item.Tag = subItems[1] + " (published @ " + subItems[3] + ")";
            if (this.CurrentBookID == int.Parse(row["BookID"].ToString())) 
            {
              item.Selected = true;
              item.Focused = true;
            }
            this.listView_Books.Items.Add(item);
          }
        }
        else 
        {
          //foreach (Control c in this.panel_Author.Controls) 
          //{
            //c.Visible = false;
          //}
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void ShowBookData(int BookID) 
    {
      try 
      {
        ClearTexts();
        this.panel_Category.Visible = false;
        this.panel_Author.Visible = false;
        this.panel_Book.Visible = true;
        ToggleBookDataForm(false);
        this.CurrentBookID = BookID;
        this.CurrentAuthorID = int.Parse(this.rbWorker.GetBookData(this.CurrentBookID).Rows[0]["AuthorID"].ToString());
        DataTable dt = this.rbWorker.GetAuthorData(this.CurrentAuthorID);
        string categoryName = dt.Rows[0]["CategoryName"].ToString();
        string authorName = dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["LastName"].ToString();
        this.label_CategoryLabel.Text = "   " + categoryName + " - \"" + authorName.Trim() + "\"";
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void ShowEditAuthorData(int AuthorID) 
    {
      try 
      {
        DataRow row = null;
        if (this.dtAuthors != null)
          row = (this.dtAuthors.Select("AuthorID = " + AuthorID))[0];
        else
          row = this.rbWorker.GetAuthorData(AuthorID).Rows[0];
        this.textBox_AuthorData_FirstName.Text = row["FirstName"].ToString().Trim();
        this.textBox_AuthorData_LastName.Text = row["LastName"].ToString().Trim();
        this.textBox_AuthorData_Nationality.Text = row["Nationality"].ToString().Trim();
        this.textBox_AuthorData_BirthPlace.Text = row["Birthplace"].ToString().Trim();
        this.dateTimePicker_AuthorData_BirthDate.Format = DateTimePickerFormat.Custom;
        this.dateTimePicker_AuthorData_DateOfDeath.Format = DateTimePickerFormat.Custom;
        this.dateTimePicker_AuthorData_BirthDate.CustomFormat = "dd/MM/yyyy";
        this.dateTimePicker_AuthorData_DateOfDeath.CustomFormat = "dd/MM/yyyy";
        this.dateTimePicker_AuthorData_BirthDate.Text = ((row["Birthdate"].ToString().Trim().Equals("")) ? "" : row["Birthdate"].ToString().Trim());
        this.dateTimePicker_AuthorData_DateOfDeath.Text = ((row["DateofDeath"].ToString().Trim().Equals("")) ? "" : row["DateofDeath"].ToString().Trim());
        this.textBox_AuthorData_Summary.Text = row["AuthorSummary"].ToString().Trim();
        this.textBox_AuthorData_Keywords.Text = row["Keywords"].ToString().Trim();
        this.richTextBox_AuthorData_Notes.Text = row["Notes"].ToString();
        string authorName = row["FirstName"].ToString() + " " + row["LastName"].ToString();
        this.label_AU_Edit.Text = "   Edit \"" + authorName.Trim() + "\" personal data";
        ToggleAuthorDataForm(true);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void ShowEditBookData(int BookID) 
    {
      try 
      {
        DataTable dt = this.rbWorker.GetBookData(BookID);
        DataRow rowb = dt.Rows[0];
        int genreID = int.Parse(rowb["GenreID"].ToString());
        this.textBox_BD_Title.Text = rowb["BookTitle"].ToString();
        this.textBox_BD_Summary.Text = rowb["BookSummary"].ToString();
        this.textBox_BD_Keywords.Text = rowb["Keywords"].ToString();
        this.richTextBox_BD_Notes.Text = rowb["Notes"].ToString();
        this.dateTimePicker_BD_Published.Format = DateTimePickerFormat.Custom;
        this.dateTimePicker_BD_Published.CustomFormat = "dd/MM/yyyy";
        this.dateTimePicker_BD_Published.Text = rowb["PublishDate"].ToString();

        this.comboBox_BD_Genres.Items.Clear();
        this.bookGenres = new SortedList();
        DataTable dtg = this.rbWorker.GetBookGenres();
        foreach (DataRow row in dtg.Rows) 
        {
          this.comboBox_BD_Genres.Items.Add(row["GenreTx"].ToString());
          if (genreID == int.Parse(row["GenreID"].ToString())) 
          {
            this.comboBox_BD_Genres.Text = row["GenreTx"].ToString();
            this.bookGenres.Add("@" + row["GenreID"].ToString(), row["GenreTx"].ToString());
          }
          else
            this.bookGenres.Add(row["GenreTx"].ToString(), row["GenreID"].ToString());
        }
        this.label_BD_Edit.Text = "   Edit \"" + rowb["BookTitle"].ToString().Trim() + "\" notes";
        ToggleBookDataForm(true);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void SaveBookData(int BookID) 
    {
      try 
      {
        int genreID = this.GenresGeneralCategoryID;
        try 
        {
          genreID = int.Parse(this.bookGenres[this.comboBox_BD_Genres.SelectedItem.ToString()].ToString());
        }
        catch {}
        string title = this.textBox_BD_Title.Text;
        string summary = this.textBox_BD_Summary.Text;
        string keywords = this.textBox_BD_Keywords.Text;
        string notes = this.richTextBox_BD_Notes.Text;
        string published = this.dateTimePicker_BD_Published.Text;
        this.rbWorker.UpdateBookData(BookID, genreID, title, summary, notes, keywords, published);
        PopulateCategories();
        PositionTrees();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void ToolTipOnAuthors(object sender, System.Windows.Forms.MouseEventArgs e) 
    {
      try 
      {
        ListView lvAuthors = (ListView)sender;
        ListViewItem author = lvAuthors.GetItemAt(e.X, e.Y);
        if (author != null) 
        {
          this.toolTip_LV_Authors.Active = true;
          this.toolTip_LV_Authors.SetToolTip(lvAuthors, author.Tag.ToString());
        }
        else
          this.toolTip_LV_Authors.Active = false;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void SaveAuthorData(int AuthorID) 
    {
      try 
      {
        string firstName = this.textBox_AuthorData_FirstName.Text;
        string lastName = this.textBox_AuthorData_LastName.Text;
        string nationality = this.textBox_AuthorData_Nationality.Text;
        string birthPlace = this.textBox_AuthorData_BirthPlace.Text;
        string birthDate = this.dateTimePicker_AuthorData_BirthDate.Text;
        string deathDate = this.dateTimePicker_AuthorData_DateOfDeath.Text;
        string summary = this.textBox_AuthorData_Summary.Text;
        string keywords = this.textBox_AuthorData_Keywords.Text;
        string notes = this.richTextBox_AuthorData_Notes.Text;
        this.rbWorker.UpdateAuthor(this.CurrentAuthorID, firstName, lastName, nationality, birthPlace, birthDate, deathDate, summary, notes, keywords);
        this.HasAuthorChanges = true;
        ShowCategoryData(this.CurrentCategoryID);
        PopulateCategories();
        PositionTrees();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void ToggleAuthorDataForm(bool enabledState) 
    {
      try 
      {
        if (!enabledState) 
        {
          this.label_AU_Edit.Text = "   Edit";
          this.textBox_AuthorData_BirthPlace.Text = "";
          this.textBox_AuthorData_FirstName.Text = "";
          this.textBox_AuthorData_LastName.Text = "";
          this.textBox_AuthorData_Nationality.Text = "";
          this.textBox_AuthorData_Summary.Text = "";
          this.richTextBox_AuthorData_Notes.Text = "";
          this.textBox_AuthorData_Keywords.Text = "";
        }

        this.textBox_AuthorData_BirthPlace.Enabled = enabledState;
        this.textBox_AuthorData_FirstName.Enabled = enabledState;
        this.textBox_AuthorData_LastName.Enabled = enabledState;
        this.textBox_AuthorData_Nationality.Enabled = enabledState;
        this.textBox_AuthorData_Summary.Enabled = enabledState;
        this.richTextBox_AuthorData_Notes.Enabled = enabledState;
        this.dateTimePicker_AuthorData_BirthDate.Enabled = enabledState;
        this.dateTimePicker_AuthorData_DateOfDeath.Enabled = enabledState;
        this.textBox_AuthorData_Keywords.Enabled = enabledState;
        this.button_Save.Enabled = enabledState;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void ToggleBookDataForm(bool enabledState) 
    {
      try 
      {
        if (!enabledState) 
        {
          this.label_BD_Edit.Text = "   Edit";
          this.textBox_BD_Keywords.Text = "";
          this.textBox_BD_Summary.Text = "";
          this.textBox_BD_Title.Text = "";
          this.richTextBox_BD_Notes.Text = "";
          this.dateTimePicker_BD_Published.Text = "";
        }

        this.textBox_BD_Keywords.Enabled = enabledState;
        this.textBox_BD_Summary.Enabled = enabledState;
        this.textBox_BD_Title.Enabled = enabledState;
        this.comboBox_BD_Genres.Enabled = enabledState;
        this.richTextBox_BD_Notes.Enabled = enabledState;
        this.dateTimePicker_BD_Published.Enabled = enabledState;
        this.button_BD_Save.Enabled = enabledState;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void DeleteBook(int BookID) 
    {
      try 
      {
        string mbText = "Are you sure you want to delete this book?";
        DialogResult res = MessageBox.Show(this, mbText, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
        if (res == DialogResult.Yes) 
          this.rbWorker.DeleteBook(BookID);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void DeleteAuthor(int AuthorID) 
    {
      try 
      {
        string mbText = "Are you sure you want to delete this author?";
        DialogResult res = MessageBox.Show(this, mbText, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
        if (res == DialogResult.Yes) 
          this.rbWorker.DeleteAuthor(AuthorID);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private string CheckTreeItem(string tag) 
    {
      string item = "";
      try 
      {
        if (tag.StartsWith("Category")) 
          item = "category";
        if (tag.StartsWith("Author")) 
          item = "author";
        if (tag.StartsWith("Book")) 
          item = "book";
      }
      catch (Exception ex) 
      {
        throw ex;
      }
      return item;
    }
    private void ClearTexts() 
    {
      try 
      {
        this.textBox_AuthorData_BirthPlace.Text = "";
        this.textBox_AuthorData_FirstName.Text = "";
        this.textBox_AuthorData_LastName.Text = "";
        this.textBox_AuthorData_Keywords.Text = "";
        this.textBox_AuthorData_Nationality.Text = "";
        this.textBox_AuthorData_Summary.Text = "";
        this.textBox_BD_Keywords.Text = "";
        this.textBox_BD_Summary.Text = "";
        this.textBox_BD_Title.Text = "";
        this.richTextBox_AuthorData_Notes.Text = "";
        this.richTextBox_BD_Notes.Text = "";
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void PositionTrees() 
    {
      try 
      {
        foreach (TreeListViewItem item in this.treeListView_Categories.Items) 
        {
          if (!this.ShowRelatedBook && item.Tag.ToString() == "AuthorID@" + this.CurrentAuthorID) 
          {
            item.Selected = true;
            item.Focused = true;
            item.Parent.Expand();
            foreach (TreeListViewItem sub in item.ParentsInHierarch) 
            {
              sub.Expand();
            }
            if (item.Parent.Tag.ToString() != "rooData") 
            {
              int parentCategoryID = int.Parse(item.Parent.Tag.ToString().Replace("CategoryID@", ""));
              ShowCategoryData(parentCategoryID);
            }
          }
          else if (item.Tag.ToString() == "BookID@" + this.CurrentBookID) 
          {
            this.ShowRelatedBook = false;
            item.Selected = true;
            item.Focused = true;
            item.Parent.Expand();
            foreach (TreeListViewItem sub in item.ParentsInHierarch) 
            {
              sub.Expand();
            }
            if (item.Parent.Tag.ToString() != "rooData") 
            {
              int parentAuthorID = int.Parse(item.Parent.Tag.ToString().Replace("AuthorID@", ""));
              ShowAuthorData(parentAuthorID);
            }
          }
          if (item.Items.Count > 0)
            PositionTreeWorm(item);
        }
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }
    private void PositionTreeWorm(TreeListViewItem item) 
    {
      try 
      {
        foreach (TreeListViewItem sub in item.Items) 
        {
          if (!this.ShowRelatedBook && sub.Tag.ToString() == "AuthorID@" + this.CurrentAuthorID) 
          {
            sub.Selected = true;
            sub.Focused = true;
            sub.Parent.Expand();
            foreach (TreeListViewItem subParent in sub.ParentsInHierarch) 
            {
              subParent.Expand();
            }
            if (sub.Parent.Tag.ToString() != "rooData") 
            {
              int parentCategoryID = int.Parse(sub.Parent.Tag.ToString().Replace("CategoryID@", ""));
              ShowCategoryData(parentCategoryID);
            }
          }
          else if (sub.Tag.ToString() == "BookID@" + this.CurrentBookID) 
          {
            this.ShowRelatedBook = false;
            sub.Selected = true;
            sub.Focused = true;
            sub.Parent.Expand();
            foreach (TreeListViewItem subParent in item.ParentsInHierarch) 
            {
              subParent.Expand();
            }
            if (sub.Parent.Tag.ToString() != "rooData") 
            {
              int parentAuthorID = int.Parse(sub.Parent.Tag.ToString().Replace("AuthorID@", ""));
              ShowAuthorData(parentAuthorID);
            }
          }
          if (sub.Items.Count > 0)
            PositionTreeWorm(sub);
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void AddNewAuthor() 
    {
    }
    private void AddNewBook() 
    {
    }
    private void FillSearchInCriterias() 
    {
      this.comboBox_sbIn.Items.Clear();
      this.comboBox_sbIn.Items.Add("Everywhere");
      this.comboBox_sbIn.Items.Add("Authors");
      this.comboBox_sbIn.Items.Add("Books");
      this.comboBox_sbIn.Text = "Everywhere";
    }
    private void ConductSearch(string keyword, string note) 
    {
      try 
      {
        string search_keyword = this.textBox_sbKeyword.Text.Trim();
        string search_notes = this.textBox_sbNotes.Text.Trim();
        string search_name = this.textBox_sbName.Text.Trim();
        string search_nationality = this.textBox_sbNationality.Text.Trim();
        string search_publishedFrom = this.dateTimePicker_sbPublishedFrom.Text;
        string search_publishedTo = this.dateTimePicker_sbPublishedTo.Text;
        int search_in = 0;
        if (this.comboBox_sbIn.Text == "Authors")
          search_in = 1;
        if (this.comboBox_sbIn.Text == "Books")
          search_in = 2;

        int foundAuthors = 0;
        int foundBooks = 0;

        DataTable dt_sAuthors = null;
        DataTable dt_sBooks = null;
        if (search_keyword != "" || search_notes != "" || search_name != "" || search_nationality != "") 
        {
          dt_sAuthors = this.rbWorker.SearchAuthors(search_keyword, search_notes, search_name, search_nationality);
          foundAuthors = dt_sAuthors.Rows.Count;
        }
        else if (search_keyword != "" || search_notes != "" || search_name != "" || (search_publishedFrom != "" && search_publishedTo != "")) 
        {
          dt_sBooks = this.rbWorker.SearchBooks(search_keyword, search_notes, search_nationality, search_publishedFrom, search_publishedTo);
          foundBooks = dt_sBooks.Rows.Count;
        }

        this.dockControl_Authors.Text = "Authors (" + foundAuthors + ")";
        this.dockControl_Books.Text = "Books (" + foundBooks + ")";

        if ((search_in == 1 || search_in == 0) && dt_sAuthors != null) 
          FillFoundAuthors(dt_sAuthors);
        else if ((search_in == 2 || search_in == 0) && dt_sBooks != null) 
          FillFoundBooks(dt_sBooks);
        else if (dt_sAuthors != null && dt_sBooks != null)
        {
          FillFoundAuthors(dt_sAuthors);
          FillFoundBooks(dt_sBooks);
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void FillFoundAuthors(DataTable dt) 
    {
      try 
      {
        this.listView_sr_Authors.Items.Clear();
        foreach (DataRow row in dt.Rows) 
        {
          string authorName = row["FirstName"].ToString().Trim() + " " + row["LastName"].ToString().Trim();
          string[] subItems = new string[7];
          subItems[0] = row["AuthorID"].ToString().Trim();
          subItems[1] = authorName;
          subItems[2] = row["CategoryName"].ToString().Trim();
          subItems[3] = ((row["Nationality"].ToString().Trim().Equals("")) ? "N/A" : row["Nationality"].ToString().Trim());
          subItems[4] = ((row["Birthplace"].ToString().Trim().Equals("")) ? "N/A" : row["Birthplace"].ToString().Trim());
          subItems[5] = ((row["ModifiedDate"].ToString().Trim().Equals("")) ? "N/A" : row["ModifiedDate"].ToString().Trim());
          subItems[6] = ((row["CreatedDate"].ToString().Trim().Equals("")) ? "N/A" : row["CreatedDate"].ToString().Trim());
          ListViewItem item = new ListViewItem(subItems);
          item.Tag = subItems[1] + " (last modified @ " + subItems[4] + ")";
          this.listView_sr_Authors.Items.Add(item);
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    private void FillFoundBooks(DataTable dt) 
    {
      try 
      {
        this.listView_sr_Books.Items.Clear();
        foreach (DataRow row in dt.Rows) 
        {
          string authorName = row["FirstName"].ToString().Trim() + " " + row["LastName"].ToString().Trim();
          string[] subItems = new string[6];
          subItems[0] = row["BookID"].ToString().Trim();
          subItems[1] = row["BookTitle"].ToString().Trim();
          subItems[2] = authorName;
          subItems[3] = row["GenreTx"].ToString().Trim();
          subItems[4] = ((row["ModifiedDate"].ToString().Trim().Equals("")) ? "N/A" : row["ModifiedDate"].ToString().Trim());
          subItems[5] = ((row["CreatedDate"].ToString().Trim().Equals("")) ? "N/A" : row["CreatedDate"].ToString().Trim());
          ListViewItem item = new ListViewItem(subItems);
          item.Tag = subItems[1] + " (last modified @ " + subItems[3] + ")";
          this.listView_sr_Books.Items.Add(item);
        }
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    private void ShowFoundAuthor(int AuthorID) 
    {
      try 
      {
        ShowRelatedAuthorData(AuthorID);
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }
    private void ShowFoundBook(int BookID) 
    {
      try 
      {
        ShowRelatedBookData(BookID);
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }
    private void SortListView(System.Windows.Forms.ColumnClickEventArgs e, ref ListView lv) 
    {
      // Determine if clicked column is already the column that is being sorted.
      if (e.Column == this.lvwColumnSorter.SortColumn)
      {
        // Reverse the current sort direction for this column.
        if (this.lvwColumnSorter.Order == SortOrder.Ascending)
        {
          this.lvwColumnSorter.Order = SortOrder.Descending;
        }
        else
        {
          this.lvwColumnSorter.Order = SortOrder.Ascending;
        }
      }
      else
      {
        // Set the column number that is to be sorted; default to ascending.
        this.lvwColumnSorter.SortColumn = e.Column;
        this.lvwColumnSorter.Order = SortOrder.Ascending;
      }

      // Perform the sort with these new sort options.
      lv.Sort();
    }
    #endregion

    #region Error handling
    public void MsgError(Exception ex, int errorLevel) 
    {
      string mbText = ((errorLevel == 1) ? ex.Message : ex.StackTrace);
      string mbCaption = "Exception occured";
      MessageBox.Show(this, mbText, mbCaption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }
    #endregion

  }
}
