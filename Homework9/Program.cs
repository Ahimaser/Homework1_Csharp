using System;

namespace Homework9
{
    class Program
    {
        private static int N,M;
        private static int sum;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1 \n");/*Задача 64: Задайте значение N. Напишите программу, 
                                               * которая выведет все натуральные числа в промежутке от N до 1. 
                                               * Выполнить с помощью рекурсии.

                                                N = 5 -> "5, 4, 3, 2, 1"
                                                N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());
            Count(N);

            Console.WriteLine("\nЗадача №2 \n");/*Задача 66: Задайте значения M и N. 
                                                 * Напишите программу, которая найдёт сумму натуральных элементов 
                                                 * в промежутке от M до N.
                                                    M = 1; N = 15-> 120
                                                    M = 4; N = 8. -> 30*/
            Console.WriteLine("Введите число M : ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N : ");
            N = Convert.ToInt32(Console.ReadLine());
            sum = N;
            Console.WriteLine($"Сумма равна {Count(M, N)} ");

            Console.WriteLine("\nЗадача №3 \n");/*Задача 68: Напишите программу вычисления функции Аккермана с помощью
                                                 * рекурсии. Даны два неотрицательных числа m и n.
                                                    m = 2, n = 3->A(m, n) = 9
                                                    m = 3, n = 2->A(m, n) = 29*/
            Console.WriteLine("Введите число M : ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N : ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Функция Аккермана от этих чисел {AccK(N, M)} ");
        }
        static void Count(int N)
        {
            if (N == 1)
            {
                Console.Write($"{N} "); 
            }
            else
            {
                Count(N - 1);
                Console.Write($"{N} ");
            }
        }
        
        static int Count(int M, int N)
        {
            if (N <= M)
                return sum;

            return sum = (N - 1) + Count(M, N - 1);


        }
        static int AccK(int N, int M)
        {
            if (N == 0)
                return M + 1;

            if (M == 0) return AccK(N - 1, 1);
            else
                return AccK(N - 1, AccK(N, M - 1));
        }

    } 
}
