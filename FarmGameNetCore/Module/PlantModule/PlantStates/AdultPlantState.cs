namespace FarmGameNetCore.Module.PlantModule.PlantStates;

public class AdultPlantState: PlantState, IPlantState
{
    public AdultPlantState(ulong time)
    {
        this.LimitProcess = time;
        this.Name = "AdultPlant";
    }
    public void NextState(Plant plant)
    {
        Console.WriteLine("Plant is  Adult State.");
        // plant.MoveToNextState();
    }
    
    public ulong GetLimitProcessState()
    {
        return this.LimitProcess;
    }
}