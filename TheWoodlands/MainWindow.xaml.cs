using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TheWoodlands
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public static Game game = new Game();

    public MainWindow()
    {
      InitializeComponent();
      SetApplicationIcon();
    }

    /// <summary>
    /// Sets window icon for application.
    /// </summary>
    private void SetApplicationIcon()
    {
      TheWoodlandsApplication.Icon = new BitmapImage(new Uri("Assets/Images/TheWoodlandsIcon.png", UriKind.Relative));

    }
    // Loads initial frame into MainGame grid.

    private void MainGameGrid_Loaded(object sender, RoutedEventArgs e)
    {
      // Load start screen as initial screen.
      _ = Frame.Navigate(new StartScreen());
    }
  }
}

