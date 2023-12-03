using FarmGameNetCore.Module.ItemModule.Ingredients.Vegetables;
using FarmGameNetCore.Module.PlantModule.Interfaces;

namespace FarmGameNetCore.Module.PlantModule.VegetablePlant;

public class VegetableCrop: Crop
{
    private List<Vegetable> _vegetable;
    
    protected VegetableCrop(): base()
    {
        this._vegetable = new List<Vegetable>();
    }

    public List<Vegetable> Vegetable
    {
        get => _vegetable;
        set => _vegetable = value ?? throw new ArgumentNullException(nameof(value));
    }
    
}