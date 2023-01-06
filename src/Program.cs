// Create a game and two players
using TicTacToe.Models;

var board = new char[3, 3];

Player player1 = new Player("Player 1", 'X', board);
Player player2 = new Player("Player 2", 'O', board);

var players = new List<Player> { player1, player2 };
Game game = new Game(players, board);


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