using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessKing
{
    class Piece : IPiece
    {
        private Cell cell;

        public virtual bool MoveTo(Int32 x, Int32 y)
        {
            var cells = WhereToGo();
            if (cells.Count == 1 && cells[0] == this.cell)
            {
                cell.X = x; cell.Y = y;
                return true;
            }
            return false;
        }
        public virtual bool MoveTo(Cell cell)
        {
            var cells = WhereToGo();
            if (cells.Count == 1 && cells[0] == this.cell)
            {
                this.cell = cell;
                return true;
            }
            return false;
        }

        public virtual List<Cell> WhereToGo()
        {
            var cells = new List<Cell> { this.cell };
            return cells;
        }

        public bool Eat(ref Cell piece)
        {
            throw new NotImplementedException();
        }
    }
}
