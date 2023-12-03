using FarmGameNetCore.Module.ItemModule.Interfaces;

namespace FarmGameNetCore.Module.ItemModule;

public class ItemConsumableSpoil: Item, IItemConsumableBehavior
{
    public ulong SpoilTime { get; set; }
    public bool Spoiling { get; set; }

    protected ItemConsumableSpoil(float weight, float baseCost, Size sizeItem, ulong spoilTime) : base(weight, baseCost, sizeItem)
    {
        SpoilTime = spoilTime;
        Spoiling = false;
    }

    protected ItemConsumableSpoil(): base()
    {
        SpoilTime = 0;
        Spoiling = false;
    }

    public void StartSpoiling()
    {
        this.Spoiling = true;
    }

    public void StopSpoiling()
    {
        this.Spoiling = false;
    }

    public bool CanConsumable()
    {
        return true;
    }
}