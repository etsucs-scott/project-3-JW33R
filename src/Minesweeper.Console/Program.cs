using Minesweeper.Cli;
using Minesweeper.Core;
ConsoleRender consoleRender = new();
Maze maze = new Maze();
Seed seed;
GameEngine engine = new();
consoleRender.PrintChoices();
var mazeSize = int.Parse(Console.ReadLine());
consoleRender.AskForSeed();
var seedNum = int.Parse(Console.ReadLine());
seed = new(seedNum);
engine.Maze.GenerateMaze(maze.MazeSize(mazeSize), seed);
var command = Console.ReadLine();
var command1 = int.Parse(Console.ReadLine());
var command2 = int.Parse(Console.ReadLine());
engine.BFSGrid(engine.Maze.MineSweeperMaze, command1, command2);

for (int i = 0; i < engine.Maze.MineSweeperMaze.GetLength(0); i++)
{
    for (int j = 0; j < engine.Maze.MineSweeperMaze.GetLength(0); j++)
    {
        Console.Write($"{engine.Maze.MineSweeperMaze[i, j]}");
    }
    Console.WriteLine();
        
}
