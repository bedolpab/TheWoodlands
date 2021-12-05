using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for LocationItems.xaml
  /// </summary>
  public partial class LocationItems : Page
  {
    public LocationItems()
    {
      InitializeComponent();
      LoadPageContent();
      DisplayLocationItems();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Location Items";
    }

    /// <summary>
    /// Displays items for location.
    /// </summary>
    private void DisplayLocationItems()
    {
      // Iterate while "i" is less than length of locations list...
      for (int i = 0; i < MainWindow.game.Locations.Count; i++)
      {
        // If user's current location is equal to current iteration (i).
        // E.g iteration 0, or "i", will be MainWindow.game.Locations[0].
        if (Location.CurrentLocation == i)
        {
          // Get the location items, "i" being the location.
          GetLocationItems(i);
        }
      }
    }

    /// <summary>
    /// Gets items for certain location.
    /// </summary>
    /// <param name="location">Current location</param>
    private void GetLocationItems(int location)
    {
      // Iterate while "i" is less than length of items list for location...
      for (int i = 0; i < MainWindow.game.Locations[location].Items.Count; i++)
      {
        // Find the name property "ItemBox0, ItemBox1..." accordingly to
        // items list for location length.
        Image image = FindName($"ItemBox{i}") as Image;

        // Set image source to image source of item(s) for current location.
        image.Source = new BitmapImage(new Uri(MainWindow.game.Locations[location].Items[i].SourceForItemImage, UriKind.Relative));


        // Find the name property "ItemBox0Name, ItemBox1Name..." accordingly to
        // items list for location length.
        TextBlock textBlock = FindName($"ItemBox{i}Name") as TextBlock;

        // Set text block content to name of item(s) for current location.
        textBlock.Text = MainWindow.game.Locations[location].Items[i].Name;
      }

    }

    /// <summary>
    /// Collects location items.
    /// </summary>
    private void CollectLocationItems()
    {
      // Iterate while "i" is less than length of locations list...
      for (int i = 0; i < MainWindow.game.Locations.Count; i++)
      {
        // If user's current location is equal to current iteration (i).
        // E.g iteration 0, or "i", will be MainWindow.game.Locations[0].
        if (Location.CurrentLocation == i)
        {
          // For every item in items list for current location...
          foreach (Items item in MainWindow.game.Locations[i].Items)
          {
            if (User.Inventory.Contains(item))
            {
              Warning.Text = "You already have the location items";
              Warning.Visibility = Visibility.Visible;
              return;
            }
            else
            {
              User.Inventory.Add(item);
              Warning.Text = "Item has been taken";
              Warning.Visibility = Visibility.Visible;
            }
          }
        }
      }
    }

    private void ReturnBtn_Click(object sender, RoutedEventArgs e)
    {
      // Create a new Uri (For this case: GameHome page).
      // Set button to navigate to assigned URI (page).
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("GameHome.xaml"));
    }

    private void CollectBtn_Click(object sender, RoutedEventArgs e)
    {
      CollectLocationItems();
    }
  }
}
