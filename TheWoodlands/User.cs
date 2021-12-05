using System.Collections.Generic;

namespace TheWoodlands
{
  public class User : Character
  {
    public static new string Name { get; set; }

    /// <summary>Stores items user finds.</summary>
    public static List<Items> Inventory = new List<Items>();
  }
}
