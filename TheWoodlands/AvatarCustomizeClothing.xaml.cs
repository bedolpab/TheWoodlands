using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for AvatarCustomizeClothing.xaml
  /// </summary>
  public partial class AvatarCustomizeClothing : Page
  {

    /// <value>Stores confirmation that at one radio button has been checked</value>
    private bool OneRadioButtonIsChecked;
    /// <value>Stores confirmation that a radio button was checked</value>
    private bool RadioButtonIsChecked;

    public AvatarCustomizeClothing()
    {
      InitializeComponent();
      LoadPageContent();
      ShowChoosenSkinTone();
      DisplayRadioButtonContent();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Customize";
      RadioButtonsTitle.Text = "Clothing";
    }

    /// <summary>
    /// Displays choosen skin tone image.
    /// </summary>
    public void ShowChoosenSkinTone()
    {
      SpriteImage.Source = Avatar.Source;
    }

    /// <summary>
    /// Loads content for sprite clothing color radio buttons.
    /// </summary>
    private void DisplayRadioButtonContent()
    {
      // Iterate while "i" is less than length of sprite clothing colors array...
      for (int i = 0; i < Avatar.ClothingColors.Length; i++)
      {
        // Find the name property "ClothingColor0, ClothingColor1," accordingly to
        // sprite clothing colors array length.
        RadioButton radioButton = FindName($"ClothingColor{i}") as RadioButton;

        // Set radio button content to sprite clothing color.
        radioButton.Content = Avatar.ClothingColors[i];
      }
    }


    /// <summary>
    /// Sets clothing color according to sprite skin tone selected.
    /// </summary>
    /// <param name="skinTone">Sprite skin tone</param>
    /// <param name="clothingColor">Sprite clothing color</param>
    private void DeclareSpriteClothingColor(int skinTone, int clothingColor)
    {
      // Set sprite image source according to skin tone and clothing color.
      SpriteImage.Source = new BitmapImage(new Uri(MainWindow.game.Avatars[skinTone].SourcesForClothingColors[clothingColor], UriKind.Relative));

      // Set player's avatar source to sprite source.
      Avatar.Source = SpriteImage.Source;
    }

    /// <summary>
    /// Applies and declares sprite clothing color based off sprite skin tone.
    /// </summary>
    /// <param name="clothingColor">Sprite clothing color</param>
    private void ApplySpriteClothingColor(int clothingColor)
    {
      // Iterate while "i" is less than length of sprite variations list...
      for (int i = 0; i < MainWindow.game.Avatars.Count; i++)
      {
        // Identify selected skin tone variation (i).
        if (MainWindow.game.Avatars[i].SkinToneIsChoosen == true)
        {
          // Based of selected skin tone (i), declare sprite clothing color (clothingColor).
          DeclareSpriteClothingColor(i, clothingColor);
          break;
        }
      }
    }

    

    // All clothing color radio button click events.
    private void ClothingColor0_Checked(object sender, RoutedEventArgs e)
    {
      ApplySpriteClothingColor(0);
    }
    private void ClothingColor1_Checked(object sender, RoutedEventArgs e)
    {
      ApplySpriteClothingColor(1);
    }
    private void ClothingColor2_Checked(object sender, RoutedEventArgs e)
    {
      ApplySpriteClothingColor(2);
    }
    private void ClothingColor3_Checked(object sender, RoutedEventArgs e)
    {
      ApplySpriteClothingColor(3);
    }
    private void ClothingColor4_Checked(object sender, RoutedEventArgs e)
    {
      ApplySpriteClothingColor(4);
    }


    private void ContinueBtn_Click(object sender, RoutedEventArgs e)
    {
      // Make sure that at one radio button is checked before moving on.
      OneRadioButtonIsChecked = ClothingColor0.IsChecked == true || ClothingColor1.IsChecked == true || ClothingColor2.IsChecked == true || ClothingColor3.IsChecked == true || ClothingColor4.IsChecked == true;
      do
      {
        // If at least one radio button is checked.
        if (OneRadioButtonIsChecked)
        {

          // Create a new Uri (For this case: GameHome page).
          // Set button to navigate to assigned URI (page).
          _ = NavigationService.Navigate(Utilities.GenerateNewUri("GameHome.xaml"));

          // Declare that a radio button is checked.
          RadioButtonIsChecked = true;
          break;
        }

        // If no radio button is checked.
        else
        {
          WarningMessage.Text = "Please select a clothing color";
          WarningMessage.Visibility = Visibility.Visible;

          // Declare that no radio button is checked.
          RadioButtonIsChecked = false;
        }
      } while (RadioButtonIsChecked);

    }
  }
}

