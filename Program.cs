using System;

namespace Project
{


    class Program
    {
        static void Main(string[] args)
        {
            void task25()
            {
                // Задача 25: Используя определение степени числа, напишите цикл, 
                // который принимает на вход два натуральных числа (A и B) 
                // и возводит число A в степень B.
                Console.WriteLine("введите число A");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите степень числа");
                int b = Convert.ToInt32(Console.ReadLine());
                int degree = a;

                for (int i = 1; i < b; i++)
                {
                    degree = degree * a;
                }
                Console.WriteLine("A в степени B равно: " + degree);

            }

            void task27()
            {
                // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
                // 452 -> 11, 82 -> 10, 9012 -> 12

                Console.WriteLine("введите число");
                int i = Convert.ToInt32(Console.ReadLine());
                int sum = 0;

                while (i > 0)
                {
                    int num = i % 10;
                    i = i / 10;
                    sum = sum + num;
                }
                Console.WriteLine("сумма всех цифр в числе равна: " + sum);

            }
            void task29()
            {
                // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
                // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
                // 6, 1, 33 -> [6, 1, 33]

                int[] numbers = new int[8];
                Console.Write("[");

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = new Random().Next(0, 99);
                    Console.Write(" " + Method(i) + " ");
                }
                Console.Write("[]");

                int Method(int a);
                {
                    return numbers[a];
                }

            }
        }

    }

}