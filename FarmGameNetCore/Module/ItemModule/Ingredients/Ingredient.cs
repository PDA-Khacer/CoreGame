using FarmGameNetCore.Module.ItemModule.Interfaces;

namespace FarmGameNetCore.Module.ItemModule.Ingredients;

public class Ingredient: ItemConsumableSpoil
{
    public IngredientType? IngredientType { get; set; }
    
    protected Ingredient(float weight, float baseCost, Size sizeItem, ulong spoilTime) : base(weight, baseCost, sizeItem, spoilTime)
    {
    }

    protected Ingredient()
    {
        
    }
}