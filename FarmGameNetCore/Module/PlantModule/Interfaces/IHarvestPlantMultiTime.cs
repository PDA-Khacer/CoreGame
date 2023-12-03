namespace FarmGameNetCore.Module.PlantModule.Interfaces;

public interface IHarvestPlantMultiTime<T>
{
    public abstract List<T> Harvest();
}