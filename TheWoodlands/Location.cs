using System.Collections.Generic;

namespace TheWoodlands
{
  public class Location
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string SourceForLocationImage { get; set; }

    /// <summary>Stores current location user is at.</summary>
    public static int CurrentLocation { get; set; }

    /// <summary>Stores location items.</summary>
    public List<Items> Items = new List<Items>();

    /// <summary>Stores location NPC.</summary>
    public List<NPC> NPC = new List<NPC>();

    /// <summary>Stores image source for location map.</summary>
    public string SourceForLocationMap { get; set; }

  }
}
