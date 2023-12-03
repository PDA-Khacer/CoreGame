using FarmGameNetCore.Module.SeasonModule.Interfaces;

namespace FarmGameNetCore.Module.SeasonModule;

public enum SeasonName
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public static class Season
{
    public static SeasonName CurrentSeason = SeasonName.Spring;

    public static void NextSeason()
    {
        switch (CurrentSeason)
        {
            case SeasonName.Spring:
                CurrentSeason = SeasonName.Summer;
                break;
            case SeasonName.Summer:
                CurrentSeason = SeasonName.Autumn;
                break;
            case SeasonName.Autumn: 
                CurrentSeason = SeasonName.Winter;
                break;
            case SeasonName.Winter: 
                CurrentSeason = SeasonName.Spring;
                break;
        }
    }
}