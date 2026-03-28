using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    public class Seed
    {
        public List<int> MinePlacement { get; private set; }
        public int Name { get; private set; }
        public Seed(int name) 
        {
            Name = name;
            MinePlacement = new List<int>();
        }
    }
}
