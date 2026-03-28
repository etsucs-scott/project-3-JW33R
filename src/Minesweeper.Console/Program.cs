using Minesweeper.Cli;
using Minesweeper.Core;
ConsoleRender consoleRender = new();
Maze maze = new Maze();
Seed seed;
consoleRender.PrintChoices();
var mazeSize = int.Parse(Console.ReadLine());
consoleRender.AskForSeed();
var seedNum = int.Parse(Console.ReadLine());
seed = new(seedNum);
maze.GenerateMaze(maze.MazeSize(mazeSize), seed);
for (int i = 0; i < maze.MineSweeperMaze.GetLength(0); i++)
{
    for (int j = 0; j < maze.MineSweeperMaze.GetLength(0); j++)
    {
        Console.Write($"{maze.MineSweeperMaze[i, j]}");
    }
    Console.WriteLine();
        
}
