using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    /// <summary>
    /// Used to make the minesweeper maze
    /// </summary>
    public class Maze
    {
        public Cell Cell {  get; private set; }
        public Cell[,] MineSweeperMaze {  get; private set; }
        /// <summary>
        /// Used to get the size of the maze based on the users choice
        /// </summary>
        /// <param name="mazeSize"></param>
        /// <returns></returns>
        public int MazeSize(int mazeSize)
        {
            if (mazeSize == 1)
            {
                return 8;
            }
            else if (mazeSize == 2)
            {
                return 12;
            }
            else if (mazeSize == 3)
            {
                return 16;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Used to get the bomb amount based on mazesize
        /// </summary>
        /// <param name="mazeSize"></param>
        /// <returns></returns>
        public int BombAmount(int mazeSize)
        {
            if (mazeSize == 8)
            {
                return 10;
            }
            else if (mazeSize == 12)
            {
                return 25;
            }
            else if (mazeSize == 16)
            {
                return 40;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Used to generate the maze in the beginning of the game
        /// </summary>
        /// <param name="mazeSize"></param>
        /// <param name="seed"></param>
        public void GenerateMaze(int mazeSize, int seed)
        {
            MineSweeperMaze = new Cell[mazeSize, mazeSize];
            for (int i = 0; i < MineSweeperMaze.GetLength(0); i++)
            {
                for (int j = 0; j < MineSweeperMaze.GetLength(0); j++)
                {
                    MineSweeperMaze[i, j] = new Cell();
                }
                

            }
            PlaceMineInMaze(mazeSize, seed);
        }
        /// <summary>
        /// Used to place bombs in the game based on the seed and amount of bombs
        /// </summary>
        /// <param name="mazeSize"></param>
        /// <param name="seed"></param>
        public void PlaceMineInMaze(int mazeSize, int seed)
        {
            Random random = new(seed);
            for (int i = 0; i < BombAmount(mazeSize) + 2; i++)
            {
                var rowBomb = random.Next(0, MineSweeperMaze.GetLength(0));
                var colBomb = random.Next(0, MineSweeperMaze.GetLength(0));
                MineSweeperMaze[rowBomb, colBomb].PlaceMine();
            }
        }
        /// <summary>
        /// Used to place a flag in the maze
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PlaceFlag(int x, int y)
        {
            MineSweeperMaze[x, y].PlaceFlagged();
        }
        /// <summary>
        /// Used to place a mine in the maze
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PlaceMine(int x, int y)
        {
            MineSweeperMaze[x, y].PlaceMine();
        }
    }
}
