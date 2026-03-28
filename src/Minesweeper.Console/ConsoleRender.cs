using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Cli
{
    public class ConsoleRender
    {
        public ConsoleRender() 
        { 
        
        }
        public void PrintChoices()
        {
            Console.WriteLine("1.) 8x8");
            Console.WriteLine("2.) 12x12");
            Console.WriteLine("3.) 16x16");
        }
        public void AskForSeed()
        {
            Console.WriteLine("Enter a seed(Hit enter if you don't have one): ");
        }
    }
}
