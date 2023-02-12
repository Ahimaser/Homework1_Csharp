using System;

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.WriteLine("Задача № 1 \n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble() * 10;
        Console.Write($"{Math.Round((array[i, j]), 1)} ");
    }
    Console.WriteLine();
}


/*Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17->такого числа в массиве нет*/
Console.WriteLine("\nЗадача № 2 \n");
Console.Write("Введите позицию элемента в двумерном массиве: ");
int target = Convert.ToInt32(Console.ReadLine());

int temp1 = 0;
int temp2 = 10;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (target == temp2 + temp1)
        {
            Console.WriteLine($"{target} -> {array[i, j]}");
            break;
        }
        temp1++;
    }
    temp1 = 0;
    temp2 = temp2 + 10;
    Console.WriteLine();
}

/*Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.WriteLine("\nЗадача № 3 \n");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
double temp = 0;
Console.Write("Среднее арифмитическое каждого столбца -> ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = (temp + array[i, j]);
    }
    Console.Write($"{Convert.ToDouble(temp) / n}; ");
    temp = 0;
}