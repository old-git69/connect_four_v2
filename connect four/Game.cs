using System;
using System.Collections.Generic;
using System.Text;

namespace connect_four
{
    class Game
    {
        private Grid _grid;
        
        public void startgame()
        {
            bool wcheck = false;

            _grid = new Grid();

            _grid.display();

            Player p1 = new Player();
            p1.playernum = "1";
            p1.counter = "X";

            Player p2 = new Player();
            p2.playernum = "2";
            p2.counter = "0";

            while (wcheck == false)
            {
                int pc;

                pc = p1.turn();

                _grid.placecounter(pc, p1.counter);

                _grid.display();

                wcheck = _grid.wincheck(p1.counter, p1.playernum);

                if (wcheck == false)
                {
                    pc = p2.turn();

                    _grid.placecounter(pc, p2.counter);

                    _grid.display();

                    wcheck = _grid.wincheck(p2.counter, p1.playernum);
                }
            }
        }
    }
}
