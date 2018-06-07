using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool xTurn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;

            if (xTurn)
                senderB.Text = "X";

            else
                senderB.Text = "O";
            xTurn = !xTurn;

            senderB.Enabled = false;

            Win();
        }

        void Win()
        {
            bool winner = false;

            if ((button1.Text != "") && (button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                winner = true;
                MessageBox.Show("Winner " + button1.Text + " !");
                Application.Restart();
            }

            if ((button4.Text != "") && (button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                winner = true;
                MessageBox.Show("Winner " + button4.Text + " !");
                Application.Restart();
            }

            if ((button7.Text != "") && (button7.Text == button8.Text) && (button2.Text == button9.Text))
            {
                winner = true;
                MessageBox.Show("Winner " + button7.Text + " !");
                Application.Restart();
            }

            if ((button1.Text != "") && (button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                winner = true;
                MessageBox.Show("Winner " + button1.Text + " !");
                Application.Restart();
            }

            if ((button2.Text != "") && (button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                winner = true;
                MessageBox.Show("Winner " + button2.Text + " !");
                Application.Restart();
            }

            if ((button3.Text != "") && (button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                winner = true;
                MessageBox.Show("Winner " + button3.Text + " !");
                Application.Restart();
            }

            if ((button1.Text != "") && (button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                winner = true;
                MessageBox.Show("Winner " + button1.Text + " !");
                Application.Restart();
            }

            if ((button3.Text != "") && (button3.Text == button5.Text) && (button5.Text == button7.Text))
            {
                winner = true;
                MessageBox.Show("Winner " + button3.Text + " !");
                Application.Restart();
            }

            if ((!winner) && (button1.Enabled == false) && (button2.Enabled == false) && (button3.Enabled == false) 
                && (button4.Enabled == false) && (button5.Enabled == false) && (button6.Enabled == false) && (button7.Enabled == false) && (button8.Enabled == false) && (button9.Enabled == false)) 
            {
                MessageBox.Show("A draw!");
                Application.Restart();
            }
        }


    }
}
