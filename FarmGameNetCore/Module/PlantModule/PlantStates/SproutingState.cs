namespace FarmGameNetCore.Module.PlantModule.PlantStates;

public class SproutingState : PlantState, IPlantState
{
    public SproutingState(ulong time)
    {
        this.LimitProcess = time;
        this.Name = "Sprouting";
    }
    
    public void NextState(Plant plant)
    {
        Console.WriteLine("Plant is Sprouting State.");
        // plant.MoveToNextState();
    }
    
    public ulong GetLimitProcessState()
    {
        return this.LimitProcess;
    }
}