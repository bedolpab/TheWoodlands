using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for Locations.xaml
  /// </summary>
  public partial class Locations : Page
  {

    public Locations()
    {
      InitializeComponent();
      LoadPageContent();
      DisplayLocationButtonContent();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Locations";
    }

    /// <summary>
    /// Displays content for location buttons.
    /// </summary>
    private void DisplayLocationButtonContent()
    {
      // Iterate while "i" is less than length of locations list...
      for (int i = 0; i < MainWindow.game.Locations.Count; i++)
      {
        // Find the name of the property "Location0, Location1..." accordingly to
        // location list length.
        TextBlock textBlock = FindName($"Location{i}") as TextBlock;

        // Set text block content to location name.
        textBlock.Text = MainWindow.game.Locations[i].Name;
      }
    }

    /// <summary>
    /// Converts button tag to int.
    /// </summary>
    /// <param name="buttonSender"></param>
    private void SetCurrentLocation(object buttonSender)
    {
      // Create button instance.
      Button button = (Button)buttonSender;

      // Convert button tag to integer.
      int convertTag = Convert.ToInt32(button.Tag);

      // Set the current location to tag(int).
      Location.CurrentLocation = convertTag;
    }

    /// <summary>
    /// Sends user to location and sets current location
    /// </summary>
    /// <param name="Uri"></param>
    /// <param name="buttonSender"></param>
    private void SendToLocation(string Uri, object buttonSender)
    {
      // Create a new Uri (For this case: GameHome page).
      // Set button to navigate to assigned URI (page).
      _ = NavigationService.Navigate(Utilities.GenerateNewUri($"{Uri}.xaml"));

      // Sets current location.
      SetCurrentLocation(buttonSender);
    }


    // All location button Click events
    private void ReturnBtn_Click(object sender, RoutedEventArgs e)
    {
      // Create a new Uri (For this case: GameHome page).
      // Set button to navigate to assigned URI (page).
      _ = NavigationService.Navigate(Utilities.GenerateNewUri($"GameHome.xaml"));
    }
    private void LocationBtn0_Click(object sender, RoutedEventArgs e)
    {
      SendToLocation("GameHome", sender);
    }
    private void LocationBtn1_Click(object sender, RoutedEventArgs e)
    {
      SendToLocation("GameHome", sender);
    }
    private void LocationBtn2_Click(object sender, RoutedEventArgs e)
    {
      SendToLocation("GameHome", sender);
    }
    private void LocationBtn3_Click(object sender, RoutedEventArgs e)
    {
      SendToLocation("GameHome", sender);
    }
    private void LocationBtn4_Click(object sender, RoutedEventArgs e)
    {
      SendToLocation("GameHome", sender);
    }

  }
}
