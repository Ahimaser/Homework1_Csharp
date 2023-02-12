using System;

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] Array(int m, int n)
{
    
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 15);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}
int[,] arr = Array(m, n);

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
Console.WriteLine("\n Задача №1 \n");

void ChangeArray(int [,] arr)
{
    Console.WriteLine("Упорядоченный по убыванию значений элементов в строках массив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = arr[i, j];
            for (int count = j + 1; count <arr.GetLength(1); count++)
            {

                if (arr[i, count] > max)
                {
                    max = arr[i, count];
                    arr[i, count] = arr[i, j];
                    arr[i, j] = max;
                }
            }

            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
ChangeArray(arr);


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("\n Задача №2 \n");
int[] arrSum = new int[m]; 
for (int i = 0; i < arr.GetLength(0); i++)
{
    arrSum[i] = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arrSum[i] = arrSum[i] + arr[i, j];
    }

}
int minSum = arrSum[0];
int minIndexStr = 0;
for (int i = 1; i < arrSum.Length; i++)
{
    if (arrSum[i] < minSum)
    {
        minSum = arrSum[i];
        minIndexStr = i;
    }
}
string indexStr = string.Empty;
for (int i = 0; i < arrSum.Length; i++)
{
    if (arrSum[i] == minSum && i != minIndexStr)
    {
        indexStr = Convert.ToString(minIndexStr + 1) + "," + Convert.ToString(i + 1);
    }
}
if (indexStr == "")
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minIndexStr + 1}");
else
    Console.WriteLine($"Номера строк с наименьшей суммой элементов: {indexStr}");


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
Console.WriteLine("\n Задача №3 \n");

Console.WriteLine($"Число строк второй матрицы должно совпадать с числом столбцов первой: их {m}");
Console.Write("Введите количество столбцов второго массива : ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nПервый массив:");
int[,] array = Array(n, m);
Console.WriteLine("\nВторой массив:");
int[,] array2 = Array(m, n2);
Console.WriteLine("\nПроизведение массивов:");


int[,] arraySum = new int[n, n2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        arraySum[i, j] = 0;
        for (int r = 0; r < array.GetLength(1); r++)
        {
            arraySum[i, j] = arraySum[i, j] + array[i, r] * array2[r, j];
        }
        Console.Write($"{arraySum[i, j]} ");
    }
    Console.WriteLine();
}


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)*/
Console.WriteLine("\n Задача №4 \n");

int[,,] arr3D = new int[2, 2, 2];
int koeffic = 1;
void Show3DArray(int[,,] array)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                arr3D[i, j, k] = new Random().Next(10, 12) * koeffic;
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
                koeffic++;
            }
            Console.WriteLine();
        }
    }
}

Show3DArray(arr3D);


/*Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.WriteLine("\n Задача №5 \n");
