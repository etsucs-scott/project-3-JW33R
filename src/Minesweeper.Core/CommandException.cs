using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    /// <summary>
    /// Used to throw exceptions when the user enters an invalid command
    /// </summary>
    public class CommandException : Exception
    {
        public CommandException(string message) : base(message)
        {
        }
        
    }
}
