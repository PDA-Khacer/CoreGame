namespace FarmGameNetCore.Module.PlantModule.PlantStates;

public interface IPlantState
{
    void NextState(Plant plant);  // Move to the next state
    
    ulong GetLimitProcessState();
}