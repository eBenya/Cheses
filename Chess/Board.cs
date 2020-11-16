using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Board
    {
        public string Fen { get; private set; }
        Figure[,] figures;
        public Color CurrentColor { get; private set; }
        public int MoveCount { get; private set; }

        public Board(string fen)
        {
            Fen = fen;
            figures = new Figure[8, 8];
            Init();
        }

        private void Init()
        {
            SetFigureTo(new Square("a1"), Figure.wBishop);
            SetFigureTo(new Square("h3"), Figure.bBishop);
            CurrentColor = Color.white;
        }
        public Figure GetFigureFrom(Square square)
        {
            if (square.OnBoard())
                return figures[square.x, square.y];
            return Figure.none;
        }
        private void SetFigureTo(Square square, Figure figure)
        {
            if (square.OnBoard())
                figures[square.x, square.y] = figure;
        }
    }
}
