﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakes
{
  

    static internal class Menue
    {



    public static int Show(int MinStrelochka, int MaxStrelochka) 
        {

            int pos = 1;
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != MinStrelochka) {

                    pos--;
                }

                else if (key.Key == ConsoleKey.DownArrow && pos != MaxStrelochka) {

                    pos++;

                }

            } while (key.Key != ConsoleKey.Enter);

            return pos;


        }
    }
}
