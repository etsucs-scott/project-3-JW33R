using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    public class GameEngine
    {
        public int Score { get; private set; }
        public Maze Maze { get; private set; }
        public GameEngine()
        {
            Maze = new Maze();
        }
        public void BFSGrid(Cell[,] grid, int startrow, int startcol)
        {
            Cell cell = Maze.MineSweeperMaze[startrow, startcol];
            if (cell.HasMine)
            {
                Console.WriteLine("You lost");
                return;
            }
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            var seen = new bool[rows, cols];
            var q = new Queue<(int r, int c)>();
            int[] directionrows = { 0, 1, 0, -1, -1, -1, 1, 1};
            int[] directioncols = { 1, 0, -1, 0, -1, 1, 1, -1};
            seen[startrow, startcol] = true;
            q.Enqueue((startrow, startcol));
            var neighborCells = new List<(int r, int c)>();
            while (q.Count > 0)
            {
                neighborCells.Clear();
                var (r, c) = q.Dequeue();
                cell = Maze.MineSweeperMaze[r, c];
                cell.MakeRevelead();
                if (cell.AdjacentMines > 0)
                {
                    continue;
                }
                for (int k = 0; k < 8; k++)
                {
                    int nextrow = r + directionrows[k];
                    int nextcol = c + directioncols[k];
                    if (nextrow < 0 || nextrow >= rows || nextcol < 0 || nextcol >= cols)
                    {
                        continue;
                    }
                    if (Maze.MineSweeperMaze[nextrow, nextcol].HasMine)
                    {
                        cell.ChangeAdjacentMines();
                        continue;
                    }
                    if (seen[nextrow, nextcol])
                    {
                        continue;
                    }
                    neighborCells.Add((nextrow, nextcol));
                    seen[nextrow, nextcol] = true;
                }
                for (int i = 0; i < neighborCells.Count; i++)
                {
                    if (cell.AdjacentMines == 0)
                    {
                        q.Enqueue(neighborCells[i]);
                    }
                    else if (cell.AdjacentMines > 0)
                    {
                        break;
                    }
                }     
            }
        }
    }
    
}
