using TicTacToe.Models;

namespace Tests;

public class GameTest
{
    [Fact]
    public void TestNotifyPlayers()
    {
        Game game = new Game(new List<Player>(), new char[3,3]);
        Player player1 = new Player("Player 1", 'X', new char[3,3]);
        Player player2 = new Player("Player 2", 'O', new char[3,3]);

        // Add the players to the game
        game.AddPlayer(player1);
        game.AddPlayer(player2);

        // Notify the players
        game.NotifyPlayers();

        // Verify that the players received the notification
        Assert.Equal(player1.CurrentState, "It's Player 1's turn to make a move!");
        Assert.Equal(player2.CurrentState, "It's Player 2's turn to make a move!");
    }
}