namespace FarmGameNetCore.Module.ItemModule;

public class Item
{
    public string Name { get; set; }
    public bool Consumable { get; set; }
    public float Weight { get; set; }
    public float BaseCost { get; set; }
    public Size SizeItem { get; set; }

    protected Item(float weight, float baseCost, Size sizeItem)
    {
        Name = "";
        Weight = weight;
        BaseCost = baseCost;
        SizeItem = sizeItem;
    }

    protected Item()
    {
        Name = "";
        Weight = 0;
        BaseCost = 0;
        SizeItem = Size._1x1;
    }
    
    public void IncreaseWeight(float amount)
    {
        this.Weight += amount;
    }    
    
    public void IncreaseBaseCost(float amount)
    {
        this.BaseCost += amount;
    }

    public void DecreaseWeight(float amount)
    {
        this.Weight -= amount;
    }
    
    public void DecreaseBaseCost(float amount)
    {
        this.BaseCost -= amount;
    }
    
}