using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true; // jeśli true to runda dla X, gdy false to O turn
        bool against_computer = false;
        int turnCount = 0; //licznik rund
        //static string player1, player2;

        public IEnumerable<Component> Components { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        /*
        public static void setPlayerName(string n1, string n2)
        {
            player1 = n1;
            player2 = n2;
        }*/

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By me", "Tic Tac Toe about");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((P1.Text == "Player 1") || (P2.Text == "Player 2"))
            {
                MessageBox.Show("You must write the players' names to start the game!\n Type Computer in 'Player2' to play with computer.\n Good Luck!");
            }
            else
            {
                Button b = (Button)sender;
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";

                turn = !turn;
                b.Enabled = false;
                turnCount++;

                checkForWinner();
            }

            // check if playing against computer and its O's turn
            if ((!turn) && (against_computer))
            {
                computer_make_move();
            }

        }

        private void computer_make_move()
        {
            Button move = null;

            move = Look_for_win_or_block("O");
                if (move == null)
            {
                move = Look_for_win_or_block("X");
                if (move == null)
                {
                    move = Look_for_corner();
                    if (move == null)
                    {
                        move = Look_for_open_block();
                    }
                }
            }

            move.PerformClick();
        }

        private Button Look_for_open_block()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }

            return null;
        }

        private Button Look_for_corner()
        {
            Console.WriteLine("Looking for corner");

            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (A7.Text == "")
                    return A7;
                if (A9.Text == "")
                    return A9;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (A7.Text == "")
                    return A7;
                if (A9.Text == "")
                    return A9;
            }

            if (A7.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (A9.Text == "")
                    return A9;
            }

            if (A9.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (A3.Text == "")
                    return A3;
                if (A7.Text == "")
                    return A7;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (A7.Text == "")
                return A7;
            if (A9.Text == "")
                return A9;

            return null;

        }

        private Button Look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //horizontal
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;

            if ((A4.Text == mark) && (A5.Text == mark) && (A6.Text == ""))
                return A6;
            if ((A4.Text == mark) && (A6.Text == mark) && (A5.Text == ""))
                return A5;
            if ((A5.Text == mark) && (A6.Text == mark) && (A4.Text == ""))
                return A4;

            if ((A7.Text == mark) && (A8.Text == mark) && (A9.Text == ""))
                return A9;
            if ((A7.Text == mark) && (A9.Text == mark) && (A8.Text == ""))
                return A8;
            if ((A8.Text == mark) && (A8.Text == mark) && (A7.Text == ""))
                return A7;

            //vertical
            if ((A1.Text == mark) && (A4.Text == mark) && (A7.Text == ""))
                return A7;
            if ((A1.Text == mark) && (A7.Text == mark) && (A4.Text == ""))
                return A4;
            if ((A4.Text == mark) && (A7.Text == mark) && (A1.Text == ""))
                return A1;

            if ((A2.Text == mark) && (A5.Text == mark) && (A8.Text == ""))
                return A8;
            if ((A2.Text == mark) && (A8.Text == mark) && (A5.Text == ""))
                return A5;
            if ((A5.Text == mark) && (A8.Text == mark) && (A2.Text == ""))
                return A2;

            if ((A3.Text == mark) && (A6.Text == mark) && (A9.Text == ""))
                return A9;
            if ((A3.Text == mark) && (A9.Text == mark) && (A6.Text == ""))
                return A6;
            if ((A6.Text == mark) && (A9.Text == mark) && (A3.Text == ""))
                return A3;

            //cross
            if ((A1.Text == mark) && (A5.Text == mark) && (A9.Text == ""))
                return A9;
            if ((A1.Text == mark) && (A9.Text == mark) && (A5.Text == ""))
                return A5;
            if ((A5.Text == mark) && (A9.Text == mark) && (A1.Text == ""))
                return A1;

            if ((A3.Text == mark) && (A5.Text == mark) && (A7.Text == ""))
                return A7;
            if ((A3.Text == mark) && (A7.Text == mark) && (A5.Text == ""))
                return A5;
            if ((A5.Text == mark) && (A7.Text == mark) && (A3.Text == ""))
                return A3;

            return null;


        }

        private void checkForWinner()
        {
            bool winner = false;
            // cspr poziomo
            if((A1.Text == A2.Text)&&(A2.Text == A3.Text)&&(!A1.Enabled))
                winner = true;
            else if ((A4.Text == A5.Text) && (A5.Text == A6.Text) && (!A4.Enabled))
                winner = true;
            else if ((A7.Text == A8.Text) && (A8.Text == A9.Text) && (!A7.Enabled))
                winner = true;

            //pionowa
            else if ((A1.Text == A4.Text) && (A4.Text == A7.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == A5.Text) && (A5.Text == A8.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == A6.Text) && (A6.Text == A9.Text) && (!A3.Enabled))
                winner = true;

            //na krzyż
            else if ((A1.Text == A5.Text) && (A5.Text == A9.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == A5.Text) && (A5.Text == A7.Text) && (!A3.Enabled))
                winner = true;


            if (winner)
            {
                disableButtons();

                string TheWinner = "";
                if (turn)
                {
                    //TheWinner = player2;
                    TheWinner = P2.Text;
                    O_Win_Count.Text = (Int32.Parse(O_Win_Count.Text) + 1).ToString();
                }
                else
                {
                    //TheWinner = player1;
                    TheWinner = P1.Text;
                    X_Win_Count.Text = (Int32.Parse(X_Win_Count.Text) + 1).ToString();
                }

            MessageBox.Show("The winner is " + TheWinner);
            newGameToolStripMenuItem.PerformClick();
            }
            else
            {
                if (turnCount == 9)
                {
                    Remis_Count.Text = (Int32.Parse(Remis_Count.Text) + 1).ToString();
                    MessageBox.Show("Remis!");
                    newGameToolStripMenuItem.PerformClick();
                }
            }
               
        }   
        
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }

                catch { }
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X_Win_Count.Text = "0";
            O_Win_Count.Text = "0";
            Remis_Count.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Form f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label2.Text = player2;
            */
            setPlayerDefoultToolStripMenuItem.PerformClick();
        }

        private void P2_TextChanged(object sender, EventArgs e)
        {
            if (P2.Text.ToUpper() == "COMPUTER")
                against_computer = true;
            else
                against_computer = false;
        }

        private void setPlayerDefoultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P1.Text = "Player";
            P2.Text = "Computer";
        }
    }
}
