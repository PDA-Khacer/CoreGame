namespace FarmGameNetCore.Module.CommonModule;

public static class GameController
{
    public static bool Runing = true;

    public static void StopGame()
    {
        Runing = false;
    } 
}