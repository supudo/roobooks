using System;
using System.Collections;

namespace Library
{
	public class rbGenre
  {

    #region Properties
    private int genreID = 0;
    public int GenreID
    {
      get 
      {
        return genreID;
      }
      set 
      {
        genreID = value;
      }
    }

    private string genreTx = "";
    public string GenreTx
    {
      get 
      {
        return genreTx;
      }
      set 
      {
        genreTx = value;
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
    #endregion

		public rbGenre()
		{
		}
	}
}
