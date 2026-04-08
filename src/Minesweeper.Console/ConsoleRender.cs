using Minesweeper.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Cli
{
    /// <summary>
    /// Class used for making functions that print to the console
    /// </summary>
    public class ConsoleRender
    {
        public GameEngine GameEngine { get; private set; }
        public ConsoleRender()
        {
            GameEngine = new GameEngine();
        }
        /// <summary>
        /// Prints the choices for the maze size to the console
        /// </summary>
        public void PrintChoices()
        {
            Console.WriteLine("1.) 8x8");
            Console.WriteLine("2.) 12x12");
            Console.WriteLine("3.) 16x16");
        }
        /// <summary>
        /// Asks the user for a seed
        /// </summary>
        public void AskForSeed()
        {
            Console.WriteLine("Enter a seed(Hit enter if you don't have one): ");
        }
        /// <summary>
        /// Prints the entire maze
        /// </summary>
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
        /// <summary>
        /// Prints the commands for the user to the console
        /// </summary>
        public void PrintCommands()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("R row col");
            Console.WriteLine("F row col");
        }
    }
}
