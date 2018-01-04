using System;
using System.Collections;
using RooBooks.Library;

namespace Library
{
	public class rbCategory
	{

    #region Properties
    private int categoryID = 0;
    public int CategoryID
    {
      get 
      {
        return categoryID;
      }
      set 
      {
        categoryID = value;
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

    private string categoryName = "";
    public string CategoryName
    {
      get 
      {
        return categoryName;
      }
      set 
      {
        categoryName = value;
      }
    }

    private string categorySummary = "";
    public string CategorySummary
    {
      get 
      {
        return categorySummary;
      }
      set 
      {
        categorySummary = value;
      }
    }

    private DateTime createdDate = DateTime.Now;
    public DateTime CreatedDate
    {
      get 
      {
        return createdDate;
      }
      set 
      {
        createdDate = value;
      }
    }

    private DateTime modifiedDate = DateTime.Now;
    public DateTime ModifiedDate
    {
      get 
      {
        return modifiedDate;
      }
      set 
      {
        modifiedDate = value;
      }
    }

    #endregion

		public rbCategory(int categoryID)
		{
      this.CategoryID = categoryID;
    }

    public rbCategory(int parentID, string categoryName, string categorySummary)
    {
      this.ParentID = parentID;
      this.CategoryName = categoryName;
      this.CategorySummary = categorySummary;
      this.CreatedDate = DateTime.Now;
      this.ModifiedDate = DateTime.Now;
    }

    public void SaveCategory() 
    {
      try 
      {
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    public void DeleteCategory() 
    {
      try 
      {
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
	}
}
