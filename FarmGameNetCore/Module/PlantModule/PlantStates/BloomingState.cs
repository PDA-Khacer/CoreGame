namespace FarmGameNetCore.Module.PlantModule.PlantStates;

public class BloomingState : PlantState, IPlantState
{
    public BloomingState(ulong time)
    {
        this.LimitProcess = time;
        this.Name = "Blooming";
    }
    
    public void NextState(Plant plant)
    {
        // plant.MoveToNextState();
        Console.WriteLine("Plant is ready harvest.");
    }
    
    public ulong GetLimitProcessState()
    {
        return this.LimitProcess;
    }
}