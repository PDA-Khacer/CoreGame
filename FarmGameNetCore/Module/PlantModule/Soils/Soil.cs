using FarmGameNetCore.Module.CommonModule;
using FarmGameNetCore.Module.PlantModule.Interfaces;

namespace FarmGameNetCore.Module.PlantModule.Soils;

public class Soil: ISoilBehavior
{
    public Soil()
    {
        Thread interval = new Thread(new ThreadStart(Interval));
        interval.Start();
    }
    
    public Crop? Crop { set; get; }
    
    private ulong AmountWater { get; set; }
    private ulong AmountFertilizer { get; set; }
    private ulong AmountPesticide { get; set; }
    private uint AmountBug { get; set; }
    private uint AmountGrass { get; set; }

    public void Sow(Seeds.Seed seed)
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
    
    // Interval runtime
    private void Interval()
    {
        while (GameController.Runing)
        {
            // Console.WriteLine("Soil Interval");
            // if have Crop check can grow ??
            if (Crop is not null && Crop.PlantCanGrowInSeason())
            {
                Console.WriteLine("[Soil Interval] {0} PlantCanGrowInSeason", Crop.Name);
                // Console.WriteLine("[Soil Interval] Plant Status is {0}", Crop.Status);
                // Start grow
                Crop.Growing();
                Console.WriteLine("[Soil Interval] Plant Time life is {0}", Crop.TimeLife);

                Thread.Sleep(1000);
            }
        }
    }
}