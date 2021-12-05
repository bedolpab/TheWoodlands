using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for Map.xaml
  /// </summary>
  public partial class Map : Page
  {
    public Map()
    {
      InitializeComponent();
      LoadPageContent();
      DisplayMap();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Map";
    }

    /// <summary>
    /// Displays current location's map.
    /// </summary>
    private void DisplayMap()
    {
      // Iterate while "i" is less than length of locations list...
      for (int i = 0; i < MainWindow.game.Locations.Count; i++)
      {
        // If user's current location is equal to current iteration (i).
        // E.g iteration 0, or "i", will be MainWindow.game.Locations[0].
        if (Location.CurrentLocation == i)
        {
          // Set map image source to image source of current location's map.
          MapImage.Source = new BitmapImage(new Uri(MainWindow.game.Locations[i].SourceForLocationMap, UriKind.Relative));
        }
      }
    }

    private void ReturnBtn_Click(object sender, RoutedEventArgs e)
    {
      // Create a new Uri (For this case: GameHome page). Set
      // button to navigate to assigned URI (page).
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("GameHome.xaml"));
    }
  }
}
