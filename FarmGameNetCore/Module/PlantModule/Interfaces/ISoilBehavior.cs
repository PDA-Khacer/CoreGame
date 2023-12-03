using FarmGameNetCore.Module.PlantModule.Seeds;

namespace FarmGameNetCore.Module.PlantModule.Interfaces;

public interface ISoilBehavior
{
    public abstract void Sow(Seed seed);
    public abstract void Dig();
    public abstract void GiveWater(ulong amount);
    public abstract void GiveFertilizer(ulong amount);
    public abstract void GivePesticide(uint amount);
    public abstract void Weeding(uint amount);
    public abstract void IncreaseBug(uint amount);
    public abstract void IncreaseGrass(uint amount);
}