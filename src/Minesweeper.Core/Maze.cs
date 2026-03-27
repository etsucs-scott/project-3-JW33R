using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    public class Maze
    {
        public Bombs Bomb {  get; private set; }
        public Seed Seed { get; private set; }
        public Maze() 
        {
            
        }
        public int MazeSize(int mazeSize)
        {
            if (mazeSize == 1)
            {
                return 1;
            }
            else if (mazeSize == 2)
            {
                return 2;
            }
            else if (mazeSize == 3)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
        public void GenerateMaze(int mazeSize, Seed seed)
        {
            for (int i = 0; i < mazeSize; i++)
            {

            }
        }
    }
}
