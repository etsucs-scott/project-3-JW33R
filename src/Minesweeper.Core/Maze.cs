using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    public class Maze
    {
        public Cell Cell {  get; private set; }
        public Seed Seed { get; private set; }
        public Cell[,] MineSweeperMaze {  get; private set; }
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
        public void GenerateMaze(int mazeSize, Seed seed)
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
        public void PlaceMineInMaze(int mazeSize, Seed seed)
        {
            for (int i = 0; i < BombAmount(mazeSize); i++)
            {
                MineSweeperMaze[RandomNum(), RandomNum()].PlaceMine();
            }
        }
        public int RandomNum()
        {
            Random random = new Random();
            return random.Next(0, MineSweeperMaze.GetLength(0)); 
        }
        public void PlaceFlag(int x, int y)
        {
            MineSweeperMaze[x, y].PlaceFlagged();
        }
        public void PlaceMine(int x, int y)
        {
            MineSweeperMaze[x, y].PlaceMine();
        }
    }
}
