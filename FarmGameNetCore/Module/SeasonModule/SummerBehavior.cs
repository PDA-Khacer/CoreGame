using FarmGameNetCore.Module.SeasonModule.Interfaces;

namespace FarmGameNetCore.Module.SeasonModule;

public class SummerBehavior: ISeasonBehavior
{
    public bool IsInSeason()
    {
        return Season.CurrentSeason == SeasonName.Summer;
    }
}