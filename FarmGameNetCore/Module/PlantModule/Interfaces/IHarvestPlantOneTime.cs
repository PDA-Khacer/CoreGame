namespace FarmGameNetCore.Module.PlantModule.Interfaces;

public interface IHarvestPlantOneTime<out T>
{
    public abstract T Harvest();
}