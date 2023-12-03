using FarmGameNetCore.Module.ItemModule.Interfaces;

namespace FarmGameNetCore.Module.ItemModule.Ingredients.Vegetables;

public class Vegetable: Ingredient, IIngredientBehavior
{
    protected Vegetable(float weight, float baseCost, Size sizeItem, ulong spoilTime) : base(weight, baseCost, sizeItem, spoilTime)
    {
        this.IngredientType = IngredientType.Vegetable;
    }

    protected Vegetable() : base()
    {
        this.IngredientType = IngredientType.Vegetable;
    }

    public bool CanCook()
    {
        return true;
    }
}