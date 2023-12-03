using FarmGameNetCore.Module.PlantModule.Interfaces;
using FarmGameNetCore.Module.SeasonModule.Interfaces;

namespace FarmGameNetCore.Module.PlantModule;

public class Plant: ICyclePlant
{
    protected ISeasonBehavior? _iSeasonBehavior;
    public string Name { get; set; }

    public ulong TimeLife { get; set; }

    private PlantStatus _status;

    public PlantStatus Status
    {
        get => _status;
        set => _status = value ?? throw new ArgumentNullException(nameof(value));
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
    
    public virtual void Seeding()
    {

        this._status = PlantStatus.Seeding;
    }

    public virtual void Sprouting()
    {
        this._status = PlantStatus.SmallPlant;
    }

    public virtual void Flowing()
    {
        this._status = PlantStatus.Blooming;
    }

    public virtual void Destroy()
    {
    }

    public virtual void StopGrowing()
    {
        this._status = PlantStatus.StopGrowing;    
    }

    public bool PlantCanGrowInSeason()
    {
        return _iSeasonBehavior.IsInSeason();
    }
}