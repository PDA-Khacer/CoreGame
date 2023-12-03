namespace FarmGameNetCore.Module.PlantModule;

public class Crop : Plant
{
    public float Temperature { get; set; }

    protected Crop(): base()
    {
        this.Temperature = 0;
    }

    protected Crop(string name, ulong timeLife, PlantStatus status, float temperature) : base(name, timeLife)
    {
        this.Temperature = temperature;
    }
}