using System.Collections.Generic;
using System.Windows.Media;

namespace TheWoodlands
{
  public class Avatar
  {
    /// <value> Stores user's avatar image source </value>
    public static ImageSource Source { get; set; }

    public string SkinTone { get; set; }
    public bool? SkinToneIsChoosen { get; set; }
    public string SourceForSkinToneImage { get; set; }
    public string[] SourcesForClothingColors { get; set; }

    public static string[] ClothingColors = { "Ocean", "Cloudy", "Peach", "Vanilla", "Sunshine" };

    public Avatar()
    {
    }
  }
}
