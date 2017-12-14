using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quasar_1
{
    partial class Form1
    {
        public double finish(int total, double bet)
        {
            if (total == 15)
            {
                bet = bet * 0.25;
            }
            else if(total == 16)
            {
                bet = bet * 0.50;
            }
            else if (total == 17)
            {
                bet = bet * 1.00;
            }
            else if(total == 18)
            {
                bet = bet * 1.25;
            }
            else if (total == 19)
            {
                bet = bet * 1.50;
            }
            else if (total == 20)
            {
                bet = bet * 2.00;
            }
            return bet;
        }

    }
}
