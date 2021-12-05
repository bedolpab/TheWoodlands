using System;
using System.Windows;
using System.Windows.Forms;

namespace TheWoodlands
{
  public class Utilities
  {
    public static string URISource { get; set; }

    /// <summary>
    /// Creates new navigation URI for page passsed in.
    /// </summary>
    /// <param name="pageToNavigateTo">URI of page to navigate to</param>
    /// <returns></returns>
    public static Uri GenerateNewUri(string pageToNavigateTo)
    {
      // Set passed in page source to property.
      URISource = pageToNavigateTo;

      // Create a new relative URI with property containing page source.
      Uri NewUri = new Uri(URISource, UriKind.Relative);

      // Return new URI.
      return NewUri;
    }

    /// <summary>
    /// Creates a new "Yes" or "No" message box.
    /// </summary>
    /// <param name="title">Message box title.</param>
    /// <param name="message">Message box content.</param>
    /// <returns></returns>
    public static DialogResult YesOrNoMessageBox(string title, string message)
    {
      var messageBoxMessage = message;
      var messageBoxTitle = title;
      var buttons = MessageBoxButtons.YesNo;
      var messageBox = (DialogResult)System.Windows.MessageBox.Show(messageBoxMessage, messageBoxTitle, (MessageBoxButton)buttons);

      return messageBox;
    }

  }
}
