namespace Lab3_OOP.GameAccounts;

public class WinningStreakGameAccount : GameAccount
{
    //private int _consecutiveWins;
    public WinningStreakGameAccount(string name, decimal rating) : base(name, rating) { }

    /*protected override decimal CalculateWinPoints(decimal changeOfRating)
    {
        _consecutiveWins++;
        if (_consecutiveWins >= 3)
        {
            return changeOfRating + 100;
        }

        return changeOfRating;
    }

    protected override decimal CalculateLosePoints(decimal changeOfRating)
    {
        _consecutiveWins = 0;
        return changeOfRating;
    }*/
}