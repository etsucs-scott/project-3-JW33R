using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    /// <summary>
    /// Used for file in and out for the game
    /// </summary>
    public class FileHandling
    {
        /// <summary>
        /// Saves the game
        /// </summary>
        /// <param name="mazeSize"></param>
        /// <param name="seconds"></param>
        /// <param name="moves"></param>
        /// <param name="seed"></param>
        /// <param name="timestamp"></param>
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
        /// <summary>
        /// Loads the game
        /// </summary>
        /// <returns>The gamedata</returns>
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
