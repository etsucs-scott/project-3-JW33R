using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    public class FileHandling
    {
        public void SaveGame()
        {
            var fileName = "minesweeper_save.csv";
            var header = "size, seconds, moves, seed, timestamp";
            //File.WriteAllLines(fileName, header);

        }
    }
}
