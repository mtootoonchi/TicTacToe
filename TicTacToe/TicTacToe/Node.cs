using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAI2
{
    class Node
    {
        private bool player; // true is Player
        private List<Node> nodes = new List<Node>();
        private char[,] board;
        private short whowin; // 1 = Player, 0 = Tie/Undecided, -1 = Comp
        private Location placed;
        private short spacesLeft;

        public Node(bool player, char[,] board, short spacesLeft, Location placed)
        {
            this.player = player;
            this.board = board;
            this.placed = placed;
            this.spacesLeft = spacesLeft;
            WhoWins();
            if (player)
            {
                playerpicks();
            }
            else
            {
                comppicks();
            }
        }

        public Node minimax()
        {
            Random ran = new Random();
            List<Node> list = new List<Node>();
            short temp = 1;
            foreach(Node i in nodes)
            {
                if (temp > i.staticEvaluation()) 
                {
                    temp = i.staticEvaluation();
                }
            }
            foreach (Node i in nodes)
            {
                if (temp == i.staticEvaluation())
                {
                    list.Add(i);
                }
            }
            return list[ran.Next(0, list.Count)];
        }

        public short staticEvaluation()
        {
            if (whowin == 1 || whowin == -1 || spacesLeft == 0)
            {
                return whowin;
            }
            else
            {
                short temp = nodes[0].staticEvaluation();
                for (short i = 1; i < nodes.Count; i++)
                {
                    if (player && temp < nodes[i].staticEvaluation())
                    {
                        temp = nodes[i].staticEvaluation();
                    }
                    else if (!player && temp > nodes[i].staticEvaluation()) 
                    {
                        temp = nodes[i].staticEvaluation();
                    }
                }
                /*short temp = 0;
                if (player) 
                {
                    temp = 1;
                }
                else
                {
                    temp = -1;
                }
                foreach (Node i in nodes)
                {
                    temp = i.staticEvaluation();
                    break;
                }
                foreach (Node i in nodes)
                {
                    if (player && temp < i.staticEvaluation())
                    {
                        temp = i.staticEvaluation();
                    }
                    else if (!player && temp > i.staticEvaluation())
                    {
                        temp = i.staticEvaluation();
                    }
                }*/
                return temp;
            }
        }

        private void WhoWins()
        {
            if (((board[0, 0] == 'X') && (board[1, 1] == 'X') && (board[2, 2] == 'X')) || ((board[2, 0] == 'X') && (board[1, 1] == 'X') && (board[0, 2] == 'X')) || ((board[0, 0] == 'X') && (board[0, 1] == 'X') && (board[0, 2] == 'X')) || ((board[1, 0] == 'X') && (board[1, 1] == 'X') && (board[1, 2] == 'X')) || ((board[2, 0] == 'X') && (board[2, 1] == 'X') && (board[2, 2] == 'X')) || ((board[0, 0] == 'X') && (board[1, 0] == 'X') && (board[2, 0] == 'X')) || ((board[0, 1] == 'X') && (board[1, 1] == 'X') && (board[2, 1] == 'X')) || ((board[0, 2] == 'X') && (board[1, 2] == 'X') && (board[2, 2] == 'X')))
            {
                whowin = 1;
            }
            else if (((board[0, 0] == 'O') && (board[1, 1] == 'O') && (board[2, 2] == 'O')) || ((board[2, 0] == 'O') && (board[1, 1] == 'O') && (board[0, 2] == 'O')) || ((board[0, 0] == 'O') && (board[0, 1] == 'O') && (board[0, 2] == 'O')) || ((board[1, 0] == 'O') && (board[1, 1] == 'O') && (board[1, 2] == 'O')) || ((board[2, 0] == 'O') && (board[2, 1] == 'O') && (board[2, 2] == 'O')) || ((board[0, 0] == 'O') && (board[1, 0] == 'O') && (board[2, 0] == 'O')) || ((board[0, 1] == 'O') && (board[1, 1] == 'O') && (board[2, 1] == 'O')) || ((board[0, 2] == 'O') && (board[1, 2] == 'O') && (board[2, 2] == 'O')))
            {
                whowin = -1;
            }
            else
            {
                whowin = 0;
            }
        }

        private void playerpicks()
        {
            for (short i = 0; i < 3; i++)
            {
                for (short j = 0; j < 3; j++)
                {
                    if (!(board[i, j] == 'O' || board[i, j] == 'X') && whowin == 0) 
                    {
                        char[,] temp = copy();
                        temp[i, j] = 'X';
                        nodes.Add(new Node(!player, temp, (short)(spacesLeft - 1), new Location(i, j)));
                    }
                }
            }
        }

        private void comppicks()
        {
            for (short i = 0; i < 3; i++)
            {
                for (short j = 0; j < 3; j++)
                {
                    if (!(board[i, j] == 'O' || board[i, j] == 'X') && whowin == 0)
                    {
                        char[,] temp = copy();
                        temp[i, j] = 'O';
                        nodes.Add(new Node(!player, temp, (short)(spacesLeft - 1), new Location(i, j)));
                    }
                }
            }
        }

        private char[,] copy()
        {
            char[,] temp = new char[3, 3];
            for (short i = 0; i < 3; i++)
            {
                for (short j = 0; j < 3; j++)
                {
                    temp[i, j] = board[i, j];
                }
            }
            return temp;
        }

        public char[,] getBoard()
        {
            return board;
        }

        public List<Node> getNodes()
        {
            return nodes;
        }

        public Location getLocation()
        {
            return placed;
        }

        public short getWhoWin()
        {
            return whowin;
        }

        public short getSpacesLeft()
        {
            return spacesLeft;
        }

        public short getCount()
        {
            return (short)nodes.Count;
        }
    }
}
