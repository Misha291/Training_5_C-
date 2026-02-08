using System;

namespace tran5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число от 1 до 10: ");
            int chislo = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (chislo < 1 || chislo > 10)
            {
                Console.WriteLine("Ошибка: число не входит в интервал от 1 до 10");
                Console.ReadKey();
                return;
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{chislo} x {i} = {chislo * i}");
            }
            Console.ReadKey();
        }
    }
}
