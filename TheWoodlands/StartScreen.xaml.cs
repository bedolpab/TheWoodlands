using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for StartScreen.xaml
  /// </summary>
  public partial class StartScreen : Page
  {
    public StartScreen()
    {
      InitializeComponent();
      LoadPageContent();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "The Woodlands";
      Subtitle.Text = "Nuclear Winter";
      Creators.Text = "Developed and Designed by Pablo Cesar Bedolla Ortiz";
    }

    private void StartBtn_Click(object sender, RoutedEventArgs e)
    {
      // Create a new Uri (For this case: Background page).
      // Set button to navigate to assigned URI (page).
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("Background.xaml"));
    }
  }
}
