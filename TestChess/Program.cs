using System;

namespace TestChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Chess.Chess chess = new Chess.Chess();
            while (true)
            {
                Console.WriteLine(chess.Fen);
                string move = Console.ReadLine();
                if (move == "") break;
                chess = chess.Move(move);
            }
        }
    }
}
