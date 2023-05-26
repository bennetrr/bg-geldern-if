using System;
using System.Linq;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class Form1 : Form
    {
        private string nextPlayer = "X";

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, MouseEventArgs e)
        {
            var button = (Button) sender;
            
            button.Text = nextPlayer;
            button.Enabled = false;

            switch (nextPlayer)
            {
                case "X":
                    nextPlayer = "O";
                    break;
                case "O":
                    nextPlayer = "X";
                    break;
                default:
                    MessageBox.Show("Ein Fehler ist aufgetreten. Bitte das Spiel resetten.", "TicTacToe");
                    break;
            }

            label.Text = "Nächster Spieler: " + nextPlayer;

            var winPossibilities = new[]
            {
                new []{0, 1, 2},
                new []{3, 4, 5},
                new []{6, 7, 8},
                new []{0, 3, 6},
                new []{1, 4, 7},
                new []{2, 5, 8},
                new []{0, 4, 8},
                new []{2, 4, 6}
            };

            foreach (var x in winPossibilities)
            {
                
                if (ticTacToeButtons[x[0]].Text != "" && ticTacToeButtons[x[0]].Text == ticTacToeButtons[x[1]].Text && ticTacToeButtons[x[0]].Text == ticTacToeButtons[x[2]].Text)
                {
                    label.Text = ticTacToeButtons[x[0]].Text + " hat gewonnen!";
                    foreach (var btn in ticTacToeButtons)
                    {
                        btn.Enabled = false;
                    }
                }
            }

            var emptyButtons = ticTacToeButtons.Count(btn => btn.Text == "");
            if (emptyButtons == 0)
            {
                label.Text = "Unendschieden!";
                foreach (var btn in ticTacToeButtons)
                {
                    btn.Enabled = false;
                }
            }
        }

        private void ResetClicked(object sender, MouseEventArgs e)
        {
            foreach (var button in ticTacToeButtons)
            {
                button.Text = "";
                button.Enabled = true;
            }
            nextPlayer = "X";
            label.Text = "Nächster Spieler: " + nextPlayer;
        }
    }
}