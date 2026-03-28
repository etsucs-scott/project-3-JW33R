using System;
using System.Collections.Generic;
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
            int[] directionrows = { 0, 1, 0, -1 };
            int[] directioncols = { 1, 0, -1, 0 };
            seen[startrow, startcol] = true;
            q.Enqueue((startrow, startcol));
            while (q.Count > 0)
            {
                
                var (r, c) = q.Dequeue();
                cell = Maze.MineSweeperMaze[r, c];
                cell.MakeRevelead();
                
                for (int k = 0; k < 4; k++)
                {
                    int nextrow = r + directionrows[k];
                    int nextcol = c + directioncols[k];
                    
                    if (nextrow < 0 || nextrow >= rows || nextcol < 0 || nextcol >= cols || seen[nextrow, nextcol])
                    {
                        continue;
                    }
                    if (Maze.MineSweeperMaze[nextrow, nextcol].HasMine || Maze.MineSweeperMaze[nextrow, nextcol].AdjacentMines > 0)
                    {
                        cell.ChangeAdjacentMines();
                    }

                    seen[nextrow, nextcol] = true;
                    q.Enqueue((nextrow, nextcol));
                }
            }
        }
    }
    
}
