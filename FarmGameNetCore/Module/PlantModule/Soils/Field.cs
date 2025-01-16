namespace FarmGameNetCore.Module.PlantModule.Soils;

public class Field<T> where T: struct 
{
    private readonly Dictionary<T, Soil> _soils;

    public Field()
    {
        this._soils = new Dictionary<T, Soil>();
    }

    public void AddSoil(T t)
    {
        _soils.Add(t, new Soil());
    }

    public Soil? GetSoil(T t)
    {
        return _soils!.GetValueOrDefault(t, null);
    }
}