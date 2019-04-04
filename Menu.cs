using System;
using System.Collections.Generic;
using RSS_Reader;

namespace RSS_Reader
{
    public class Menu
    {
        static int index = 1;
        static public int Draw(List<XML> items)
        {
            {
                for (int i = 1; i < items.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(items[i].Title);
                    } else {
                        Console.WriteLine(items[i].Title);
                    }
                    Console.ResetColor();
                }

                ConsoleKeyInfo ckey = Console.ReadKey();

                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    if (index == items.Count -1) { index = 1;
                    } else { index++; }
                } else if (ckey.Key == ConsoleKey.UpArrow) 
                {
                    if (index <= 1) { index = items.Count -1;
                    } else { index--; }
                } else if (ckey.Key == ConsoleKey.Enter) 
                {
                    return index;
                } else if (ckey.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                } else {
                    return 0;
                }

                Console.Clear();
                return 0;
            }
        }
    }
}
