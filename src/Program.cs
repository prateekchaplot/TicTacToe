// Create a game and two players
using TicTacToe.Models;

var board = new char[3, 3];
Game game = new Game(new List<Player>(), board);
Player player1 = new Player("Player 1", 'X', board);
Player player2 = new Player("Player 2", 'O', board);

// Add the players to the game
game.AddPlayer(player1);
game.AddPlayer(player2);

// Start the game
while (!game.IsGameOver())
{
    // Notify the players
    game.NotifyPlayers();
}

// Display the result of the game
Console.WriteLine("Game Over!");
if (game.CheckForWinner())
{
    Console.WriteLine("We have a winner!");
}
else
{
    Console.WriteLine("It's a draw!");
}