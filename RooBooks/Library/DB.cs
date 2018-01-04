using System;
using System.Collections;
using System.Data;
using System.Data.Odbc;

namespace RooBooks.Library
{
	/// <summary>
	/// Summary description for RooBooks_BL.
	/// </summary>
  public class DB
  {
    private OdbcDataAdapter mdbAdapter = new OdbcDataAdapter();
    private OdbcConnection mdbConnection = new OdbcConnection();
    private OdbcCommand mdbCommand = new OdbcCommand();
    private DataSet dataSet = new DataSet();
    private Settings worker = new Settings();

    #region Properties
    private string removeItemID = "";
    public string RemoveItemID
    {
      get 
      {
        return removeItemID;
      }
      set 
      {
        removeItemID = value;
      }
    }
    #endregion

    public DB()
    {
      this.mdbAdapter.SelectCommand = this.mdbCommand;
      this.mdbCommand.Connection = this.mdbConnection;
      this.mdbConnection.ConnectionString = this.worker.getDBConnectionString();
      this.mdbConnection.Open();
    }

    /* ============================================================================
     * 
     * FreeAll
     * 
     * 
     * ============================================================================
     */
    public void FreeAll() 
    {
      try 
      {
        this.mdbConnection.Close();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetCategoriesTree
     * 
     * 
     * ============================================================================
     */
    public DataTable GetCategoriesTree() 
    {
      try 
      {
        if (this.dataSet.Tables["CategoriesTree"] != null)
          this.dataSet.Tables["CategoriesTree"].Clear();
        string sql = "SELECT DISTINCT c.CategoryID, c.ParentID, c.CategoryName, c.CategorySummary, a.AuthorID, a.CategoryID AS AuthorCategoryID, a.FirstName, a.LastName, a.AuthorSummary, b.BookID, b.AuthorID AS BookAuthorID, b.BookTitle, b.BookSummary " +
          "FROM (Categories AS c LEFT JOIN Authors AS a ON a.CategoryID=c.CategoryID) LEFT JOIN Books AS b ON b.AuthorID=a.AuthorID " + 
          "ORDER BY c.CategoryName, a.LastName, b.BookTitle";
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "CategoriesTree");
        return this.dataSet.Tables["CategoriesTree"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * RemoveItem
     * 
     * 
     * ============================================================================
     */
    public void RemoveItem() 
    {
      try 
      {
        string sql = "";
        string[] itemData = this.RemoveItemID.Split('@');
        if (itemData[0] == "CategoryID") 
          sql = "DELETE FROM Categories WHERE CategoryID=" + itemData[1] + " OR ParentID=" + itemData[1];
        if (itemData[0] == "AuthorID") 
          sql = "DELETE FROM Authors WHERE AuthorID=" + itemData[1];
        if (itemData[0] == "BookID") 
          sql = "DELETE FROM Books WHERE BookID=" + itemData[1];
        this.mdbCommand.CommandText = sql;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * AddCategoryItem
     * 
     * 
     * ============================================================================
     */
    public void AddCategoryItem(int ParentID, string CategoryName) 
    {
      try 
      {
        this.mdbCommand.CommandText = "INSERT INTO Categories (ParentID, CategoryName, CreatedDate) VALUES (" + ParentID + ", '" + CategoryName + "', Date())";;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * AddAuthorItem
     * 
     * 
     * ============================================================================
     */
    public void AddAuthorItem(int ParentID, string FirstName, string LastName) 
    {
      try 
      {
        this.mdbCommand.CommandText = "INSERT INTO Authors (AuthorCategoryID, FirstName, LastName, CreatedDate) VALUES (" + ParentID + ", '" + FirstName + "', '" + LastName + "', Date())";
        this.mdbCommand.ExecuteNonQuery();
        this.mdbCommand.CommandText = "INSERT INTO AuthorsData (AuthorID, Notes) VALUES (" + ParentID + ", '');";
        this.mdbCommand.ExecuteNonQuery();
        this.mdbCommand.CommandText = "INSERT INTO AuthorsKeywords (AuthorID, Keywords) VALUES (" + ParentID + ", '');";
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * AddBookItem
     * 
     * 
     * ============================================================================
     */
    public void AddBookItem(int ParentID, string BookTitle, int GenreID) 
    {
      try 
      {
        this.mdbCommand.CommandText = "INSERT INTO Books (AuthorID, BookTitle, GenreID, CreatedDate) VALUES (" + ParentID + ", '" + BookTitle + "', " + GenreID + ", Date())";
        this.mdbCommand.ExecuteNonQuery();
        this.mdbCommand.CommandText = "SELECT @@IDENTITY";
        int lastBookID = int.Parse(this.mdbCommand.ExecuteScalar().ToString());
        this.mdbCommand.CommandText = "INSERT INTO BooksData (BookID, Notes) VALUES (" + lastBookID + ", '')";
        this.mdbCommand.ExecuteNonQuery();
        this.mdbCommand.CommandText = "INSERT INTO BooksKeywords (BookID, Keywords) VALUES (" + lastBookID + ", '')";
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * AddRelatedAuthor
     * 
     * 
     * ============================================================================
     */
    public void AddRelatedAuthor(int SourceID, int DestinationID) 
    {
      try 
      {
        this.mdbCommand.CommandText = "INSERT INTO RelatedAuthors (SourceAuthorID, DestinationAuthorID) VALUES (" + SourceID + ", " + DestinationID + ")";
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * AddRelatedBook
     * 
     * 
     * ============================================================================
     */
    public void AddRelatedBook(int SourceID, int DestinationID) 
    {
      try 
      {
        this.mdbCommand.CommandText = "INSERT INTO RelatedBooks (SourceBookID, DestinationBookID) VALUES (" + SourceID + ", " + DestinationID + ")";
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetCategoryAuthors
     * 
     * 
     * ============================================================================
     */
    public DataTable GetCategoryAuthors(int CategoryID) 
    {
      try 
      {
        if (this.dataSet.Tables["CategoriesAuthorsTree"] != null)
          this.dataSet.Tables["CategoriesAuthorsTree"].Clear();
        string sql = "SELECT DISTINCT t1.AuthorID, t1.CategoryID, t1.FirstName, t1.LastName, t1.Nationality, t1.Birthdate, t1.Birthplace, t1.DateofDeath, t1.AuthorSummary, t1.CreatedDate, t1.ModifiedDate, ak.Keywords, t2.AuthorDataID, t2.Notes " +
                     "FROM (Authors AS t1 INNER JOIN AuthorsKeywords AS ak ON ak.AuthorID = t1.AuthorID) INNER JOIN AuthorsData AS t2 ON t2.AuthorID = t1.AuthorID " + 
                     "ORDER BY t1.FirstName, t1.LastName";
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "CategoriesAuthorsTree");
        return this.dataSet.Tables["CategoriesAuthorsTree"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * getAuthorCategory
     * 
     * 
     * ============================================================================
     */
    public DataTable getAuthorCategory(int AuthorID) 
    {
      try 
      {
        if (this.dataSet.Tables["AuthorCategory"] != null)
          this.dataSet.Tables["AuthorCategory"].Clear();
        string sql = "SELECT DISTINCT c.CategoryName FROM Categories AS c INNER JOIN Authors AS a ON a.CategoryID = c.CategoryID WHERE a.AuthorID = " + AuthorID;
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "AuthorCategory");
        return this.dataSet.Tables["AuthorCategory"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetRelatedAuthors
     * 
     * 
     * ============================================================================
     */
    public DataTable GetRelatedAuthors(int AuthorID) 
    {
      try 
      {
        if (this.dataSet.Tables["AuthorRelatedAuthors"] != null)
          this.dataSet.Tables["AuthorRelatedAuthors"].Clear();
        this.mdbCommand.CommandText = "SELECT DISTINCT RelatedAuthorsID, DestinationAuthorID FROM RelatedAuthors WHERE SourceAuthorID = " + AuthorID;
        this.mdbAdapter.Fill(this.dataSet, "AuthorRelatedAuthors");
        return this.dataSet.Tables["AuthorRelatedAuthors"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetRelatedAuthorsFull
     * 
     * 
     * ============================================================================
     */
    public DataTable GetRelatedAuthorsFull(int AuthorID) 
    {
      try 
      {
        if (this.dataSet.Tables["AuthorRelatedAuthorsFull"] != null)
          this.dataSet.Tables["AuthorRelatedAuthorsFull"].Clear();
        string sql = "SELECT Authors_1.AuthorID, Authors_1.CategoryID, Authors_1.Name, Authors_1.Nationality, AuthorsKeywords.Keywords, Categories.CategoryName " +
                     "FROM ((RelatedAuthors INNER JOIN Authors AS Authors_1 ON RelatedAuthors.DestinationAuthorID = Authors_1.AuthorID) INNER JOIN AuthorsKeywords ON Authors_1.AuthorID = AuthorsKeywords.AuthorID) INNER JOIN Categories ON Authors_1.CategoryID = Categories.CategoryID " +
                     "WHERE (((RelatedAuthors.SourceAuthorID) = " + AuthorID + "));";
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "AuthorRelatedAuthorsFull");
        return this.dataSet.Tables["AuthorRelatedAuthorsFull"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetRelatedBooks
     * 
     * 
     * ============================================================================
     */
    public DataTable GetRelatedBooks(int BookID) 
    {
      try 
      {
        if (this.dataSet.Tables["BookRelatedBooks"] != null)
          this.dataSet.Tables["BookRelatedBooks"].Clear();
        this.mdbCommand.CommandText = "SELECT DISTINCT RelatedBookID, DestinationBookID FROM RelatedBooks WHERE SourceBookID = " + BookID;
        this.mdbAdapter.Fill(this.dataSet, "BookRelatedBooks");
        return this.dataSet.Tables["BookRelatedBooks"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetRelatedBooksFull
     * 
     * 
     * ============================================================================
     */
    public DataTable GetRelatedBooksFull(int BookID) 
    {
      try 
      {
        if (this.dataSet.Tables["BookRelatedBooksFull"] != null)
          this.dataSet.Tables["BookRelatedBooksFull"].Clear();
        string sql = "SELECT Books.BookID, Books.BookTitle, Books.PublishDate, Genres.GenreTx, Categories.CategoryName " +
                     "FROM Categories INNER JOIN (Genres INNER JOIN (Authors INNER JOIN (RelatedBooks INNER JOIN Books ON RelatedBooks.DestinationBookID = Books.BookID) ON Authors.AuthorID = Books.AuthorID) ON Genres.GenreID = Books.GenreID) ON Categories.CategoryID = Authors.CategoryID " +
                     "WHERE (((RelatedBooks.SourceBookID)=" + BookID + "))";
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "BookRelatedBooksFull");
        return this.dataSet.Tables["BookRelatedBooksFull"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetAllAuthorsSimple
     * 
     * 
     * ============================================================================
     */
    public DataTable GetAllAuthorsSimple(int ExcludeAuthorID) 
    {
      try 
      {
        if (this.dataSet.Tables["AllAuthorsSimple"] != null)
          this.dataSet.Tables["AllAuthorsSimple"].Clear();
        string sql = "SELECT DISTINCT AuthorID, FirstName, LastName, AuthorSummary FROM Authors ORDER BY FirstName, LastName";
        if (ExcludeAuthorID > 0)
          sql = "SELECT DISTINCT AuthorID, FirstName, LastName, AuthorSummary FROM Authors WHERE AuthorID <> " + ExcludeAuthorID + " ORDER BY FirstName, LastName";
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "AllAuthorsSimple");
        return this.dataSet.Tables["AllAuthorsSimple"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * UpdateAuthor
     * 
     * 
     * ============================================================================
     */
    public void UpdateAuthor(int AuthorID, string firstName, string lastName, string nationality, string birthPlace, string birthDate, string deathDate, string summary, string notes, string keywords) 
    {
      try 
      {
        string sql = "UPDATE Authors SET " +
                     "Name = '" + firstName + " " + lastName + "', " +
                     "FirstName = '" + firstName + "', LastName = '" + lastName + "', " +
                     "Nationality = '" + nationality + "', Birthplace = '" + birthPlace + "', " +
                     "Birthdate = #" + birthDate + "#, DateofDeath = #" + deathDate + "#, " +
                     "AuthorSummary = '" + summary + "', " + 
                     "ModifiedDate = Now() " + 
                     "WHERE AuthorID = " + AuthorID;
        this.mdbCommand.CommandText = sql;
        this.mdbCommand.ExecuteNonQuery();
        string sql2 = "UPDATE AuthorsData SET " +
                      "Notes = '" + notes.Replace("'", "''") + "' " + 
                      "WHERE AuthorID = " + AuthorID;
        this.mdbCommand.CommandText = sql2;
        this.mdbCommand.ExecuteNonQuery();
        this.mdbCommand.CommandText = "UPDATE AuthorsKeywords SET Keywords = '" + keywords + "' WHERE AuthorID = " + AuthorID;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * UpdateBookData
     * 
     * 
     * ============================================================================
     */
    public void UpdateBookData(int BookID, int genreID, string title, string summary, string notes, string keywords, string published) 
    {
      try 
      {
        string sql = "UPDATE Books SET " +
          "BookTitle = '" + title + "', " +
          "BookSummary = '" + summary + "', " +
          "GenreID = '" + genreID + "', " +
          "PublishDate = #" + published + "#, " +
          "ModifiedDate = Now() " + 
          "WHERE BookID = " + BookID;
        this.mdbCommand.CommandText = sql;
        this.mdbCommand.ExecuteNonQuery();
        string sql2 = "UPDATE BooksData SET " +
          "Notes = '" + notes.Replace("'", "''") + "' " + 
          "WHERE BookID = " + BookID;
        this.mdbCommand.CommandText = sql2;
        this.mdbCommand.ExecuteNonQuery();
        this.mdbCommand.CommandText = "UPDATE BooksKeywords SET Keywords = '" + keywords + "' WHERE BookID = " + BookID;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * UpdateBookNotes
     * 
     * 
     * ============================================================================
     */
    public void UpdateBookNotes(int BookID, string notes) 
    {
      try 
      {
        this.mdbCommand.CommandText = "UPDATE BooksData SET  Notes = '" + notes.Substring(0, notes.Length - 2).Replace("'", "''") + "' WHERE BookID = " + BookID;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetAuthorData
     * 
     * 
     * ============================================================================
     */
    public DataTable GetAuthorData(int AuthorID) 
    {
      try 
      {
        if (this.dataSet.Tables["AuthorBooks"] != null)
          this.dataSet.Tables["AuthorBooks"].Clear();
        //this.mdbCommand.CommandText = "SELECT DISTINCT Categories.CategoryName, Authors.FirstName, Authors.LastName, Authors.* FROM Authors INNER JOIN Categories ON Categories.CategoryID = Authors.CategoryID WHERE Authors.AuthorID = " + AuthorID;
        string sql = "SELECT DISTINCT c.CategoryName, t1.AuthorID, t1.CategoryID, t1.FirstName, t1.LastName, t1.Nationality, t1.Birthdate, t1.Birthplace, t1.DateofDeath, t1.AuthorSummary, t1.CreatedDate, t1.ModifiedDate, ak.Keywords, t2.AuthorDataID, t2.Notes " +
                     "FROM ((Authors AS t1 INNER JOIN AuthorsKeywords AS ak ON ak.AuthorID = t1.AuthorID) INNER JOIN AuthorsData AS t2 ON t2.AuthorID = t1.AuthorID) INNER JOIN Categories AS c ON c.CategoryID =  t1.CategoryID " + 
                     "WHERE t1.AuthorID = " + AuthorID;
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "AuthorBooks");
        return this.dataSet.Tables["AuthorBooks"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetAuthorBooks
     * 
     * 
     * ============================================================================
     */
    public DataTable GetAuthorBooks(int AuthorID) 
    {
      try 
      {
        if (this.dataSet.Tables["AuthorBooks"] != null)
          this.dataSet.Tables["AuthorBooks"].Clear();
        string sql = "SELECT DISTINCT Categories.CategoryID, Books.BookID, Books.AuthorID, Books.BookTitle, Books.BookSummary, Books.PublishDate, Books.CreatedDate, Books.ModifiedDate, BooksData.Notes, Genres.GenreTx, Categories.CategoryName " +
          "FROM Genres INNER JOIN (Categories INNER JOIN ((Authors INNER JOIN Books ON Authors.AuthorID = Books.AuthorID) INNER JOIN BooksData ON Books.BookID = BooksData.BookID) ON Categories.CategoryID = Authors.CategoryID) ON Genres.GenreID = Books.GenreID " +
          "WHERE (((Books.AuthorID)=" + AuthorID + ")) " +
          "ORDER BY Books.AuthorID;";
        //string sql = "SELECT Books.BookID, Books.AuthorID, Books.BookTitle, Books.BookSummary, Books.CreatedDate, Books.ModifiedDate, BooksData.Notes, Genres.GenreTx " +
        //             "FROM Genres INNER JOIN (Books INNER JOIN BooksData ON Books.BookID = BooksData.BookID) ON Genres.GenreID = Books.GenreID " +
        //            "WHERE Books.AuthorID = " + AuthorID + " " +
        //             "ORDER BY Books.AuthorID;";
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "AuthorBooks");
        return this.dataSet.Tables["AuthorBooks"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetBookData
     * 
     * 
     * ============================================================================
     */
    public DataTable GetBookData(int BookID) 
    {
      try 
      {
        if (this.dataSet.Tables["BookData"] != null)
          this.dataSet.Tables["BookData"].Clear();
        string sql = "SELECT DISTINCT b.AuthorID, a.CategoryID, b.GenreID, b.BookTitle, b.BookSummary, b.PublishDate, bd.Notes, bk.Keywords " + 
                     "FROM ((Books AS b INNER JOIN BooksData AS bd ON bd.BookID = b.BookID) INNER JOIN BooksKeywords AS bk ON bk.BookID = b.BookID) INNER JOIN Authors AS a ON a.AuthorID = b.AuthorID " + 
                     "WHERE b.BookID = " + BookID;
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "BookData");
        return this.dataSet.Tables["BookData"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * GetBookGenres
     * 
     * 
     * ============================================================================
     */
    public DataTable GetBookGenres() 
    {
      try 
      {
        if (this.dataSet.Tables["BookGenres"] != null)
          this.dataSet.Tables["BookGenres"].Clear();
        this.mdbCommand.CommandText = "SELECT DISTINCT GenreID, GenreTx FROM Genres ORDER BY GenreTx";
        this.mdbAdapter.Fill(this.dataSet, "BookGenres");
        return this.dataSet.Tables["BookGenres"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * DeleteCategory
     * 
     * 
     * ============================================================================
     */
    public void DeleteCategory(int CategoryID) 
    {
      try 
      {
        string sql = "DELETE FROM Categories WHERE CategoryID = " + CategoryID;
        this.mdbCommand.CommandText = sql;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * DeleteAuthor
     * 
     * 
     * ============================================================================
     */
    public void DeleteAuthor(int AuthorID) 
    {
      try 
      {
        string sql = "DELETE FROM Authors WHERE AuthorID = " + AuthorID;
        this.mdbCommand.CommandText = sql;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * RemoveRelatedAuthors
     * 
     * 
     * ============================================================================
     */
    public void RemoveRelatedAuthors(int AuthorID) 
    {
      try 
      {
        this.mdbCommand.CommandText = "DELETE FROM RelatedAuthors WHERE SourceAuthorID = " + AuthorID;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * RemoveRelatedAuthor
     * 
     * 
     * ============================================================================
     */
    public void RemoveRelatedAuthor(int SourceAuthorID, int DestinationAuthorID) 
    {
      try 
      {
        this.mdbCommand.CommandText = "DELETE FROM RelatedAuthors WHERE SourceAuthorID = " + SourceAuthorID + " AND DestinationAuthorID = " + DestinationAuthorID;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * RemoveRelatedBooks
     * 
     * 
     * ============================================================================
     */
    public void RemoveRelatedBooks(int BookID) 
    {
      try 
      {
        this.mdbCommand.CommandText = "DELETE FROM RelatedBooks WHERE SourceBookID = " + BookID;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * RemoveRelatedBook
     * 
     * 
     * ============================================================================
     */
    public void RemoveRelatedBook(int SourceBookID, int DestinationBookID) 
    {
      try 
      {
        this.mdbCommand.CommandText = "DELETE FROM RelatedBooks WHERE SourceBookID = " + SourceBookID + " AND DestinationBookID = " + DestinationBookID;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * DeleteBook
     * 
     * 
     * ============================================================================
     */
    public void DeleteBook(int BookID) 
    {
      try 
      {
        this.mdbCommand.CommandText = "DELETE FROM Books WHERE BookID = " + BookID;
        this.mdbCommand.ExecuteNonQuery();
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * SearchAuthors
     * 
     *
     * ============================================================================
     */
    public DataTable SearchAuthors(string andOrKeyword, string keyword, string andOrNotes, string notes, string andOrNameTitle, string name, string andOrNationality, string nationality) 
    {
      try 
      {
        if (this.dataSet.Tables["SearchAuthors"] != null)
          this.dataSet.Tables["SearchAuthors"].Clear();

        ArrayList where = new ArrayList();
        if (keyword != "")
          where.Add(" " + andOrKeyword + " (((AuthorsKeywords.Keywords) Like '%" + keyword + "%'))");
        if (notes != "")
          where.Add(" " + andOrNotes + " (((AuthorsData.Notes) Like '%" + notes + "%'))");
        if (name != "")
          where.Add(" " + andOrNameTitle + " (((Authors.Name) Like '%" + name + "%'))");
        if (nationality != "")
          where.Add(" " + andOrNationality + " (((Authors.Nationality) Like '%" + nationality + "%'))");

        string wstr = "";
        string andWhere = "";
        string orWhere = "";
        object[] where_clauses = (object[])where.ToArray();
        for (int i=0; i<where_clauses.Length; i++)
        {
          wstr = (string)where_clauses[i];
          if (wstr.StartsWith(" OR "))
            orWhere += wstr;
          else
            andWhere += wstr;
        }
        wstr = "";
        if (andWhere.Length > 0)
          wstr = "(" + andWhere.Substring(4) + ")";
        if (orWhere.Length > 0)
          wstr += " OR (" + orWhere.Substring(4) + ")";
        if (wstr.StartsWith(" AND "))
          wstr = wstr.Substring(5);
        else
          wstr = wstr.Substring(4);

        string sql = "SELECT Authors.AuthorID, Authors.FirstName, Authors.LastName, Authors.Nationality, Authors.Birthplace, Authors.CreatedDate, Authors.ModifiedDate, Categories.CategoryID, Categories.CategoryName " +
                     "FROM Categories INNER JOIN ((Authors INNER JOIN AuthorsData ON Authors.AuthorID = AuthorsData.AuthorID) INNER JOIN AuthorsKeywords ON Authors.AuthorID = AuthorsKeywords.AuthorID) ON Categories.CategoryID = Authors.CategoryID " +
                     "WHERE " + wstr + " " +
                     "ORDER BY Authors.ModifiedDate DESC";
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "SearchAuthors");
        return this.dataSet.Tables["SearchAuthors"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * SearchBooks
     * 
     *
     * ============================================================================
     */
    public DataTable SearchBooks(string andOrKeyword, string keyword, string andOrNotes, string notes, string andOrNameTitle, string name, string andOrPublishedDate, string published_from, string published_to) 
    {
      try 
      {
        if (this.dataSet.Tables["SearchBooks"] != null)
          this.dataSet.Tables["SearchBooks"].Clear();
        
        ArrayList where = new ArrayList();
        if (keyword != "")
          where.Add(" " + andOrKeyword + " (((BooksKeywords.Keywords) Like '%" + keyword + "%'))");
        if (notes != "")
          where.Add(" " + andOrNotes + " (((BooksData.Notes) Like '%" + notes + "%'))");
        if (name != "")
          where.Add(" " + andOrNameTitle + " (((Books.BookTitle) Like '%" + name + "%'))");
        if (published_from != "" && published_to != "")
          where.Add(" " + andOrPublishedDate + " (((Books.PublishDate) >= #" + published_from + "# AND (Books.PublishDate) <= #" + published_to + "#))");

        string wstr = "";
        string andWhere = "";
        string orWhere = "";
        object[] where_clauses = (object[])where.ToArray();
        for (int i=0; i<where_clauses.Length; i++)
        {
          wstr = (string)where_clauses[i];
          if (wstr.StartsWith(" OR "))
            orWhere += wstr;
          else
            andWhere += wstr;
        }
        wstr = "";
        if (andWhere.Length > 0)
          wstr = "(" + andWhere.Substring(4) + ")";
        if (orWhere.Length > 0)
          wstr += " OR (" + orWhere.Substring(4) + ")";
        if (wstr.StartsWith(" AND "))
          wstr = wstr.Substring(5);
        else
          wstr = wstr.Substring(4);

        string sql = "SELECT Books.BookID, Genres.GenreID, Authors.AuthorID, Books.BookTitle, Books.CreatedDate, Books.ModifiedDate, Genres.GenreTx, Authors.FirstName, Authors.LastName " +
                     "FROM Authors INNER JOIN (Genres INNER JOIN ((Books INNER JOIN BooksData ON Books.BookID = BooksData.BookID) INNER JOIN BooksKeywords ON Books.BookID = BooksKeywords.BookID) ON Genres.GenreID = Books.GenreID) ON Authors.AuthorID = Books.AuthorID " +
                     "WHERE " + wstr + " " +
                     "ORDER BY Books.ModifiedDate DESC";
        this.mdbCommand.CommandText = sql;
        this.mdbAdapter.Fill(this.dataSet, "SearchBooks");
        return this.dataSet.Tables["SearchBooks"].DefaultView.Table;
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
  }
}
