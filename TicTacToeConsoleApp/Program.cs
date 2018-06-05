using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticTacToeEngine;

namespace TicTacToeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            TicTacToeEngine t = new TicTacToeEngine();
            Console.WriteLine(t.Board());
            for (; ; )
            {
                Console.WriteLine(t.Status);
                Console.WriteLine("Select the cell of your choosing:");

                int s = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("your input is {0}.", s);

                bool result = t.ChooseCell(s);
                if (t.Status == TicTacToeEngine.GameStatus.PlayerOWins)
                {
                    Console.WriteLine("Congrats, {0}", t.Status);
                    Console.WriteLine(t.Board());
                    break;
                }
                else if(t.Status == TicTacToeEngine.GameStatus.PlayerXWins)
                {
                    Console.WriteLine("Congrats, {0}", t.Status);
                    Console.WriteLine(t.Board());
                    break;
                }
                else if(t.Status == TicTacToeEngine.GameStatus.Equal)
                {
                    Console.WriteLine("Unfortunately no one won!");
                    Console.WriteLine(t.Board());
                    break;
                }
                else
                {
                    Console.WriteLine(t.Board());
                    continue;
                }
            }
            Console.WriteLine("Spel is afgelopen");
        }
    }
}
