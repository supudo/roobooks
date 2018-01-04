using System;
using System.Collections;

namespace Library
{
	public class rbAuthor
  {

    #region Properties
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

    private string name = "";
    public string Name
    {
      get 
      {
        return name;
      }
      set 
      {
        name = value;
      }
    }

    private string firstName = "";
    public string FirstName
    {
      get 
      {
        return firstName;
      }
      set 
      {
        firstName = value;
      }
    }

    private string lastName = "";
    public string LastName
    {
      get 
      {
        return lastName;
      }
      set 
      {
        lastName = value;
      }
    }

    private string nationality = "";
    public string Nationality
    {
      get 
      {
        return nationality;
      }
      set 
      {
        nationality = value;
      }
    }

    private DateTime birthDate = DateTime.Now;
    public DateTime BirthDate
    {
      get 
      {
        return birthDate;
      }
      set 
      {
        birthDate = value;
      }
    }

    private string birthPlace = "";
    public string BirthPlace
    {
      get 
      {
        return birthPlace;
      }
      set 
      {
        birthPlace = value;
      }
    }

    private DateTime dateOfDeath = DateTime.Now;
    public DateTime DateOfDeath
    {
      get 
      {
        return dateOfDeath;
      }
      set 
      {
        dateOfDeath = value;
      }
    }

    private string authorSummary = "";
    public string AuthorSummary
    {
      get 
      {
        return authorSummary;
      }
      set 
      {
        authorSummary = value;
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
    private string notes = "";
    public string Notes
    {
      get 
      {
        return notes;
      }
      set 
      {
        notes = value;
      }
    }
    private ArrayList relatedAuthors = null;
    public ArrayList RelatedAuthors
    {
      get 
      {
        return relatedAuthors;
      }
      set 
      {
        relatedAuthors = value;
      }
    }
    #endregion

		public rbAuthor(int authorID)
		{
      this.AuthorID = authorID;
		}
	}
}
