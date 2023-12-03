namespace FarmGameNetCore.Module.ItemModule.Ingredients.Vegetables.Tomatoes;

public class TomatoDefault: Vegetable
{
    public TomatoDefault(float weight, float baseCost, Size sizeItem, ulong spoilTime) : base(weight, baseCost, sizeItem, spoilTime)
    {
        this.Name = "Tomato";
    }
    
    public TomatoDefault() : base()
    {
        this.Name = "Tomato";
    }
}