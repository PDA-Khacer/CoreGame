using FarmGameNetCore.Module.PlantModule.Interfaces;
using FarmGameNetCore.Module.PlantModule.Seeds;

namespace FarmGameNetCore.Module.PlantModule.Soil;

public class Soil: ISoilBehavior
{
    public Crop? Crop { set; get; }
    
    private ulong AmountWater { get; set; }
    private ulong AmountFertilizer { get; set; }
    private ulong AmountPesticide { get; set; }
    private uint AmountBug { get; set; }
    private uint AmountGrass { get; set; }

    public void Sow(Seed seed)
    {
        this.Crop = seed.GetCrop();
    }

    public void Dig()
    {
        if (this.Crop is not null)
        {
            this.Crop = null;
        }
    }

    public void GiveWater(ulong amount)
    {
        this.AmountWater += amount;
    }

    public void GiveFertilizer(ulong amount)
    {
        this.AmountFertilizer += amount;
    }

    public void GivePesticide(uint amount)
    {
        this.AmountPesticide += amount;
    }

    public void Weeding(uint amount)
    {
        this.AmountGrass -= 0;
    }

    public void IncreaseBug(uint amount)
    {
        this.AmountBug += 0;    }

    public void IncreaseGrass(uint amount)
    {
        this.AmountGrass += 0;
    }
}