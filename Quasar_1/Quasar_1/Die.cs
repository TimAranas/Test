using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quasar_1
{
    partial class Form1
    {
        public int rollDie(int min, int max)
        {
            Random rnd = new Random();
            int roll = rnd.Next(min, max);
            return roll;
        }
    }
}
