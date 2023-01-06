namespace TicTacToe.Models;

public class Player
{
    // Name of the player
    private string name;

    // Symbol used by the player (e.g. X or O)
    private char symbol;

    // Game board
    private char[,] gameBoard;

    public string CurrentState { get; private set; }

    // Constructor to initialize the name and symbol
    public Player(string name, char symbol, char[,] gameBoard)
    {
        this.name = name;
        this.symbol = symbol;
        this.gameBoard = gameBoard;
    }

    // Method to receive a notification from the Game class
    public void ReceiveNotification(string message = "")
    {
        if (message == "We have a winner!")
        {
            // Do nothing
        }
        else if (message == "The game is a draw!")
        {
            Console.WriteLine("Game over! It's a draw.");
        }
        else
        {
            Console.WriteLine(message);
            MakeMove();
        }
        
        CurrentState = message;
    }

    // Method to make a move on the game board
    public void MakeMove()
    {
        // Prompt the player for their move
        Console.WriteLine("Enter the row and column of your move (e.g. 1 2):");
        int row = Convert.ToInt32(Console.ReadLine()) - 1;
        int col = Convert.ToInt32(Console.ReadLine()) - 1;

        // Update the game board
        gameBoard[row, col] = symbol;
    }
}