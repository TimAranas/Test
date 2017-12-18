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
        Form1 form = new Form1();
        Turn turn = new Turn();
        public bool status;
        List<int> turnList = new List<int>();
        //int [] turn = new int[5];
       
        public void playerTurn()//create number of turns for each player
        {
            for (int i = 0; i <= 5; i++)
            {
                
                turnList.Add(i);

            }
            if (!status)
            {
                turnList.Remove(1);
            }
        }
       
    }
}
