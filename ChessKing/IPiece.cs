using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessKing
{
    enum TypeFigure
    {
        NONE,
        FIGURE
    }
    struct Cell
    {
        public Int32 X { get; set; }
        public Int32 Y { get; set; }

        public static bool operator==(Cell a, Cell b) => (a.X == b.X && a.Y == b.Y);
        public static bool operator !=(Cell a, Cell b) => !(a == b);
    }

    interface IPiece     //TCellInfo - необходимая инофрмации о состоянии данной ячейки
    {
        bool MoveTo(Int32 x, Int32 y);
        bool MoveTo(Cell cell);
        List<Cell> WhereToGo();        //Набор клеток, куда можно передвинуть фигуру

        bool Eat(ref Cell piece);
    }
}
