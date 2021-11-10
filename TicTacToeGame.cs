using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTaktoeProblem
{
    class TicTacToeGame
    {
        public char[] board = new char[10];
        int player, computer;
        char choice = Convert.ToChar(Console.ReadLine());
        public void charBoard()//method for Use Case 1.
        {
            
            int i;
            for(i=0;i<board.Length;i++)
            {
                board[i] = ' ';
            }
            if(choice!='X' && choice!='O')
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                if(choice=='X')
                {
                    player = 'X';
                    computer = 'O';
                }
                else
                {
                    player = 'O';
                    computer='X';
                }
            }
        }
    }
}
