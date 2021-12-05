using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for Character.xaml
  /// </summary>
  ///
  public partial class Character : Page
  {
    /// <value>Stores confirmation that user has entered a name.</value>
    private bool HasEnteredName { get; set; }

    public Character()
    {
      InitializeComponent();
      LoadPageContent();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Character";
      NameInstructions.Text = "Enter your name and click continue to move on.";
      NameRules.Text = "Note: Username must be 1 - 15 characters long.";
      NameTxtTitle.Text = "Enter Your Name:";
    }

    private void ContinueBtn_Click(object sender, RoutedEventArgs e)
    {
      do
      {
        // If text box does not is not null nor contains white spaces only.
        if (!string.IsNullOrWhiteSpace(NameTxt.Text))
        {
          // Create a new Uri (For this case: Avatar Customize page).
          // Set button to navigate to assigned URI (page).
          _ = NavigationService.Navigate(Utilities.GenerateNewUri("AvatarCustomize.xaml"));

          // Set the user's name from textbox text.
          User.Name = NameTxt.Text;
          HasEnteredName = true;
          break;
        }

        // If text box is empty or contains white spaces only,
        // enable warning that notifies user to enter text inside textbox.
        else
        {
          NameWarning.Text = "Please enter a name";
          NameWarning.Visibility = Visibility.Visible;
          HasEnteredName = false;
        }

      } while (HasEnteredName);
    }
  }
}
