using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 6;
            int maxHealth = 10;

            int mana = 4;
            int maxMana = 10;

            int stamina = 5;
            int maxStamina = 10;

            DrawBar(health, maxHealth, ConsoleColor.Green, 0);
            DrawBar(mana, maxMana, ConsoleColor.Blue, 1);
            DrawBar(stamina, maxStamina, ConsoleColor.Yellow, 2);
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += "#";
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += "_";
            }

            Console.Write(bar + ']');
        }
    }
}
