namespace FarmGameNetCore.Module.PlantModule.Interfaces;

public interface ICyclePlant
{
    protected abstract void Seeding();
    protected abstract void Sprouting();
    protected abstract void Flowing();
    protected abstract void Destroy();
    protected abstract void StopGrowing();
}