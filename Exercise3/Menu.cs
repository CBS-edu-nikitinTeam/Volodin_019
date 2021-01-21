using System;
using System.Linq;

namespace Exercise3
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Введите должность:");
            var posts = Enum.GetValues(typeof(Post));

            for (int i = 0; i < posts.Length; i++)
            {
                Console.WriteLine($"{i+1} - {posts.GetValue(i)}");
            }

            if (!int.TryParse(Console.ReadLine(), out int postCode))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }

            if (postCode <= 0 || postCode > posts.Length)
            {
                Console.WriteLine("Должность с данным кодом не существует");
                return;
            }

            Console.WriteLine("Введите кол-во часов работы за месяц:");


            if (!int.TryParse(Console.ReadLine(), out int hours))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }

            Post worker = (Post)posts.GetValue(postCode);

            Console.WriteLine($"Вам{(new Accountant().AskForBonus(worker,hours) ? " " : " не ")}положен бонус");
        }
    }
}
