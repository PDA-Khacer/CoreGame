namespace FarmGameNetCore.Module.ItemModule.Ingredients;

public class IngredientType
{
    private IngredientType(string value) { Value = value; }

    private string Value { get; }

    public static IngredientType Fruit => new("Fruit");
    public static IngredientType Vegetable => new("Vegetable");

    public override string ToString()
    {
        return Value;
    }
}