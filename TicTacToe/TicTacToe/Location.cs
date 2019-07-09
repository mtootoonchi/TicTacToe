using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAI2
{
    class Location
    {
        private short row;
        private short col;

        public Location(short row, short col)
        {
            this.row = row;
            this.col = col;
        }

        public short getRow()
        {
            return row;
        }

        public short getCol()
        {
            return col;
        }
    }
}
