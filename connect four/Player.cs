using System;
using System.Collections.Generic;
using System.Text;

namespace connect_four
{
    class Player
    {
        public string playernum;
        public string counter;

        

        public int turn()
        {
            int pc = 0;

            while (pc < 1 || pc > 6)
            {
                Console.WriteLine("Player {0} please take your turn:", playernum);
                pc = int.Parse(Console.ReadLine());

                if (pc < 1 || pc > 6)
                {
                    Console.WriteLine("Error!!!");
                    Console.WriteLine("Number was out of bounds!!!");
                }
            }
            return pc;
        }

        

        
    }
}
