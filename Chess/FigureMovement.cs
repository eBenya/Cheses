using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class FigureMovement
    {
        public Figure Figure { get; private set; }
        public Square FromSquare { get; private set; }
        public Square ToSquare { get; private set; }
        public Figure Promotion { get; private set; }

        public FigureMovement(FigureOnSquare figureOnSquare, Square to, Figure prom = Figure.none)
        {
            Figure = figureOnSquare.Figure;
            FromSquare = figureOnSquare.Square;
            Promotion = prom;
            ToSquare = to;
        }
        public FigureMovement(string move)    //Пример ввода - pa2a4  pe7e8Q
        {
            Figure = (Figure)move[0];
            FromSquare = new Square(move.Substring(1, 2));
            ToSquare = new Square(move.Substring(3, 2));
            Promotion = (move.Length == 6) ? (Figure)move[5] : Figure.none;
        }

    }
}
