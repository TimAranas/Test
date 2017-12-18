using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quasar_1
{
    public partial class Form1 : Form
    {
        int score = 0;
        double winnings;
        double initial;
        Turn turn;
        Player player;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Player();
            turn = new Turn();
            
            
        }

        private void b_die1_Click(object sender, EventArgs e)//roll 1-8 die
        {
            int result = rollDie(1, 9);
            tb_roll.Text = "" + result;
            score = score + result;
            l_total.Text = "Total: " + score;
            nu_bet.Enabled = false;
            if (score >= 15)
            {
                b_fold.Visible = true;
            }
            double payout = turn.finish(score, initial);
            l_profit.Text = "Profit: " + payout;

        }
       
        private void b_die2_Click(object sender, EventArgs e)//roll 4-7 die
        {
            int result = rollDie(4, 8);
            tb_roll.Text = "" + result;
            score = score + result;
            l_total.Text = "Total: " + score;
            nu_bet.Enabled = false;
            if (score >= 15)
            {
                b_fold.Visible = true;
            }
            double payout = turn.finish(score, initial);
            l_profit.Text = "Profit: " + payout;
        }

        private void b_fold_Click(object sender, EventArgs e)//fold button (finish turn)
        {
            tb_roll.Text = "0";
            
        }

        private void nu_bet_ValueChanged(object sender, EventArgs e)//change initial bet
        {
            initial = decimal.ToDouble(nu_bet.Value);
            l_profit.Text = "Profit: " + nu_bet.Value;
            b_die1.Enabled = true;
            b_die2.Enabled = true;
            b_fold.Enabled = true;
        }

        private void nu_playrNum_ValueChanged(object sender, EventArgs e)//change num of players
        {
            List<int> playerList = new List<int>();
            for(int i = 0; i <= nu_playrNum.Value; i++)
            {
                playerList.Add(i);
            }
            l_playerTurn.Text = "Player 's Turn";
            b_start.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nu_bet.Enabled = true;
        }
    }
}
