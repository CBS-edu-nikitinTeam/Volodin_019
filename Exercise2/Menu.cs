using System;
using System.Linq;

namespace Exercise2
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Введите слово для вывода в консоль:");
            string @string = Console.ReadLine();

            Console.WriteLine("Введите номер цвета: ");
            var colors = Enum.GetValues(typeof(Color));

            foreach (var color in colors)
            {
                Console.WriteLine($"{(int)color} - {color}");
            }
            if (!int.TryParse(Console.ReadLine(), out int colorCode))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }

            if (!Enum.IsDefined(typeof(Color), colorCode))
            {
                Console.WriteLine("Цвета с данным номером не существует");
            } else
            {
                Console.ForegroundColor = ColorProvider.Provide((Color)colorCode);
                Console.WriteLine(@string);
            }
        }
    }
}
