using FarmGameNetCore.Module.ItemModule.Ingredients.Vegetables;
using FarmGameNetCore.Module.PlantModule.Interfaces;
using FarmGameNetCore.Module.SeasonModule;

namespace FarmGameNetCore.Module.PlantModule.VegetablePlant.Tomatoes;

public class TomatoDefaultCrop : VegetableCrop, IRackGrow, IHarvestPlantMultiTime<Vegetable>
{
    
    public TomatoDefaultCrop()
    {
        this.Name = "Tomato Crop";
        this._iSeasonBehavior = new SpringBehavior();
    }

    // Because one tomato plant have GreenTomato, RedTomato
    public List<Vegetable> Harvest()
    {
        return this.Vegetable;
    }
}