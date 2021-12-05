using System.Collections.Generic;

namespace TheWoodlands
{
  public class NPC
  {
    public string Name { get; set; }

    /// <summary>Stores NPC dialogue.</summary>
    public string Dialogue { get; set; }

    /// <summary>Stores image source for NPC sprite.</summary>
    public string SourceForNPCImage { get; set; }

    /// <summary>Stores confirmation user has traded with NPC.</summary>
    public static bool? UserHasTradeWithNPC { get; set; }

    /// <summary>Stores NPC tradeable items.</summary>
    public List<Items> NPCItems = new List<Items>();

    /// <summary>Stores NPC required items in order to trade.</summary>
    public List<Items> RequiredItems = new List<Items>();
  }
}
