using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for GameHome.xaml
  /// </summary>
  public partial class GameHome : Page
  {
    public GameHome()
    {
      InitializeComponent();
      DisplayAvatarImage();
      GetUserName();
      LoadLocationContent();
      LoadTaskListContent();
    }

    /// <summary>
    /// Displays player avayar.
    /// </summary>
    public void DisplayAvatarImage()
    {
      SpriteImage.Source = Avatar.Source;
    }

    /// <summary>
    /// Gets user name and displays it on page.
    /// </summary>
    public void GetUserName()
    {
      UserName.Text = User.Name;
    }

    /// <summary>
    /// Load location content based on current location.
    /// </summary>
    public void LoadLocationContent()
    {
      // Iterate while "i" is less than length of locations list...
      for (int i = 0; i < MainWindow.game.Locations.Count; i++)
      {
        // If user's current location is equal to current iteration (i).
        // E.g iteration 0, or "i", will be MainWindow.game.Locations[0].
        if (Location.CurrentLocation == i)
        {
          // If user's inventory length is equal to total items of game, minus 1.
          // "-1" due to an item being a duplicate of another, but with different image.
          // Also taken as user has found all the game items.
          if (User.Inventory.Count == (MainWindow.game.Items.Count - 1))
          {
            TaskListTitle.Text = "Tasks Complete";
            TaskListTitle.Foreground = new SolidColorBrush(Color.FromRgb(17, 17, 17));
            TaskListRectangleBoxHead.Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
          }

          // If user's inventory length is equal to total items of game, minus 1 and
          // user's current location is 0 (also know as "Safehouse" in game).
          if (User.Inventory.Count == (MainWindow.game.Items.Count - 1) && (Location.CurrentLocation == 0))
          {
            // Load specific location content because all items have been found.
            LocationName.Text = MainWindow.game.Locations[i].Name;
            LocationDescription.Text = "You have collected everything need to survive the nuclear winter. You may rest now. You can still visit locations if you want, but there is no need to scavage for supplies.";
            LocationImage.Source = new BitmapImage(new Uri(MainWindow.game.Locations[i].SourceForLocationImage, UriKind.Relative));
          }
          else
          {
            // "i" will be location.
            GetLocationContent(i);
          }
        }
      }
    }

    /// <summary>
    /// Gets location content based on selected location.
    /// </summary>
    /// <param name="location">Selected location</param>
    private void GetLocationContent(int location)
    {
      LocationName.Text = MainWindow.game.Locations[location].Name;
      LocationDescription.Text = MainWindow.game.Locations[location].Description;
      LocationImage.Source = new BitmapImage(new Uri(MainWindow.game.Locations[location].SourceForLocationImage, UriKind.Relative));

      // If location contains items.
      if (MainWindow.game.Locations[location].Items.Any())
      {
        ViewItemsBtn.Visibility = Visibility.Visible;
      }

      // If location contains an NPC.
      if (MainWindow.game.Locations[location].NPC.Any())
      {
        ViewNPCBtn.Visibility = Visibility.Visible;
      }
    }

    private void LoadTaskListContent()
    {
      // Iterate while "i" is less than length of tasks array...
      for (int i = 0; i < MainWindow.game.Tasks.Length; i++)
      {
        // Find the name property "Task0, Task1..." accordingly to array length.
        TextBlock textBlock = FindName($"Task{i}") as TextBlock;

        // Set text block content to task.
        textBlock.Text = "-" + MainWindow.game.Tasks[i];
      }
    }

    // All right menu navigation click events.
    private void LocationBtn_Click(object sender, RoutedEventArgs e)
    {
      // Create a new Uri (For this case: Location page).
      // Set button to navigate to assigned URI (page).
      // NOTE: Same applies to all following menu navigation events.
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("Locations.xaml"));
    }

    private void InventoryBtn_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("Inventory.xaml"));
    }

    private void SettingsBtn_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("Settings.xaml"));
    }

    private void MapBtn_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("Map.xaml"));
    }

    private void ViewItemsBtn_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("LocationItems.xaml"));
    }

    private void ViewNPCBtn_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("InteractWithLocal.xaml"));
    }


  }
}
