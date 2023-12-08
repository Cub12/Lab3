using Lab3_OOP.Entity;
using Lab3_OOP.Repository.IRepository;

namespace Lab3_OOP.Repository;

public class PlayerRepository: IPlayerRepository
{
    private readonly List<PlayerEntity> _players;

    public PlayerRepository(List<PlayerEntity> players)
    {
        _players = players;
    }

    public void CreatePlayer(PlayerEntity player)
    {
        player.Id = _players.Count + 1;
        _players.Add(player);
    }

    public PlayerEntity ReadPlayerById(int playerId)
    {
        return _players.FirstOrDefault(p => p.Id == playerId) ?? throw new InvalidOperationException();
    }

    public IEnumerable<PlayerEntity> ReadAllPlayers()
    {
        return _players;
    }
    
    public void CreateAccount(PlayerEntity player)
    {
        player.Id = _players.Count + 1;
        _players.Add(player);
    }

    public IEnumerable<PlayerEntity> ReadAccounts()
    {
        return _players;
    }
    
    public PlayerEntity ReadAccountById(int playerId)
    {
        return _players.FirstOrDefault(p => p.Id == playerId) ?? throw new InvalidOperationException();
    }
    
    public void UpdateRating(int playerId, decimal newRating)
    {
        var player = _players.FirstOrDefault(p => p.Id == playerId);
        if (player != null)
        {
            player.CurrentRating = newRating;
        }
    }
    
    /*public decimal CalculateWinPoints(int playerId, decimal changeOfRating)
    {
        var player = _players.FirstOrDefault(p => p.Id == playerId);
        return player?.CalculateWinPoints(changeOfRating) ?? 0;
    }

    public decimal CalculateLosePoints(int playerId, decimal changeOfRating)
    {
        var player = _players.FirstOrDefault(p => p.Id == playerId);
        return player?.CalculateLosePoints(changeOfRating) ?? 0;
    }*/
}