namespace Lab3_OOP.Entity.GameEntities;

public class GameEntity
{
    public int Id { get; set; }
    public decimal ChangeOfRating { get; protected init; }
    public int PlayerId { get; protected init; }
    
    /* public decimal CalculateRating()
    {
        return ChangeOfRating;
    } */
}