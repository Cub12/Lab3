using System.Text;
using Lab3_OOP.Entity;
using Lab3_OOP.Entity.GameEntities;
using Lab3_OOP.GameAccounts;
using Lab3_OOP.Repository;
using Lab3_OOP.Service;

namespace Lab3_OOP
{
    public abstract class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            DbContext dbContext = new DbContext();
            PlayerRepository playerRepository = new PlayerRepository(dbContext.Players);
            GameRepository gameRepository = new GameRepository(dbContext.Games);
            IGameService gameService = new GameService(playerRepository, gameRepository);
            
            PlayerEntity player1 = new PlayerEntity(new StandardGameAccount("Max", 466));
            PlayerEntity player2 = new PlayerEntity(new ReducedLossGameAccount("Fernando", 183));
            PlayerEntity player3 = new PlayerEntity(new WinningStreakGameAccount("Carlos", 171));

            gameService.CreateAccount(player1);
            gameService.CreateAccount(player2);
            gameService.CreateAccount(player3);

            GameEntity standardGame1 = new StandardGameEntity(25, player1.Id);
            gameService.CreateGame(standardGame1);

            GameEntity trainingGame1 = new TrainingGameEntity(player1.Id);
            gameService.CreateGame(trainingGame1);
            
            GameEntity randomGame1 = new RandomRatingGameEntity(player1.Id);
            gameService.CreateGame(randomGame1);

            GameEntity standardGame2 = new StandardGameEntity(15, player2.Id);
            gameService.CreateGame(standardGame2);
            
            GameEntity trainingGame2 = new TrainingGameEntity(player2.Id);
            gameService.CreateGame(trainingGame2);
            
            GameEntity  randomGame2 = new RandomRatingGameEntity(player2.Id);
            gameService.CreateGame(randomGame2);

            GameEntity standardGame3 = new StandardGameEntity(30, player3.Id);
            gameService.CreateGame(standardGame3);

            GameEntity trainingGame3 = new TrainingGameEntity(player3.Id);
            gameService.CreateGame(trainingGame3);
            
            GameEntity randomGame3 = new RandomRatingGameEntity(player3.Id);
            gameService.CreateGame(randomGame3);

            Console.WriteLine("Список гравців:");
            foreach (var player in gameService.ReadAccounts())
            {
                Console.WriteLine($"{player.Id}. {player.UserName} - Rating: {player.CurrentRating}");
            }

            PrintPlayerGamesInfo(gameService, player1);
            PrintPlayerGamesInfo(gameService, player2);
            PrintPlayerGamesInfo(gameService, player3);

            Console.WriteLine("\nСписок всіх ігор:");
            foreach (var game in gameService.ReadGames())
            {
                PrintGameInfo(gameService, game);
            }
        }
        
        private static void PrintPlayerGamesInfo(IGameService gameService, PlayerEntity player)
        {
            Console.WriteLine($"\nСписок ігор для {player.UserName}:");
            foreach (var game in gameService.ReadPlayerGamesByPlayerId(player.Id))
            {
                PrintGameInfo(gameService, game);
            }
        }
        
        private static void PrintGameInfo(IGameService gameService, GameEntity game)
        {
            var result = gameService.IsPlayerWinner(game.PlayerId, game.Id) ? "Win" : "Lose";
            Console.WriteLine($"Гра #{game.Id} - Result: {result}, Rating Change: {game.ChangeOfRating}, " +
                              $"New Rating: {gameService.GetPlayerRating(game.PlayerId)}, Game Type: " +
                              $"{gameService.GetGameTypeName(game)}");
        }
    }
}