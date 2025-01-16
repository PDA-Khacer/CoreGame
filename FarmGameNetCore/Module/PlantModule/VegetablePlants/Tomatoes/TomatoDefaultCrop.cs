using FarmGameNetCore.Module.ItemModule.Ingredients.Vegetables;
using FarmGameNetCore.Module.PlantModule.Interfaces;
using FarmGameNetCore.Module.PlantModule.PlantStates;
using FarmGameNetCore.Module.SeasonModule;

namespace FarmGameNetCore.Module.PlantModule.VegetablePlants.Tomatoes;

public class TomatoDefaultCrop : VegetableCrop, IRackGrow, IHarvestPlantMultiTime<Vegetable>
{
    /*
     *  set up time grow for each step
     * Seeding 10s
     * SmallPlant 10s
     * AdultPlant 5s
     * Blooming 5s => can Harvest 3 time maybe future can random
     */
    public TomatoDefaultCrop(): base([
        new SeedingState(10),
        new SproutingState(10),
        new SmallPlantState(5),
        new AdultPlantState(5),
        new BloomingState(10)
    ])
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