using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    public class FileHandling
    {
        public List<Seed> Seeds { get; private set; }

        public FileHandling() 
        {
            Seeds = new List<Seed>();
        }
        public void PutSeedsInFile()
        {
            string FileName = "Seeds.csv";
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
                foreach (var item in Seeds)
                {
                    File.WriteAllText(FileName, item.Name.ToString());
                }
                
            }
        }
    }
}
