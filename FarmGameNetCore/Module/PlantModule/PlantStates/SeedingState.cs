namespace FarmGameNetCore.Module.PlantModule.PlantStates;

public class SeedingState : PlantState, IPlantState
{
    public SeedingState(ulong time)
    {
        this.LimitProcess = time;
        this.Name = PlantStatus.Seeding.ToString();
    }
    
    public void NextState(Plant plant) 
    {
        Console.WriteLine("Plant is Seeding State.");
        // plant.MoveToNextState();
    }

    public ulong GetLimitProcessState()
    {
        return this.LimitProcess;
    }
}