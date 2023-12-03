namespace FarmGameNetCore.Module.ItemModule.Ingredients.Fruits;

public class Fruit: Ingredient
{
    protected Fruit(float weight, float baseCost, Size sizeItem, ulong spoilTime) : base(weight, baseCost, sizeItem, spoilTime)
    {
        this.IngredientType = IngredientType.Fruit;
    }

    protected Fruit()
    {
        this.IngredientType = IngredientType.Fruit;
    }
}