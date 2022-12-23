using System;

namespace GeneratorOfRandomNumbersOfBinarySystem
{
    class Programm
    {
        public static void Main(string[] args)
        {
            // Рандомный вывод числа в двоичной системе
            Random rnd = new Random();
            Console.WriteLine("Введите количество цифр в вашем числе: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] array = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2);
            }
            Console.WriteLine($"Результат в строчку: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Результат в столбик: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }
    }
}