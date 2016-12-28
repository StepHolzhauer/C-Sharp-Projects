using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe2
{
    public partial class Form1 : Form
    {
        public enum Player { X, O }
        Player currentPlayer = Player.X;
        int playerScore1 = 0;
        int playerScore2 = 0;


        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }
        //Player X=0 Player O=1
        
        public void RestartGame()
        {
            lblNW.Text = "";
            lblN.Text = "";
            lblNE.Text = "";
            lblW.Text = "";
            lblC.Text = "";
            lblE.Text = "";
            lblSW.Text = "";
            lblS.Text = "";
            lblSE.Text = "";
            lblNW.Enabled = true;
            lblN.Enabled = true;
            lblNE.Enabled = true;
            lblW.Enabled = true;
            lblC.Enabled = true;
            lblE.Enabled = true;
            lblSW.Enabled = true;
            lblS.Enabled = true;
            lblSE.Enabled = true;
            currentPlayer = Player.X;
        }

        public void SwapPlayers()
        {
            if (currentPlayer == Player.X)
            {
                currentPlayer = Player.O;
                return;
            }
            else if (currentPlayer == Player.O)
            {
                currentPlayer = Player.X;
                return;
            }
            else return;
        }

        public bool HorizonalWins()
        {
            if (lblNW.Text == "X" && lblN.Text == "X" && lblNE.Text == "X" || lblW.Text == "X" && lblC.Text == "X" && lblE.Text == "X" || lblSW.Text == "X" && lblS.Text == "X" && lblSE.Text == "X")
            {
                playerScore1++;
                System.Windows.Forms.MessageBox.Show("X Won!");
                return true;
            }
            if (lblNW.Text == "O" && lblN.Text == "O" && lblNE.Text == "O" || lblW.Text == "O" && lblC.Text == "O" && lblE.Text == "O" || lblSW.Text == "O" && lblS.Text == "O" && lblSE.Text == "O")
            {
                playerScore2++;
                System.Windows.Forms.MessageBox.Show("O Won!");
                return true;
            }
            return false;
        }

        public bool VerticalWins()
        {
            if (lblNW.Text == "X" && lblW.Text == "X" && lblSW.Text == "X" || lblN.Text == "X" && lblC.Text == "X" && lblS.Text == "X" || lblNE.Text == "X" && lblE.Text == "X" && lblSE.Text == "X")
            {
                playerScore1++;
                System.Windows.Forms.MessageBox.Show("X Won!");
                return true;
            }
            if (lblNW.Text == "O" && lblW.Text == "O" && lblSW.Text == "O" || lblN.Text == "O" && lblC.Text == "O" && lblS.Text == "O" || lblNE.Text == "O" && lblE.Text == "O" && lblSE.Text == "O")
            {
                playerScore2++;
                System.Windows.Forms.MessageBox.Show("O Won!");
                return true;
            }
            return false;
        }

        public bool DiagonalWins()
        {
            if (lblNW.Text == "X" && lblC.Text == "X" && lblSE.Text == "X" || lblSW.Text == "X" && lblC.Text == "X" && lblNE.Text == "X")
            {
                playerScore1++;
                System.Windows.Forms.MessageBox.Show("X Won!");
                return true;
            }
            if (lblNW.Text == "O" && lblC.Text == "O" && lblSE.Text == "O" || lblSW.Text == "O" && lblC.Text == "O" && lblNE.Text == "O")
            {
                playerScore2++;
                System.Windows.Forms.MessageBox.Show("O Won!");
                return true;
            }
            return false;
        }

        public bool DrawCheck()
        {
            if (lblNW.Text != "" && lblN.Text != "" && lblNE.Text != "" && lblW.Text != "" && lblC.Text != "" && lblE.Text != "" && lblSW.Text != "" && lblS.Text != "" && lblE.Text != "")
            {
                System.Windows.Forms.MessageBox.Show("Draw!");
                return true;
            }
            return false;
        }

        public void CheckForWin()
        {
            if (HorizonalWins())
            {
                RestartGame();
            }
            if (VerticalWins())
            {
                RestartGame();
            }
            if (DiagonalWins())
            {
                RestartGame();
            }
            if (DrawCheck())
            {
                RestartGame();
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.Text = currentPlayer.ToString();
            SwapPlayers();
            label.Enabled = false;
            CheckForWin();
            lblPlayerScore1.Text = playerScore1.ToString();
            lblPlayerScore2.Text = playerScore2.ToString();


        }


    }
}
