using System;
using System.Runtime.CompilerServices;

namespace Chess
{
    public class Chess
    {
        private string fen;
        public string Fen { get; private set; }

        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            this.fen = fen;
        }

        public Chess Move(string move)
        {
            Chess nextChessPos = new Chess(fen);
            return nextChessPos;
        }

        public char GetFigure(int x, int y)
        {
            return '.';
        }
    }
}
