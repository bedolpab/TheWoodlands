using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for Information.xaml
  /// </summary>
  public partial class Information : Page
  {
    public Information()
    {
      InitializeComponent();
      LoadPageContent();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Information";
      GameImportantInformation.Text = "Locations, inventory, maps, and settings can be found on the left menu. Avatar can be re-customized by visiting the settings page. You can exit or restart the game by visiting the settings page. Items collected from various locations can be found in your inventory. ";
    }

    private void ContinueBtn_Click(object sender, RoutedEventArgs e)
    {
      // Create a new Uri (For this case: Character page).
      // Set button to navigate to assigned URI (page).
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("Character.xaml"));
    }
  }
}
