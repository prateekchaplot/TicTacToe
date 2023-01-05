namespace TicTacToe.Models;

public class Game
{
    // List of players
    private List<Player> players;

    // Current player
    private Player currentPlayer;

    // Game board
    private char[,] gameBoard;

    // Constructor to initialize the players and game board
    public Game(List<Player> players, char[,] gameBoard)
    {
        this.players = players;
        this.gameBoard = gameBoard;

        // Initialize the game board with empty spaces
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                gameBoard[i, j] = ' ';
            }
        }

        // Print the game board to the console
        Console.WriteLine("Initial game board:");
        PrintGameBoard();
    }

    // Method to print the game board to the console
    public void PrintGameBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" " + gameBoard[i, j] + " ");

                if (j != 2) Console.Write('|');
            }

            Console.WriteLine();

            for (int j = 0; i != 2 && j < 3; j++)
            {
                Console.Write("----");
            }

            Console.WriteLine();
        }
    }

    // Method to add a player to the list
    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    // Method to remove a player from the list
    public void RemovePlayer(Player player)
    {
        players.Remove(player);
    }

    // Method to notify the players when it's their turn to make a move
    public void NotifyPlayers()
    {
        foreach (Player player in players)
        {
            player.ReceiveNotification();
            PrintGameBoard();
        }
    }

    // Method to check if the game is over (e.g. if there is a winner or a draw)
    public bool IsGameOver()
    {
        // Check for a winner
        if (CheckForWinner())
        {
            return true;
        }

        // Check for a draw
        if (CheckForDraw())
        {
            return true;
        }

        return false;
    }

    // Private method to check for a winner
    public bool CheckForWinner()
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (gameBoard[i, 0] != ' ' && gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2])
            {
                return true;
            }
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (gameBoard[0, i] != ' ' && gameBoard[0, i] == gameBoard[1, i] && gameBoard[1, i] == gameBoard[2, i])
            {
                return true;
            }
        }

        // Check diagonals
        if (gameBoard[0, 0] != ' ' && gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
        {
            return true;
        }

        if (gameBoard[2, 0] != ' ' && gameBoard[2, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[0, 2])
        {
            return true;
        }

        return false;
    }

    // Private method to check for a draw
    private bool CheckForDraw()
    {
        // Check if all the spaces on the game board are filled
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (gameBoard[i, j] == ' ')
                {
                    return false;
                }
            }
        }

        return true;
    }
}