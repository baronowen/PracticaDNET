using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticTacToeEngine;

namespace Practicum1
{
    public partial class Form1 : Form
    {
        TicTacToeEngine t = new TicTacToeEngine();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            Button ingedrukt = sender as Button; 

            if(t.ChooseCell(Int32.Parse(ingedrukt.Text)))
            {
                if (t.Status == TicTacToeEngine.GameStatus.PlayerOPlays)
                {
                    ingedrukt.Text = "X";
                } else if (t.Status == TicTacToeEngine.GameStatus.PlayerXPlays)
                {
                    ingedrukt.Text = "O";
                }
            }

            if (t.Status == TicTacToeEngine.GameStatus.PlayerOWins
                || t.Status == TicTacToeEngine.GameStatus.PlayerXWins)
            {
                MessageBox.Show(t.Status.ToString());
            } else if (t.Status == TicTacToeEngine.GameStatus.Equal)
            {
                MessageBox.Show("Er is geen winnaar.");
            }
        }
    }
}
