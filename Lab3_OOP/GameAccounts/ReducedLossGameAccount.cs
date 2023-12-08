namespace Lab3_OOP.GameAccounts;

public class ReducedLossGameAccount : GameAccount
{
    public ReducedLossGameAccount(string name, decimal rating) : base(name, rating) { }

    /*protected override decimal CalculateLosePoints(decimal changeOfRating)
    {
        return changeOfRating / 2;
    }*/
}