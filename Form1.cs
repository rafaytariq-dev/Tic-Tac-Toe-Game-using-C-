using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        
        public String[,] tictactoe = { { " ", " ", " " }, { " ", " ", " " }, {" ", " ", " "} };
        public String CurrentPlayer = "X";
        int scoreX = 0;
        int scoreY = 0;

        public bool playerStatus()
        {
            if (CurrentPlayer == "X")
            {
                return true;
            }
            else { return false; }
        }
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Beige;

            button1.Tag = "0,0";
            button2.Tag = "0,1";
            button3.Tag = "0,2";
            button4.Tag = "1,0";
            button5.Tag = "1,1";
            button6.Tag = "1,2";
            button7.Tag = "2,0";
            button8.Tag = "2,1";
            button9.Tag = "2,2";

            
            button1.Click += buttonclick;
            button2.Click += buttonclick;
            button3.Click += buttonclick;
            button4.Click += buttonclick;
            button5.Click += buttonclick;
            button6.Click += buttonclick;
            button7.Click += buttonclick;
            button8.Click += buttonclick;
            button9.Click += buttonclick;


            button1.BackColor = Color.Beige;
            button2.BackColor = Color.Beige;
            button3.BackColor = Color.Beige;
            button4.BackColor = Color.Beige;
            button5.BackColor = Color.Beige;
            button6.BackColor = Color.Beige;
            button7.BackColor = Color.Beige;
            button8.BackColor = Color.Beige;
            button9.BackColor = Color.Beige;

        }
        private void buttonclick(object sender, EventArgs e)
        {
            label2.Text = "Player " + CurrentPlayer + " turn! ";
            Button clickedButton = sender as Button;
            
            
            if (clickedButton != null && clickedButton.Text == "")
            {
                
                clickedButton.Text = CurrentPlayer; 

                
                int row = Convert.ToInt32(clickedButton.Tag.ToString().Split(',')[0]);
                int col = Convert.ToInt32(clickedButton.Tag.ToString().Split(',')[1]);

                tictactoe[row, col] = CurrentPlayer; 

                
                if (CheckWinner(CurrentPlayer))
                {
                    MessageBox.Show($"Player {CurrentPlayer} wins!");
                    ResetBoard();
                    return;
                }

                CurrentPlayer = (CurrentPlayer == "X") ? "O" : "X";
            }
            drawMatch(CurrentPlayer);
        }
        private bool CheckWinner(String player)
        {
            bool Playerwon=false;
            if (tictactoe[0, 0] == player && tictactoe[0, 1] == player && tictactoe[0, 2] == player)
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                Playerwon = true;
            }
            else if (tictactoe[1, 0] == player && tictactoe[1, 1] == player && tictactoe[1, 2] == player)
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                Playerwon = true;
            }
            else if (tictactoe[2, 0] == player && tictactoe[2, 1] == player && tictactoe[2, 2] == player)
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                Playerwon = true;
            }
            else if (tictactoe[0, 0] == player && tictactoe[1, 0] == player && tictactoe[2, 0] == player)
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                Playerwon = true;
            }
            else if (tictactoe[0, 1] == player && tictactoe[1, 1] == player && tictactoe[2, 1] == player)
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                Playerwon = true;
            }
            else if (tictactoe[0, 2] == player && tictactoe[1, 2] == player && tictactoe[2, 2] == player)
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                Playerwon = true;
            }
            else if (tictactoe[0, 0] == player && tictactoe[1, 1] == player && tictactoe[2, 2] == player)
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                Playerwon = true;
            }
            else if (tictactoe[0, 2] == player && tictactoe[1, 1] == player && tictactoe[2, 0] == player)
            {
                button7.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                Playerwon = true;
            }
            if (Playerwon==true)
            {
                ScoreCard(player);

                label4.Text = ($"X secured {scoreX} points");
                label5.Text = ($"O secured {scoreY} points");
                return true;
            }
            else { return false; }

        }
        private void ResetBoard()
        {
            for(int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    tictactoe[i,j] = " ";
                }
            }
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = Color.Beige;
            button2.BackColor = Color.Beige;
            button3.BackColor = Color.Beige;
            button4.BackColor = Color.Beige;
            button5.BackColor = Color.Beige;
            button6.BackColor = Color.Beige;
            button7.BackColor = Color.Beige;
            button8.BackColor = Color.Beige;
            button9.BackColor = Color.Beige;

            label2.Text = "";

        }

        private void ScoreCard(string player)
        {
            if(player == "X")
            {
                scoreX++;
            }
            else 
                scoreY++;
        }

        private void drawMatch(string player)
        {
            if (CheckWinner(player) == false && button1.Text != "" && button2.Text!="" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                MessageBox.Show("Match is a draw! Reset!");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }

        private void button9_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
    }
}
