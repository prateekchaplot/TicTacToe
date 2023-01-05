# Tic-Tac-Toe Game
This is a simple Tic-Tac-Toe game implemented using the .NET technology stack and the Observer design pattern.

## Prerequisites
- .NET Core 3.1 or higher

## Getting Started
1. Clone the repository: `git clone https://github.com/prateekchaplot/tictactoe.git`
1. Navigate to the project directory: `cd tictactoe`
1. Build the project: `dotnet build`
1. Run the program: `dotnet run`

## Description
The game allows two players to play Tic-Tac-Toe on a 3x3 game board. Players take turns making moves on the game board, with the goal of getting three of their symbols in a row (horizontally, vertically, or diagonally). The game ends when one player wins or the game board is full (a draw).

The game uses the Observer design pattern, with the Game class acting as the subject and the Player class acting as the observer. The Game class sends notifications to the Player class when it is their turn to make a move, and the Player class updates the game board and checks for a winner or a draw.

## Contributing
If you would like to contribute to the project, please fork the repository and submit a pull request with your changes.