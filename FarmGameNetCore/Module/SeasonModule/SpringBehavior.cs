using FarmGameNetCore.Module.SeasonModule.Interfaces;

namespace FarmGameNetCore.Module.SeasonModule;

public class SpringBehavior : ISeasonBehavior
{
    public bool IsInSeason()
    {
        return Season.CurrentSeason == SeasonName.Spring;
    }
}