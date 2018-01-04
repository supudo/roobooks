using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using Microsoft.Win32;

namespace RooBooks.Library
{

	/// <summary>
	/// Summary description for RooBooks_Workers.
	/// </summary>
	public class Settings
  {

    #region Own declarations
    private NameValueCollection xmlReferences;
    #endregion

    #region Constructor
		public Settings()
		{
      this.xmlReferences = (NameValueCollection)ConfigurationSettings.AppSettings;
    }
    #endregion

    #region Globals
    /* ============================================================================
     * 
     * getSetting
     * 
     * 
     * ============================================================================
     */
    public string getSetting(string key) 
    {
      string ret = "";
      try 
      {
        ret = this.xmlReferences[key];
      }
      catch (Exception ex) 
      {
        throw ex;
      }
      return ret;
    }

    /* ============================================================================
     * 
     * SaveWindowSettings
     * 
     * 
     * ============================================================================
     */
    public void SaveWindowSettings(int width, int height, int left, int top) 
    {
      try 
      {
        RegistryKey key = Registry.CurrentUser.CreateSubKey(this.xmlReferences["RegistryPath"]);
        key.SetValue("WindowHeight", height);
        key.SetValue("WindowWidth", width);
        key.SetValue("WindowLeft", left);
        key.SetValue("WindowTop", top);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    #endregion

    #region RegistrySettings
    /* ============================================================================
     * 
     * getRegistrySetting
     * 
     * 
     * ============================================================================
     */
    public object getRegistrySetting(string key) 
    {
      object ret = "";
      try 
      {
        ret = Registry.CurrentUser.OpenSubKey(this.xmlReferences["RegistryPath"]).GetValue(key);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
      return ret;
    }

    /* ============================================================================
     * 
     * setRegistrySetting
     * 
     * 
     * ============================================================================
     */
    public void setRegistrySetting(string key, string val) 
    {
      try 
      {
        RegistryKey rKey = Registry.CurrentUser.CreateSubKey(this.xmlReferences["RegistryPath"]);
        rKey.SetValue(key, val);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }

    /* ============================================================================
     * 
     * SaveGridsSettings
     * 
     * 
     * ============================================================================
     */
    public void SaveGridsSettings(bool categories_T_Gridlines, bool authors_LV_Gridlines, bool books_LV_Gridlines) 
    {
      try 
      {
        RegistryKey key = Registry.CurrentUser.CreateSubKey(this.xmlReferences["RegistryPath"]);
        key.SetValue("CategoriesTreeGridlines", ((categories_T_Gridlines) ? "true" : "false"));
        key.SetValue("AuthorListViewGridLines", ((authors_LV_Gridlines) ? "true" : "false"));
        key.SetValue("BooksListViewGridLines", ((books_LV_Gridlines) ? "true" : "false"));
      }
      catch (Exception ex) 
      {
        throw ex;
      }
    }
    #endregion

    #region Workers
    /* ============================================================================
     * 
     * SaveGridsSettings
     * 
     * 
     * ============================================================================
     */
    public string getDBConnectionString() 
    {
      string ret = "";
      try 
      {
        string p = this.getRegistrySetting("ApplicationInstallPath") + "\\" + this.getRegistrySetting("DatabasePath");
        ret = this.xmlReferences["ConnectionString"].Replace("[DEFAULT_DIR]", p);
      }
      catch (Exception ex) 
      {
        throw ex;
      }
      return ret;
    }

    #endregion

	}
}
