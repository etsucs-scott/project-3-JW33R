using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    public class FileHandling
    {
        public void SaveGame(int mazeSize, int seconds, int moves, int seed, string timestamp)
        {
            var fileName = "minesweeper_save.csv";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            string[] data = {$"size, seconds, moves, seed, timestamp", $"{mazeSize}, {seconds}, {moves}, {seed}, {timestamp}"};
            File.WriteAllLines(fileName, data);

        }
        public string[] LoadGame()
        {
            var fileName = "minesweeper_save.csv";
            if (File.Exists(fileName))
            {
                var data = File.ReadAllLines(fileName);
                var gameData = data[1].Split(",");
                return gameData;
            }
            else
            {
                return null;
            }
        }
    }
}
