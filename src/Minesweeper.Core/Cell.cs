using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Core
{
    public class Cell
    {
        public bool HasMine { get; private set; }
        public bool IsRevealed { get; private set; }
        public bool IsFlagged { get; private set; }
        public int AdjacentMines { get; private set; }

        public override string ToString()
        {
            if (HasMine)
            {
                return "b";
            }
            else if (IsFlagged)
            {
                return "f";
            }
            else if (!IsRevealed)
            {
                return "#";
            }
            else if (AdjacentMines > 0)
            {
                return AdjacentMines.ToString();
            }
            else if (IsRevealed && !IsFlagged && !HasMine)
            {
                return ".";
            }
            return string.Empty;
        }
        public void PlaceMine()
        {
            if (!HasMine)
            {
                HasMine = true;
            }
        }
        public void PlaceFlagged()
        {
            if (!IsFlagged)
            {
                IsFlagged = true;
            }
        }
        public void MakeRevelead()
        {
            if (!IsRevealed || !HasMine)
            {
                IsRevealed = true;
            }
        }
        public void ChangeAdjacentMines()
        {
            AdjacentMines += 1;
        }
    }
    
}
