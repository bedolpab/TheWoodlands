using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for Inventory.xaml
  /// </summary>
  public partial class Inventory : Page
  {
    public Inventory()
    {
      InitializeComponent();
      LoadPageContent();
      DisplayInventoryItems();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Inventory";
    }

    /// <summary>
    /// Displays user inventory items.
    /// </summary>
    private void DisplayInventoryItems()
    {
      // Iterate while "i" is less than length of user inventory list...
      for (int i = 0; i < User.Inventory.Count; i++)
      {
        // Find the name property "Item0, Item1..." accordingly to
        // user inventory list length.
        Image image = FindName($"Item{i}") as Image;

        // Set image source to image source of user's item(s).
        image.Source = new BitmapImage(new Uri(User.Inventory[i].SourceForItemImage, UriKind.Relative));
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
