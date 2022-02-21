using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public void StartGame()
        {
            char[] board = new char[10];
            for (int i = 1; i <= board.Length; i++)
            {
                board[i] = ' ';
            }
            foreach (char i in board)
            {
                Console.WriteLine(i);
            }


        }
        public void toss()
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == 0)
            {
                Console.WriteLine("Computer plays first");
                Console.WriteLine("(cmputer inputs 'x'");
            }
            if (value == 1)
            {

                Console.WriteLine("user play first");
                Console.WriteLine("( User inputs 'o'");

            }
        }
    }
}
