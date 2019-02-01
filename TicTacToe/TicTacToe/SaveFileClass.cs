using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class SaveFileClass
    {
        private char[,] TTT;
        private char letter;
        private int plays;

        private string Name;
        private string Vs;
        private string Dif;
        private uint Wins;
        private uint Loses;
        private uint Ties;

        public SaveFileClass(string[] Data)
        {
            Name = Data[0];
            Vs = Data[1];
            Dif = Data[2];
            Wins = Convert.ToUInt32(Data[3]);
            Loses = Convert.ToUInt32(Data[4]);
            Ties = Convert.ToUInt32(Data[5]);
            TTT = new char[3, 3];
            letter = 'X';
            plays = 0;
        }

        public bool place(int row, int col)
        {
            if (TTT[row, col] == 'X' || TTT[row, col] == 'O')
            {
                return false;
            }
            else
            {
                TTT[row, col] = letter;
                plays++;
                if (letter == 'X')
                {
                    letter = 'O';
                }
                else
                {
                    letter = 'X';
                }
                return true;
            }
        }

        public bool AIplays()
        {
            return false;
        }

        public int WhoWins()
        {
            if (((TTT[0, 0] == 'X') && (TTT[1, 1] == 'X') && (TTT[2, 2] == 'X')) || ((TTT[2, 0] == 'X') && (TTT[1, 1] == 'X') && (TTT[0, 2] == 'X')) || ((TTT[0, 0] == 'X') && (TTT[0, 1] == 'X') && (TTT[0, 2] == 'X')) || ((TTT[1, 0] == 'X') && (TTT[1, 1] == 'X') && (TTT[1, 2] == 'X')) || ((TTT[2, 0] == 'X') && (TTT[2, 1] == 'X') && (TTT[2, 2] == 'X')) || ((TTT[0, 0] == 'X') && (TTT[1, 0] == 'X') && (TTT[2, 0] == 'X')) || ((TTT[0, 1] == 'X') && (TTT[1, 1] == 'X') && (TTT[2, 1] == 'X')) || ((TTT[0, 2] == 'X') && (TTT[1, 2] == 'X') && (TTT[2, 2] == 'X')))
            {
                Wins++;
                return 2;
            }
            else if (((TTT[0, 0] == 'O') && (TTT[1, 1] == 'O') && (TTT[2, 2] == 'O')) || ((TTT[2, 0] == 'O') && (TTT[1, 1] == 'O') && (TTT[0, 2] == 'O')) || ((TTT[0, 0] == 'O') && (TTT[0, 1] == 'O') && (TTT[0, 2] == 'O')) || ((TTT[1, 0] == 'O') && (TTT[1, 1] == 'O') && (TTT[1, 2] == 'O')) || ((TTT[2, 0] == 'O') && (TTT[2, 1] == 'O') && (TTT[2, 2] == 'O')) || ((TTT[0, 0] == 'O') && (TTT[1, 0] == 'O') && (TTT[2, 0] == 'O')) || ((TTT[0, 1] == 'O') && (TTT[1, 1] == 'O') && (TTT[2, 1] == 'O')) || ((TTT[0, 2] == 'O') && (TTT[1, 2] == 'O') && (TTT[2, 2] == 'O')))
            {
                Loses++;
                return 1;
            }
            else
            {
                return 0;
            }
        }
        /*
         * Gets the number of Ties
         */
        public uint getTies()
        {
            return Ties;
        }
        /*
         * Gets the number of Loses
         */
        public uint getLoses()
        {
            return Loses;
        }
        /*
         * Gets the number of Wins.
         */
        public uint getWins()
        {
            return Wins;
        }
        /*
         * Gets the number of Plays
         */
        public bool getPlays()
        {
            return plays == 9;
        }
        /*
         * Gets the current Letter
        */
        public char getLetter()
        {
            return letter;
        }
    }
}
