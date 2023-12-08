using Lab3_OOP.GameAccounts;

namespace Lab3_OOP.Entity;

public class PlayerEntity
{
    public int Id { get; set; }
    public string UserName { get; }
    public decimal CurrentRating { get; set; }
    public GameAccount GameAccount { get; }
    //private int _consecutiveWins;
    
    public PlayerEntity(GameAccount gameAccount)
    {
        UserName = gameAccount.UserName;
        CurrentRating = gameAccount.CurrentRating;
        GameAccount = gameAccount;
    }
    
    /*public decimal CalculateWinPoints(decimal changeOfRating)
    {
        if (GameAccount is not WinningStreakGameAccount) return changeOfRating;
        
        _consecutiveWins++;
        if (_consecutiveWins >= 3)
        {
            return changeOfRating + 100;
        }
        
        return changeOfRating;
    }
    
    public decimal CalculateLosePoints(decimal changeOfRating)
    {
        switch (GameAccount)
        {
            case ReducedLossGameAccount:
                return changeOfRating / 2;
            
            case WinningStreakGameAccount:
                _consecutiveWins = 0;
                break;
        }

        return changeOfRating;
    }*/
}