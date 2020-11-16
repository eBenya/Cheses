using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessKing
{
    struct ChessDesk<TCellInfo>     //TCellInfo - необходимая инофрмации о состоянии данной ячейки
    {
        private int DeskWidht;
        private int DeskHeight;
        private TCellInfo[,] chessDesk;
    
        
        public TCellInfo GetCellInFo(int i, int j) => chessDesk[i, j];
        public TCellInfo this[int i, int j]     //Переопределил [,]
        {
            get
            {
                if (i >= DeskWidht && i < 0 ||
                    j >= DeskHeight && j < 0 ||
                    chessDesk == null)
                {
                    throw new ArgumentOutOfRangeException("There was an attempt to go beyond the array");
                }
                else
                {
                    return chessDesk[i, j];
                }
            }
            set
            {
                if (i >= DeskWidht && i < 0 ||
                    j >= DeskHeight && j < 0 ||
                    chessDesk == null)
                {
                    throw new ArgumentOutOfRangeException("There was an attempt to go beyond the array");
                }
                else
                {
                    chessDesk[i, j] = value;
                }
            }
        }
    }
}
