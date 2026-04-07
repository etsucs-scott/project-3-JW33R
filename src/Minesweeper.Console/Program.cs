using Minesweeper.Cli;
using Minesweeper.Core;
using System.Timers;
ConsoleRender consoleRender = new();
int score = 0;
int moves = 0;
consoleRender.PrintChoices();
var mazeSize = int.Parse(Console.ReadLine());
consoleRender.AskForSeed();
var seedNum = int.Parse(Console.ReadLine());
consoleRender.GameEngine.Maze.GenerateMaze(consoleRender.GameEngine.Maze.MazeSize(mazeSize), seedNum);
Console.Clear();
while (consoleRender.GameEngine.Lost == false)
{
    Console.WriteLine($"Time: {consoleRender.GameEngine.Score}  Moves: {consoleRender.GameEngine.Moves}  Seed: {seedNum}");
    consoleRender.PrintCommands();
    consoleRender.PrintMaze();
    Console.WriteLine("Type command");
    var command = Console.ReadLine();
    moves++;
    if (score <= 0)
    {
        consoleRender.GameEngine.ScoreCounter(score, consoleRender.GameEngine.Lost);
    }
    Console.Clear();
    consoleRender.GameEngine.TakeInput(command);
}
consoleRender.GameEngine.CalculateHighScore(score, moves, consoleRender.GameEngine.HighScore);
consoleRender.GameEngine.FileHandling.SaveGame(mazeSize, score, moves, seedNum, );

