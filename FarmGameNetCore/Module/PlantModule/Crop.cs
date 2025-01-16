using FarmGameNetCore.Module.PlantModule.PlantStates;

namespace FarmGameNetCore.Module.PlantModule;

public class Crop : Plant
{
    public float Temperature { get; set; }

    protected Crop(): base()
    {
        this.Temperature = 0;
    }

    protected Crop(List<IPlantState> stateChain) : base(stateChain)
    {
        this.Temperature = 0;
    }

    protected Crop(string name, ulong timeLife, PlantStatus status, float temperature) : base(name, timeLife)
    {
        this.Temperature = temperature;
    }
}