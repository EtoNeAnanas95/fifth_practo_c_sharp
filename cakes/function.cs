using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cakes
{
    internal class function
    {
        public static int arrow_menu(int index)
        {
            Console.SetCursorPosition(0, index + 2);
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажмите Escape чтобы вернуться в меню");
            Console.ResetColor();
            ConsoleKey key = ConsoleKey.Q;
            int position = 2;
            while (key != ConsoleKey.Enter)
            {

                key = Console.ReadKey().Key;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (position > 2) position--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (position <= index) position++;
                        break;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                Console.ResetColor();
                if (key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    return -1;
                }
                if (key == ConsoleKey.Enter) Console.Clear();
            }
            return position-2;
        }
        public static string print(int index, string[] argument, int[] cost)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Выберите параметр торта:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------");
            for (int i = 1; i <= index; i++)
            {
                Console.WriteLine($"  {i}. {argument[i-1]}, цена -- {cost[i-1]}");
            }
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("->");
            return null;
        }


    }
}
