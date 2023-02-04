using System;
using System.Linq;
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int number = new Random().Next(3, 9);
int[] numbers = new int[number];
int ans = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int a = new Random().Next(100, 1000);
    numbers[i] = a;
    Console.Write($"{numbers[i]}, ");
    if (numbers[i] % 2 == 0)
    {
        ans = ans + 1;
    }
    else
    {
        continue;
    }
}
Console.WriteLine($"Количество четных чисел = {ans}");



/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
 [3, 7, 23, 12] -> 19
 [-4, -6, 89, 6] -> 0*/

int number2 = new Random().Next(3, 9);
int[] numbers2 = new int[number2];
int count2 = 0;
for (int i = 0; i < numbers2.Length; i++)
{
    int a = new Random().Next(100, 1000);
    numbers[i] = a;
    Console.Write($"{numbers[i]}, ");
    if (numbers2[i] % 2 != 0)
    {
        ans = ans + numbers[i];
    }
    else
    {
        continue;
    }
}
Console.WriteLine($"Сумма нечетных чисел = {count2}");


/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Write("[ ");
for (int i = 0; i < numbers2.Length; i++)
{
    int a = new Random().Next(100, 1000);
    numbers[i] = a;
    Console.Write($"{numbers[i]} ");
}

int min = numbers.Min();
int max = numbers.Max();

Console.Write($"] -> {max - min}");