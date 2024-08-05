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
            int healthPercent = 60;
            int maxHealth = 10;

            int manaPercent = 40;
            int maxMana = 10;

            int staminaPercent = 50;
            int maxStamina = 10;

            DrawBar(healthPercent, maxHealth, ConsoleColor.Green, 0);
            DrawBar(manaPercent, maxMana, ConsoleColor.Blue, 1);
            DrawBar(staminaPercent, maxStamina, ConsoleColor.Yellow, 2);
        }

        static void DrawBar(int valuePercent, double maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            int maxPercent = 100;

            double value = maxValue / maxPercent * valuePercent;

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

            for (double i = value; i < maxValue; i++)
            {
                bar += "_";
            }

            Console.Write(bar + ']');
        }
    }
}
