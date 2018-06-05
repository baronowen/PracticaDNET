using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToeEngine
{
    public class TicTacToeEngine
    {
        public GameStatus Status { get; private set; }
        //private String plaatje = "";
        private int beurt = 0;

        List<int> ChosenCells = new List<int>();

        String[] waarden = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public enum GameStatus { PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins }

        public TicTacToeEngine()
        {
            Status = GameStatus.PlayerOPlays;
        }

        public string Board()
        {          
            return string.Format("-------------------\n" +
                                 "|  {0}  |  {1}  |  {2}  |\n" +
                                 "-------------------\n" +
                                 "|  {3}  |  {4}  |  {5}  |\n" +
                                 "-------------------\n" +
                                 "|  {6}  |  {7}  |  {8}  |\n" +
                                 "-------------------\n", 
                                 waarden[0], waarden[1], waarden[2],
                                 waarden[3], waarden[4], waarden[5],
                                 waarden[6], waarden[7], waarden[8]);
        }

        public bool ChooseCell(int cell)
        {
            if (!ChosenCells.Contains(cell))
            {
                beurt++;
                if (Status == GameStatus.PlayerOPlays)
                {
                    waarden[cell - 1] = "O";
                    ChosenCells.Add(cell);

                    Status = GameStatus.PlayerXPlays;

                } else if (Status == GameStatus.PlayerXPlays)
                {
                    waarden[cell - 1] = "X";
                    ChosenCells.Add(cell);

                    Status = GameStatus.PlayerOPlays;
                }

                if (!(BepaalWinnaar(waarden[0], waarden[1], waarden[2]) ||
                            BepaalWinnaar(waarden[3], waarden[4], waarden[5]) ||
                            BepaalWinnaar(waarden[6], waarden[7], waarden[8]) ||

                            BepaalWinnaar(waarden[0], waarden[4], waarden[8]) ||
                            BepaalWinnaar(waarden[6], waarden[4], waarden[2]) ||

                            BepaalWinnaar(waarden[0], waarden[3], waarden[6]) ||
                            BepaalWinnaar(waarden[1], waarden[4], waarden[7]) ||
                            BepaalWinnaar(waarden[2], waarden[4], waarden[8])) && beurt == 9)
                {
                    Status = GameStatus.Equal;
                }
                return true;

            }

            Console.WriteLine("Cell {0} has already been chosen." +
                    "Please try another one.", cell);
            return false;
        }

        public bool BepaalWinnaar(string a, string b, string c)
        {
            if(a == b && a == c )
            {
                if (Status == GameStatus.PlayerOPlays)
                {
                    Status = GameStatus.PlayerXWins;
                } else if(Status == GameStatus.PlayerXPlays)
                {
                    Status = GameStatus.PlayerOWins;
                }
                return true;
            }
            return false;
        }

        public void Reset()
        {
            String[] waarden = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        }
    }
}
