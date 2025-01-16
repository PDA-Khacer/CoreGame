namespace FarmGameNetCore.Module.PlantModule.PlantStates;

public class SmallPlantState: PlantState, IPlantState
{
    public SmallPlantState(ulong time)
    {
        this.LimitProcess = time;
        this.Name = "SmallPlant";
    }
    
    public void NextState(Plant plant)
    {
        Console.WriteLine("Plant is Small State.");
        // plant.MoveToNextState();
    }
    
    public ulong GetLimitProcessState()
    {
        return this.LimitProcess;
    }
}