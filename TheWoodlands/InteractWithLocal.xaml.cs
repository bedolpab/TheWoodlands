using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for InteractWithLocal.xaml
  /// </summary>
  public partial class InteractWithLocal : Page
  {
    public InteractWithLocal()
    {
      InitializeComponent();
      DisplayNPC();
      LoadPageContent();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Local";
    }

    /// <summary>
    /// Display current location's NPC.
    /// </summary>
    private void DisplayNPC()
    {
      // Iterate while "i" is less than length of locations list...
      for (int i = 0; i < MainWindow.game.Locations.Count; i++)
      {
        // If user's current location is equal to current iteration (i).
        // E.g iteration 0, or "i", will be MainWindow.game.Locations[0].
        if (Location.CurrentLocation == i)
        {
          // Iterate while "j" is less than length of current location NPC's list.
          // "i" being "Locations" list index.
          // "j" being "NPC" list index.
          for (int j = 0; j < MainWindow.game.Locations[i].NPC.Count; j++)
          {
            // Display content for NPC of current location.
            NPCName.Text = MainWindow.game.Locations[i].NPC[j].Name;
            NPCDialogue.Text = MainWindow.game.Locations[i].NPC[j].Dialogue;
            NPCItem.Source = new BitmapImage(new Uri(MainWindow.game.Locations[i].NPC[j].NPCItems[j].SourceForItemImage, UriKind.Relative));
            NPCSprite.Source = new BitmapImage(new Uri(MainWindow.game.Locations[i].NPC[j].SourceForNPCImage, UriKind.Relative));

          }
        }
      }
    }

    private void TakeItemBtn_Click(object sender, RoutedEventArgs e)
    {
      // Iterate while "i" is less than length of locations list...
      for (int i = 0; i < MainWindow.game.Locations.Count; i++)
      {
        // If user's current location is equal to current iteration (i).
        // E.g iteration 0, or "i", will be MainWindow.game.Locations[0].
        if (Location.CurrentLocation == i)
        {
          // Iterate while "j" is less than length of current location NPC's list.
          // "i" being "Locations" list index.
          // "j" being "NPC" list index.
          for (int j = 0; j < MainWindow.game.Locations[i].NPC.Count; j++)
          {
            // If user's inventory contains items from current location's NPC's items list.
            if (User.Inventory.Contains(MainWindow.game.Locations[i].NPC[j].NPCItems[j]))
            {
              Warning.Text = "You already have this item";
              Warning.Visibility = Visibility.Visible;
              return;
            }

            // If user's inventory contains required items from current location's NPC's required items list.
            if (User.Inventory.Contains(MainWindow.game.Locations[i].NPC[j].RequiredItems[j]))
            {
              // Add current location's NPC's items to user's inventory.
              User.Inventory.Add(MainWindow.game.Locations[i].NPC[j].NPCItems[j]);
              // Remove current location's NPC's required items from user's inventory.
              User.Inventory.Remove(MainWindow.game.Locations[i].NPC[j].RequiredItems[j]);

              // If current location's NPC's required items contains Items[7]
              if (MainWindow.game.Locations[i].NPC[j].RequiredItems.Contains(MainWindow.game.Items[7]))
              {
                User.Inventory.Add(MainWindow.game.Items[8]);
              }

              // Declared that user has traded with NPC
              NPC.UserHasTradeWithNPC = true;
              Warning.Text = "Supply has been traded";
              Warning.Visibility = Visibility.Visible;
            }

            // If user's inventory does not contain required items from current location's NPC's required items list.
            else if (!User.Inventory.Contains(MainWindow.game.Locations[i].NPC[j].RequiredItems[j]))
            {
              Warning.Text = "You do not have the tradeable item";
              Warning.Visibility = Visibility.Visible;
            }
          }
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
