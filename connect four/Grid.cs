using System;
using System.Collections.Generic;
using System.Text;


namespace connect_four
{
    public class Grid
    {
        public string[,] _grid = new string[7, 7]
            { { "1    ", "-    ", "-    ", "-    ", "-    ", "-    ", "-    " },
            { "2    ", "-    ", "-    ", "-    ", "-    ", "-    ", "-    " },
            { "3    ", "-    ", "-    ", "-    ", "-    ", "-    ", "-    " },
            { "4    ", "-    ", "-    ", "-    ", "-    ", "-    ", "-    " },
            { "5    ", "-    ", "-    ", "-    ", "-    ", "-    ", "-    " },
            { "6    ", "-    ", "-    ", "-    ", "-    ", "-    ", "-    " },
            { "7    ", "-    ", "-    ", "-    ", "-    ", "-    ", "-    " }, };

        //Attributes
        //Constructors
        //Properties
        //Methods

        public void display()
        {
            Console.WriteLine("0     1     2     3     4     5     6");

            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    Console.Write("{0} ", _grid[y, x]);
                }
                Console.WriteLine();
            }
        }

        public void placecounter(int pc, string counter)
        {
            for (int i = 0; i < 7; i++)
            {
                if (i > 0)
                {
                    if (_grid[i, pc] == "X    " || _grid[i, pc] == "0    ")
                    {
                        _grid[i - 1, pc] = counter + "    ";
                        break;
                    }

                    else if (i == 6)
                    {
                        _grid[i, pc] = counter + "    ";
                        break;
                    }
                }
            }
        }

        public bool wincheck(string counter, string playernum)
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (y > 3 || x > 3)
                    {
                        if (_grid[x, y] == counter + "    " && _grid[x, y - 1] == counter + "    " && _grid[x, y - 2] == counter + "    " && _grid[x, y - 3] == counter + "    ")
                        {
                            Console.WriteLine("Player {0} has won!!!", playernum);
                            Console.ReadLine();
                            return true;
                        }

                        if (_grid[x, y] == counter + "    " && _grid[x - 1, y] == counter + "    " && _grid[x - 2, y] == counter + "    " && _grid[x - 3, y] == counter + "    ")
                        {
                            Console.WriteLine("Player {0} has won!!!", playernum);
                            Console.ReadLine();
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
}
