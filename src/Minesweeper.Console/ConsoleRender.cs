using Minesweeper.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Cli
{
    public class ConsoleRender
    {
        public GameEngine GameEngine { get; private set; }
        public ConsoleRender()
        {
            GameEngine = new GameEngine();
        }
        public void PrintChoices()
        {
            Console.WriteLine("1.) 8x8");
            Console.WriteLine("2.) 12x12");
            Console.WriteLine("3.) 16x16");
        }
        public void AskForSeed()
        {
            Console.WriteLine("Enter a seed(Hit enter if you don't have one): ");
        }
        public void PrintMaze()
        {
            Console.Write("  ");
            for (int i = 0; i < GameEngine.Maze.MineSweeperMaze.GetLength(0); i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            for (int i = 0; i < GameEngine.Maze.MineSweeperMaze.GetLength(0); i++)
            {
                Console.Write($"{i} ");
                for (int j = 0; j < GameEngine.Maze.MineSweeperMaze.GetLength(0); j++)
                {
                    Console.Write($"{GameEngine.Maze.MineSweeperMaze[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public void PrintCommands()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("R row col");
            Console.WriteLine("F row col");
        }
    }
}
