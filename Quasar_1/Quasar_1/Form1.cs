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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void b_die1_Click(object sender, EventArgs e)
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

        private void b_die2_Click(object sender, EventArgs e)
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

        private void b_fold_Click(object sender, EventArgs e)
        {
            tb_roll.Text = "0";
        }
    }
}
