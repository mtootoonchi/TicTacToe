using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeAI2
{
    class Tree
    {
        private Node topNode;
        private Node currentNode;

        public Tree()
        {
            topNode = new Node(true, new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } }, 9, null);
            currentNode = topNode;
        }

        public void updateCurrentNode(char[,] board)
        {
            List<Node> list = currentNode.getNodes();
            for (short i = 0; i < list.Count; i++)
            {
                bool temp = true;
                for (short j = 0; j < 3; j++) 
                {
                    for (short z = 0; z < 3; z++)
                    {
                        if (board[j, z] != list[i].getBoard()[j, z]) 
                        {
                            temp = false;
                        }
                    }
                }
                if(temp)
                {
                    currentNode = list[i];
                    i = (short)list.Count;
                }
            }
        }

        public Location getPlay()
        {
            currentNode = currentNode.minimax();
            return currentNode.getLocation();
        }
    }
}
