using Minesweeper.Cli;
using Minesweeper.Core;
using System.Timers;
ConsoleRender consoleRender = new();
int score = 0;
int moves = 0;
consoleRender.PrintChoices();
var mazeSize = Console.ReadLine();
if (int.TryParse(mazeSize, out int mazeSizeInt) == false)
{
    Console.WriteLine("Only numbers are allowed");
    return;
}
if (!(mazeSizeInt >= 1 && mazeSizeInt <= 3))
{
    Console.WriteLine("Only numbers between 1 - 3 allowed");
    return;
}
consoleRender.AskForSeed();
var seedNum = Console.ReadLine();
if (int.TryParse(seedNum, out int seedNumInt) == false && !(seedNum == ""))
{
    Console.WriteLine("Only numbers are allowed");
    return;
}
if (seedNum == "")
{
    seedNumInt = DateTime.UtcNow.Ticks.GetHashCode();
}
consoleRender.GameEngine.Maze.GenerateMaze(consoleRender.GameEngine.Maze.MazeSize(mazeSizeInt), seedNumInt);
while (consoleRender.GameEngine.Lost == false || consoleRender.GameEngine.Won == false)
{
    Console.Clear();
    Console.WriteLine($"Time: {consoleRender.GameEngine.Score}  Moves: {consoleRender.GameEngine.Moves}  Seed: {seedNumInt}  HighScore: {consoleRender.GameEngine.HighScore}\n");
    consoleRender.PrintCommands();
    consoleRender.PrintMaze();
    Console.WriteLine("Type command");
    string command = "";
    try
    {
        command = Console.ReadLine();
        var splitCommand = command.Split(" ");
        if (string.IsNullOrEmpty(command))
        {
            throw new CommandException("Command cannot be null or empty");
        }
        if (int.Parse(splitCommand[1]) > consoleRender.GameEngine.Maze.MineSweeperMaze.GetLength(0) || int.Parse(splitCommand[1]) < 0 || int.Parse(splitCommand[2]) > consoleRender.GameEngine.Maze.MineSweeperMaze.GetLength(0) || int.Parse(splitCommand[2]) < 0)
        {
            throw new CommandException("Command coordinates are out of bounds");
        }
    }
    catch (CommandException)
    {
        Console.Clear();
        Console.WriteLine("Invalid command");
        Console.ReadLine();
        continue;
    }
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("Invalid command");
        Console.ReadLine();
        continue;
    }
    moves++;
    if (consoleRender.GameEngine.Score <= 0)
    {
        consoleRender.GameEngine.ScoreCounter(consoleRender.GameEngine.Lost);
    }
    Console.Clear();
    consoleRender.GameEngine.TakeInput(command);
    consoleRender.GameEngine.CheckWin(consoleRender.GameEngine.Maze.BombAmount(mazeSizeInt));
}
if (consoleRender.GameEngine.Lost == true)
{
    Console.WriteLine("You lost!");
}
else
{
    consoleRender.GameEngine.CalculateHighScore(moves, consoleRender.GameEngine.HighScore);
    consoleRender.GameEngine.FileHandling.SaveGame(mazeSizeInt, score, moves, seedNumInt, score);
}    

