namespace FarmGameNetCore.Module.PlantModule.PlantStates;

public class PlantState
{
    public string? Name { get; set; }
    // public required ulong CurrentProcess { get; set; } move to plant
    public ulong LimitProcess { get; set; }
}