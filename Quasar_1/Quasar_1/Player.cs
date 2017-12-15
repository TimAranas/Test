using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quasar_1
{
    partial class Form1
    {  
           
    }

    public class Player
    {
        bool done = true;
        List<int> turnList = new List<int>();
        public void playerTurn()//create number of turns for each player
        {
            for (int i = 0; i <= 5; i++)
            {
                turnList.Add(i);
            }
            if (!done)
            {
                turnList.Remove(1);
            }
        }
    }
}
