using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for Settings.xaml
  /// </summary>
  public partial class Settings : Page
  {
    public Settings()
    {
      InitializeComponent();
      LoadPageContent();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Settings";
      ExitTxt.Text = "Exit Game";
      CustomizeTxt.Text = "Customize Avatar";
      RestartTxt.Text = "Restart Game";

    }

    private void ReturnBtn_Click(object sender, RoutedEventArgs e)
    {
      // Create a new Uri (For this case: GameHome page).
      // Set button to navigate to assigned URI (page).
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("GameHome.xaml"));
    }

    private void ExitBtn_Click(object sender, RoutedEventArgs e)
    {
      // If user choose "Yes" button.
      if (Utilities.YesOrNoMessageBox("Exit Game", "Are you sure you want to exit?") == DialogResult.Yes)
      {
        // End application.
        Environment.Exit(0);
      }
    }

    private void RestartBtn_Click(object sender, RoutedEventArgs e)
    {
      // If user choose "Yes" button.
      if (Utilities.YesOrNoMessageBox("Restart Game", "Are you sure you want to restart?") == DialogResult.Yes)
      {
        // Restart application and close previous window.
        System.Windows.Forms.Application.Restart();
        Environment.Exit(0);
      }
    }

    private void CustomizeBtn_Click(object sender, RoutedEventArgs e)
    {
      // Create a new Uri (For this case: AvatarCustomizeClothing page). Set
      // button to navigate to assigned URI (page).
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("AvatarCustomizeClothing.xaml"));
    }



  }
}
