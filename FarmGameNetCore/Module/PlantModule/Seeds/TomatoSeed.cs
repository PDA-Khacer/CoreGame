using FarmGameNetCore.Module.PlantModule.VegetablePlants.Tomatoes;

namespace FarmGameNetCore.Module.PlantModule.Seeds;

public class TomatoSeed: Seed
{
    public TomatoSeed(string name) : base(name)
    {
        Name = "Tomato Seed";
    }

    public TomatoSeed(): base()
    {
        Name = "Tomato Seed";
    }

    public override Crop GetCrop()
    {
        return new TomatoDefaultCrop();
    }
}