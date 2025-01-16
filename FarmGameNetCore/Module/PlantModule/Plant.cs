using FarmGameNetCore.Module.PlantModule.Interfaces;
using FarmGameNetCore.Module.PlantModule.PlantStates;
using FarmGameNetCore.Module.SeasonModule.Interfaces;

namespace FarmGameNetCore.Module.PlantModule;

public class Plant: ICyclePlant
{
    // Define chain of state
    private List<IPlantState> _stateChain = new List<IPlantState>();
    private int _currentStateIndex = 0;
    private ulong _currentStateProcess = 0;
    
    public ulong GetCurrentStateProcess => _currentStateProcess;
    
    protected ISeasonBehavior? _iSeasonBehavior;
    public string Name { get; set; }
    public ulong TimeLife { get; set; }
    
    private PlantStatus _status;
    
    public PlantStatus Status
    {
        get => _status;
        set => _status = value;
    }
    protected Plant()
    {
        this._status = PlantStatus.Seeding;
        this.Name = "";
        this.TimeLife = 0;
    }
    
    protected Plant(string name, ulong timeLife)
    {
        this._status = PlantStatus.Seeding;
        this.Name = name;
        this.TimeLife = timeLife;
    }
    
    protected Plant(List<IPlantState> stateChain)
    {
        Console.WriteLine("Plant set chain");
        _stateChain = stateChain;
    }
    
    public bool PlantCanGrowInSeason()
    {
        return _iSeasonBehavior.IsInSeason();
    }
    
    public virtual void Growing()
    {
        // process grow here
        // check can growing ?
        this.TimeLife++;
        if (PlantCanGrowInSeason())
        {
            // check time
            this._currentStateProcess++;
            this.MoveToNextState();
        }
    }
    
    /*
     * Move to the next state in the state chain
     * Reset _currentStateProcess
     */
    public void MoveToNextState()
    {
        if (_currentStateIndex < _stateChain.Count && 
            _stateChain[_currentStateIndex].GetLimitProcessState() == _currentStateProcess) 
        {
            IPlantState currentState = _stateChain[_currentStateIndex++];
            currentState.NextState(this);
            ResetCurrentStateProcess();
        }
    }
    
    public void ResetCurrentStateProcess()
    {
        this._currentStateProcess = 0;
    }
}