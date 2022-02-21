using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Welcome To TicTacToeBoard");
            TicTacToeGame game = new TicTacToeGame();
            game.StartGame();
            game.toss();
            Console.ReadLine();


        }
    }
}
