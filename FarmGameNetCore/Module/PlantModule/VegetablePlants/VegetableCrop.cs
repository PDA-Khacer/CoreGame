using FarmGameNetCore.Module.ItemModule.Ingredients.Vegetables;
using FarmGameNetCore.Module.PlantModule.PlantStates;

namespace FarmGameNetCore.Module.PlantModule.VegetablePlants;

public class VegetableCrop: Crop
{
    private List<Vegetable> _vegetable;
    
    protected VegetableCrop(): base()
    {
        this._vegetable = new List<Vegetable>();
    }

    protected VegetableCrop(List<IPlantState> stateChain) : base(stateChain)
    {
        this._vegetable = new List<Vegetable>();
    }

    public List<Vegetable> Vegetable
    {
        get => _vegetable;
        set => _vegetable = value ?? throw new ArgumentNullException(nameof(value));
    }
    
}