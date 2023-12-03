namespace FarmGameNetCore.Module.ItemModule;

public class Size
{
   private Size(string value) { Value = value; }

   private string Value { get; }

   public static Size _1x1 => new("1x1");
   public static Size _1x2 => new("1x2");
   public static Size _2x2 => new("2x2");
   public static Size _1x3 => new("1x3");
   public static Size _2x3 => new("2x3");
   public static Size _3x3 => new("3x3");

   public override string ToString()
   {
      return Value;
   }
}