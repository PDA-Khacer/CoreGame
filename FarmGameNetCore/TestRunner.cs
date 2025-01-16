using FarmGameNetCore.Module.CommonModule;
using FarmGameNetCore.Module.PlantModule.Seeds;
using FarmGameNetCore.Module.PlantModule.Soils;

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
            
            // give some necessary 
            soil.GiveWater(100);
            soil.GiveFertilizer(100);
            soil.GivePesticide(100);
        }
        
        // Growing process......
        // check checking can grow
        Console.WriteLine(field.GetSoil(new Position(1, 1))!.Crop!.PlantCanGrowInSeason());
        
        // runtime
        uint time = 0;
        while (time < 100) // 100 sec
        {
            time++;
            Thread.Sleep(1000);
        }
        // end 
        GameController.StopGame();
    }
}