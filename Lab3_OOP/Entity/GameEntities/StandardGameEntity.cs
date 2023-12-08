namespace Lab3_OOP.Entity.GameEntities;

public class StandardGameEntity: GameEntity
{
    public StandardGameEntity(decimal changeOfRating, int playerId)
    {
        ChangeOfRating = changeOfRating;
        PlayerId = playerId;
    }
}