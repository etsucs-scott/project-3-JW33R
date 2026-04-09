using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    /// <summary>
    /// Class used for making each spot in the maze
    /// </summary>
    public class Cell
    {
        public bool HasMine { get; private set; }
        public bool IsRevealed { get; private set; }
        public bool IsFlagged { get; private set; }
        public int AdjacentMines { get; private set; }
        /// <summary>
        /// Used to show the user what is in the cell
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (HasMine)
            {
                return "B";
            }
            if (IsFlagged)
            {
                return "f";
            }
            else if (!IsRevealed)
            {
                return "#";
            }
            else if (AdjacentMines > 0)
            {
                IsRevealed = true;
                return AdjacentMines.ToString();
            }
            else if (IsRevealed && !IsFlagged && !HasMine)
            {
                return ".";
            }
            return string.Empty;
        }
        /// <summary>
        /// Used to place a mine in the cell
        /// </summary>
        /// <returns></returns>
        public bool PlaceMine()
        {
            if (!HasMine && !IsRevealed)
            {
                HasMine = true;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Used to place a flag in the maze and prevent the user from placing a flag on a revealed cell or a cell that already has a flag
        /// </summary>
        public void PlaceFlagged()
        {
            if (!IsFlagged && !IsRevealed)
            {
                IsFlagged = true;
            }
        }
        /// <summary>
        /// Used to remove a flag from the maze
        /// </summary>
        public void UnFlagged()
        {
            if (IsFlagged)
            {
                IsFlagged = false;
            }
        }
        /// <summary>
        /// Used to make a cell revealed
        /// </summary>
        public void MakeRevelead()
        {
            if (!IsRevealed || !HasMine)
            {
                IsRevealed = true;
            }
        }
        /// <summary>
        /// Used to change the number of adjacent mines for a cell
        /// </summary>
        public void ChangeAdjacentMines()
        {
            AdjacentMines += 1;
        }
    }
    
}
