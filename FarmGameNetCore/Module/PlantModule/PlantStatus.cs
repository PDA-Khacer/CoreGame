namespace FarmGameNetCore.Module.PlantModule;

public class PlantStatus
{
   private PlantStatus(string value) { Value = value; }

   private string Value { get; }

   public static PlantStatus Seeding => new("Seeding");
   public static PlantStatus SmallPlant => new("Small Plant");
   public static PlantStatus AdultPlant => new("Adult Plant");
   public static PlantStatus Blooming => new("Blooming");
   public static PlantStatus ReadyHarvest => new("Ready Harvest");
   public static PlantStatus StopGrowing => new("Stop Growing");

   public override string ToString()
   {
      return Value;
   }
}