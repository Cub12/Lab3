namespace Lab3_OOP.GameAccounts;

public abstract class GameAccount
{
    public string UserName { get; }
    public decimal CurrentRating { get; }

    protected GameAccount(string name, decimal rating)
    {
        if (rating < 1)
        {
            rating = 1;
        }

        UserName = name;
        CurrentRating = rating;
    }

    /*protected virtual decimal CalculateWinPoints(decimal changeOfRating)
    {
        return changeOfRating;
    }

    protected virtual decimal CalculateLosePoints(decimal changeOfRating)
    {
        return changeOfRating;
    }*/
}