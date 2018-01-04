using System;
using System.Collections;

namespace Library
{
	public class rbKeywords : System.Collections.SortedList
  {

    #region Properties
    private int keywordsID = 0;
    public int KeywordsID
    {
      get 
      {
        return keywordsID;
      }
      set 
      {
        keywordsID = value;
      }
    }

    private int itemID = 0;
    public int ItemID
    {
      get 
      {
        return itemID;
      }
      set 
      {
        itemID = value;
      }
    }

    private string keywords = "";
    public string Keywords
    {
      get 
      {
        return keywords;
      }
      set 
      {
        keywords = value;
      }
    }

    private string tableName = "";
    public string TableName
    {
      get 
      {
        return tableName;
      }
      set 
      {
        tableName = value;
      }
    }
    #endregion

		public rbKeywords(int itemID, string tableName)
		{
      this.ItemID = itemID;
      this.TableName = tableName;
		}
	}
}
