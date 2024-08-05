using System;

namespace UIBar
{
    internal class Program
    {
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
            int firstIndex = 0;

            char fillingBar = '#';
            char emptyBar = '_';

            double value = maxValue / maxPercent * valuePercent;

            string bar = "";

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.Write(bar);

            Console.BackgroundColor = color;

            FillBar(firstIndex, value, fillingBar);

            Console.BackgroundColor = defaultColor;

            bar = "";

            FillBar(value, maxValue, emptyBar);

            Console.Write(bar + ']');
        }

        static void FillBar(double firstIndex, double lastIndex, char filling)
        {
            for (double i = firstIndex; i < lastIndex; i++)
            {
                Console.Write(filling);
            }
        }
    }
}
