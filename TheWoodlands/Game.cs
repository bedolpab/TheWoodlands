using System.Collections.Generic;

namespace TheWoodlands
{
  public class Game
  {
    // Stores all game locations.
    public List<Location> Locations { get; set; } = new List<Location>();

    // Stores sprite variations.
    public List<Avatar> Avatars { get; set; } = new List<Avatar>();

    // Stores collectable game items.
    public List<Items> Items { get; set; } = new List<Items>();

    // Stores location NPC's.
    public List<NPC> NPCs { get; set; } = new List<NPC>();

    // Task list tasks.
    public string[] Tasks = { "Gather aliments", "Find a gas mask", "Find a working radio", "Find winter clothing", "Find a first aid kit", "find weapons and ammunition" };


    public Game()
    {
      Avatar AvatarVariation1 = new Avatar()
      {
        SkinTone = "Fair",
        SkinToneIsChoosen = null,
        SourceForSkinToneImage = "Assets/Images/Avatars/AvatarOceanSA.png",
        SourcesForClothingColors = new[] {
          "Assets/Images/Avatars/AvatarOceanSA.png",
          "Assets/Images/Avatars/AvatarCloudySA.png",
          "Assets/Images/Avatars/AvatarPeachSA.png",
          "Assets/Images/Avatars/AvatarVanillaSA.png",
          "Assets/Images/Avatars/AvatarSunshineSA.png",
        }

      };
      Avatar AvatarVariation2 = new Avatar()
      {
        SkinTone = "Light",
        SkinToneIsChoosen = null,
        SourceForSkinToneImage = "Assets/Images/Avatars/AvatarOceanSB.png",
        SourcesForClothingColors = new[]
        {
           "Assets/Images/Avatars/AvatarOceanSB.png",
           "Assets/Images/Avatars/AvatarCloudySB.png",
           "Assets/Images/Avatars/AvatarPeachSB.png",
           "Assets/Images/Avatars/AvatarVanillaSB.png",
           "Assets/Images/Avatars/AvatarSunshineSB.png",
        }

      };
      Avatar AvatarVariation3 = new Avatar()
      {
        SkinTone = "Medium",
        SkinToneIsChoosen = null,
        SourceForSkinToneImage = "Assets/Images/Avatars/AvatarOceanSC.png",
        SourcesForClothingColors = new[]
        {
          "Assets/Images/Avatars/AvatarOceanSC.png",
          "Assets/Images/Avatars/AvatarCloudySC.png",
          "Assets/Images/Avatars/AvatarPeachSC.png",
          "Assets/Images/Avatars/AvatarVanillaSC.png",
           "Assets/Images/Avatars/AvatarSunshineSC.png",
        }

      };
      Avatar AvatarVariation4 = new Avatar()
      {
        SkinTone = "Tan",
        SkinToneIsChoosen = null,
        SourceForSkinToneImage = "Assets/Images/Avatars/AvatarOceanSD.png",
        SourcesForClothingColors = new[]
        {
          "Assets/Images/Avatars/AvatarOceanSD.png",
          "Assets/Images/Avatars/AvatarCloudySD.png",
          "Assets/Images/Avatars/AvatarPeachSD.png",
          "Assets/Images/Avatars/AvatarVanillaSD.png",
           "Assets/Images/Avatars/AvatarSunshineSD.png",
        }

      };
      Avatar DeepSkinTone = new Avatar()
      {
        SkinTone = "Deep",
        SkinToneIsChoosen = null,
        SourceForSkinToneImage = "Assets/Images/Avatars/AvatarOceanSE.png",
        SourcesForClothingColors = new[]
        {
           "Assets/Images/Avatars/AvatarOceanSE.png",
           "Assets/Images/Avatars/AvatarCloudySE.png",
           "Assets/Images/Avatars/AvatarPeachSE.png",
           "Assets/Images/Avatars/AvatarVanillaSE.png",
           "Assets/Images/Avatars/AvatarSunshineSE.png",
        }
      };

      Avatars.Add(AvatarVariation1);
      Avatars.Add(AvatarVariation2);
      Avatars.Add(AvatarVariation3);
      Avatars.Add(AvatarVariation4);
      Avatars.Add(DeepSkinTone);

      Items Ammunition = new Items()
      {
        Name = "Ammunition",
        SourceForItemImage = "Assets/Images/Items/Ammunition.png"
      };
      Items BattleRifle = new Items()
      {
        Name = "Battle Rifle",
        SourceForItemImage = "Assets/Images/Items/BattleRifle.png"
      };
      Items Coat = new Items()
      {
        Name = "Coat",
        SourceForItemImage = "Assets/Images/Items/Coat.png"
      };
      Items FirstAidKit = new Items()
      {
        Name = "First Aid Kit",
        SourceForItemImage = "Assets/Images/Items/FirstAidKit.png"
      };
      Items GasMask = new Items()
      {
        Name = "Gas Mask",
        SourceForItemImage = "Assets/Images/Items/GasMask.png"
      };
      Items MRE = new Items()
      {
        Name = "MRE",
        SourceForItemImage = "Assets/Images/Items/MRE.png"
      };
      Items Radio = new Items()
      {
        Name = "Radio",
        SourceForItemImage = "Assets/Images/Items/Radio.png"
      };
      Items WaterBottle = new Items()
      {
        Name = "Water Bottles",
        SourceForItemImage = "Assets/Images/Items/WaterBottleGroup.png"
      };
      Items HalfSupplyWaterBottle = new Items()
      {
        Name = "Water Bottle",
        SourceForItemImage = "Assets/Images/Items/WaterBottle.png"
      };

      Items.Add(Ammunition);
      Items.Add(BattleRifle);
      Items.Add(Coat);
      Items.Add(FirstAidKit);
      Items.Add(GasMask);
      Items.Add(MRE);
      Items.Add(Radio);
      Items.Add(WaterBottle);
      Items.Add(HalfSupplyWaterBottle);

      NPC creekNPC = new NPC()
      {
        Name = "Mason C.",
        Dialogue = "Hey! I found this radio down by the side of the creek. Looks like it works. I need some water though, I'm thirsty. Want to trade?",
        SourceForNPCImage = "Assets/Images/Avatars/AvatarMaleNPC.png",
        NPCItems = { Radio },
        RequiredItems = { WaterBottle }
      };

      NPCs.Add(creekNPC);

      Location Safehouse = new Location()
      {
        Name = "Safehouse",
        Description = "This is your home. You are safe here from any danger, however, you need items to survive the nuclear winter that is coming. Visit different locations to collect survival items.",
        SourceForLocationImage = "Assets/Images/Locations/Safehouse.png",
        SourceForLocationMap = "Assets/Images/Maps/SafehouseMap.png"
      };
      Location Railway = new Location()
      {
        Name = "Abandoned Train Station",
        Description = "This old train station was left for dead soon after the alert. Since it was used daily by the town citizens, it was well maintained. Trains would pass by daily and it was heavily trafficked. There was a nurse's office inside the station's office.",
        SourceForLocationImage = "Assets/Images/Locations/Railway.png",
        SourceForLocationMap = "Assets/Images/Maps/TrainStationMap.png",
        Items = { FirstAidKit }

      };
      Location GasStation = new Location()
      {
        Name = "Gas Station",
        Description = "Nothing says smalltown like a gas station with hunting coats, hotdogs, water, and an endless supply of beef jerky. Unfortunately, this was one of the few places looted after the alert, but you still might be able to find some remaining goods.",
        SourceForLocationImage = "Assets/Images/Locations/GasStation.png",
        SourceForLocationMap = "Assets/Images/Maps/GasStationMap.png",
        Items = { Coat, WaterBottle }
      };
      Location Factory = new Location()
      {
        Name = "Outdoor's Manufacturing Factory",
        Description = "This used to be a manufacturing factory for an outdoor’s company. They sold everything from hunting rifles, ammunition, camping gear, and even MREs! However, after the alert, the factory was abandoned. Nothing was taken, all goods were left behind.",
        SourceForLocationImage = "Assets/Images/Locations/Factory.png",
        SourceForLocationMap = "Assets/Images/Maps/FactoryMap.png",
        Items = { Ammunition, BattleRifle, MRE }
      };
      Location Creek = new Location()
      {
        Name = "Forest Creek",
        Description = "This small creek runs through the abandoned train station and behind your home. There isn’t much fish here, other than minnows, for you to hunt for. Nuclear winter won’t be here for a couple of days, so it’s a calm place to relax at.",
        SourceForLocationImage = "Assets/Images/Locations/Creek.png",
        SourceForLocationMap = "Assets/Images/Maps/CreekMap.png",
        Items = { GasMask },
        NPC = { creekNPC },
      };

      Locations.Add(Safehouse);
      Locations.Add(Railway);
      Locations.Add(GasStation);
      Locations.Add(Factory);
      Locations.Add(Creek);



    }
  }
}
