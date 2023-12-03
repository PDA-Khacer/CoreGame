using FarmGameNetCore.Module.PlantModule.Interfaces;

namespace FarmGameNetCore.Module.PlantModule.Seeds;

public class Seed: ISeedBehavior
{
    public string Name { get; set; }

    protected Seed(string name)
    {
        Name = name;
    }

    protected Seed()
    {
        Name = "";
    }

    public virtual Crop GetCrop()
    {
        throw new NotImplementedException();
    }
}