using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for Background.xaml
  /// </summary>
  public partial class Background : Page
  {
    public Background()
    {
      InitializeComponent();
      LoadPageContent();
    }

    private void LoadPageContent()
    {
      PageTitle.Text = "Background";
      GameSummary.Text = "After a series of events between powerful nations, war broke out. Weapons of mass destruction (WMD) were used, and many died. Luckily, your current location was not a target. Unfortunately, nuclear winter awaits, and you must prepare. Gather supplies to survive.";
    }

    private void ContinueBtn_Click(object sender, RoutedEventArgs e)
    {
      // Create a new Uri (For this case: Information page).
      // Set button to navigate to assigned URI (page).
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("Information.xaml"));

    }
  }
}
