using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RooBooks.Library
{
	/// <summary>
	/// Summary description for RooBooks_BL.
	/// </summary>
  public class Logger
  {

    #region Own declarations
    private Settings rSettings = new Settings();
    private System.Windows.Forms.Form parentForm;
    #endregion

    #region Properties
    private string logFile = "";
    public string LogFile
    {
      get 
      {
        return logFile;
      }
      set 
      {
        logFile = value;
      }
    }
    #endregion

    #region !
    /* ============================================================================
     * 
     * Constructor
     * 
     * 
     * ============================================================================
     */
    public Logger(System.Windows.Forms.Form pf)
    {
      this.parentForm = pf;
      this.LogFile = this.rSettings.getSetting("LogFile");
    }

    #endregion

    #region Loggers
    public void WriteToLog(string msg) 
    {
      try 
      {
        string log = "\n\n=============================\n\n";
        log += DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
        log += " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "\n";
        log += "[MESSAGE] = " + msg;
        FileStream stream = new FileStream(this.LogFile, FileMode.Append);
        stream.Write(Encoding.ASCII.GetBytes(log), 0, log.Length);
        stream.Close();
      }
      catch (Exception ex) 
      {
        MsgError(ex, 1);
      }
    }

    public void WriteToLog(Exception ex) 
    {
      try 
      {
        string log = "\n\n=============================\n\n";
        log += DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
        log += " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "\n";
        log += "[EXCEPTION MESSAGE] = " + ex.Message + "\n";
        log += "[EXCEPTION SOURCE] = " + ex.Source + "\n";
        log += "[EXCEPTION STACK TRACE] = " + ex.StackTrace + "\n";
        FileStream stream = new FileStream(this.LogFile, FileMode.Append);
        stream.Write(Encoding.ASCII.GetBytes(log), 0, log.Length);
        stream.Close();
      }
      catch (Exception exex) 
      {
        MsgError(exex, 1);
      }
    }
    #endregion

    #region Error handling
    private void MsgError(Exception ex, int errorLevel) 
    {
      string mbText = ((errorLevel == 1) ? ex.Message : ex.StackTrace);
      string mbCaption = "Error occured while writing to log file!";
      MessageBox.Show(this.parentForm, mbText, mbCaption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }
    #endregion

  }
}
