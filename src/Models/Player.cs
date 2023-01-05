namespace TicTacToe.Models;

public class Player
{
    // Name of the player
    private string name;

    // Symbol used by the player (e.g. X or O)
    private char symbol;

    // Game board
    private char[,] gameBoard;

    // Constructor to initialize the name and symbol
    public Player(string name, char symbol, char[,] gameBoard)
    {
        this.name = name;
        this.symbol = symbol;
        this.gameBoard = gameBoard;
    }

    // Method to receive a notification from the Game class
    public void ReceiveNotification()
    {
        Console.WriteLine($"It's {name}'s turn to make a move!");
        MakeMove();
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