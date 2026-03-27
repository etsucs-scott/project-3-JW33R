using Minesweeper.Core;
Maze maze = new Maze();
var mazeSize = int.Parse(Console.ReadLine());
maze.GenerateMaze(maze.MazeSize(mazeSize));
Console.WriteLine("Hello, World!");
