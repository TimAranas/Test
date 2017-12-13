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
        //Turn turn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void b_die1_Click(object sender, EventArgs e)//roll 1-8 die
        {
            int result = rollDie(1, 9);
            tb_roll.Text = "" + result;
            score = score + result;
            l_total.Text = "Total: " + score;
            if (score >= 15)
            {
                b_fold.Visible = true;
            }
        }

        private void b_die2_Click(object sender, EventArgs e)//roll 4-7 die
        {
            int result = rollDie(4, 8);
            tb_roll.Text = "" + result;
            score = score + result;
            l_total.Text = "Total: " + score;
            if (score >= 15)
            {
                b_fold.Visible = true;
            }

        }

        private void b_fold_Click(object sender, EventArgs e)//fold button (finish turn)
        {
            tb_roll.Text = "0";
        }

        private void nu_bet_ValueChanged(object sender, EventArgs e)//change initial bet
        {
            nu_bet.
        }

        private void nu_playrNum_ValueChanged(object sender, EventArgs e)//change num of players
        {
            List<int> playerList = new List<int>();
            for(int i = 0; i <= nu_playrNum.Value; i++)
            {
                playerList.Add(i);
            }
        }
    }
}
