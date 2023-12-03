namespace FarmGameNetCore.Module.ItemModule.Ingredients.Fruits.Apples;

public class AppleDefault: Fruit
{
    public AppleDefault(float weight, float baseCost, Size sizeItem, ulong spoilTime) : base(weight, baseCost, sizeItem, spoilTime)
    {
        this.Name = "Apple";
    }

    public AppleDefault()
    {
        this.Name = "Apple";
    }
}