using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for AvatarCustomize.xaml
  /// </summary>
  public partial class AvatarCustomize : Page
  {
    /// <value>Stores confirmation that at one radio button has been checked</value>
    private bool OneRadioButtonIsChecked;
    /// <value>Stores confirmation that a radio button was checked</value>
    private bool RadioButtonIsChecked;

    public AvatarCustomize()
    {
      InitializeComponent();
      LoadPageContent();
      DisplayRaidioButtonContent();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Avatar";
      RadioButtonsTitle.Text = "Skin Tone";

      // Default sprite image.
      SpriteImage.Source = new BitmapImage(new Uri("Assets/Images/Avatars/AvatarOceanSA.png", UriKind.Relative));
    }

    /// <summary>
    /// Loads content for sprite skin tone radio buttons.
    /// </summary>
    private void DisplayRaidioButtonContent()
    {
      // Iterate while "i" is less than length of sprite variations list...
      for (int i = 0; i < MainWindow.game.Avatars.Count; i++)
      {
        // Find the name property "SkinTone0, SkinTone1," accordingly to
        // sprite variaton list length.
        RadioButton radioButton = FindName($"SkinTone{i}") as RadioButton;

        // Set radio button content to sprite skin tone.
        radioButton.Content = MainWindow.game.Avatars[i].SkinTone;
      }
    }

    /// <summary>
    /// Creates new URI to load image, assigns it to image's source, and declares that skin tone as choosen one.
    /// </summary>
    /// <param name="skinTone">Sprite skin tone</param>
    private void DeclareSpriteSkinTone(int skinTone)
    {
      // Create new URI to load an image. Assign element "AvatarImage"'s
      // source to new URI. 
      SpriteImage.Source = new BitmapImage(new Uri(MainWindow.game.Avatars[skinTone].SourceForSkinToneImage, UriKind.Relative));
      Avatar.Source = SpriteImage.Source;

      // Declare the skin tone as choosen.
      MainWindow.game.Avatars[skinTone].SkinToneIsChoosen = true;
    }

    // All skin tone radio button Click events.
    private void SkinTone0_Checked(object sender, RoutedEventArgs e)
    {
      DeclareSpriteSkinTone(0);
    }
    private void SkinTone1_Checked(object sender, RoutedEventArgs e)
    {
      DeclareSpriteSkinTone(1);
    }
    private void SkinTone2_Checked(object sender, RoutedEventArgs e)
    {
      DeclareSpriteSkinTone(2);
    }
    private void SkinTone3_Checked(object sender, RoutedEventArgs e)
    {
      DeclareSpriteSkinTone(3);
    }
    private void SkinTone4_Checked(object sender, RoutedEventArgs e)
    {
      DeclareSpriteSkinTone(4);
    }

    private void ContinueBtn_Click(object sender, RoutedEventArgs e)
    {
      // Make sure that one radio button is checked before moving on.
      OneRadioButtonIsChecked = SkinTone0.IsChecked == true || SkinTone1.IsChecked == true || SkinTone2.IsChecked == true || SkinTone3.IsChecked == true || SkinTone4.IsChecked == true;
      do
      {
        // If at least one radio button is checked.
        if (OneRadioButtonIsChecked)
        {
          // Create a new Uri (For this case: AvatarCustomizeClothing page).
          // Set button to navigate to assigned URI (page).
          _ = NavigationService.Navigate(Utilities.GenerateNewUri("AvatarCustomizeClothing.xaml"));

          // Declare that a radio button is checked.
          RadioButtonIsChecked = true;
          break;
        }

        // If no radio button is checked.
        else if (!OneRadioButtonIsChecked)
        {
          WarningMessage.Text = "Please select a skin tone";
          WarningMessage.Visibility = Visibility.Visible;

          // Declare that no radio button is checked.
          RadioButtonIsChecked = false;
        }

      } while (RadioButtonIsChecked);
    }

  }
}
