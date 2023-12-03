using FarmGameNetCore.Module.PlantModule.Seeds;
using FarmGameNetCore.Module.PlantModule.Soil;

namespace FarmGameNetCore;

class TestRunner
{
    struct Position
    {
        public Position(ushort x, ushort y)
        {
            X = x;
            Y = y;
        }

        public ushort X;
        public ushort Y;
    }
    // Main Method 
    public static void Main()
    {
        TomatoSeed tomatoSeed = new TomatoSeed();

        Field<Position> field = new Field<Position>();
        field.AddSoil(new Position(1,1));
        Soil? soil = field.GetSoil(new Position(1, 1));
        if (soil is not null)
        {
            soil.Sow(tomatoSeed);
        }
        Console.WriteLine(field.GetSoil(new Position(1, 1))!.Crop!.PlantCanGrowInSeason());
    }
}