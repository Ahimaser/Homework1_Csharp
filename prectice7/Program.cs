using System;

int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/
void DoubleArray( int m, int n)
{
    int[,] arr = new int[m, n];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
            Console.Write(arr[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("-----");
}




/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n.Выведите полученный массив на экран.
m = 3, n = 4.
 0 1 2 3
1 2 3 4
2 3 4 5*/
void DoubleArray2(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
            Console.Write(arr[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("-----");
}

/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4*/
void ChangeArray(int m, int n)
{
    Console.WriteLine("Изначальный массив: ");
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
            Console.Write(arr[i, j]);
            Console.Write(" ");
           
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Измененный массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i % 2 == 0 && j%2==0)
            {
                arr[i, j] = arr[i, j] * arr[i, j];
               
            }
            Console.Write(arr[i, j]);
            Console.Write(" ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("-----");
}



/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
 Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/
void SummArray(int m,int n)
{
    int[,] arr = new int[m, n];
    int summ = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
            Console.Write(arr[i, j]);
            Console.Write(" ");
            if (i == j)
            {
                summ += arr[i, j];
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма центральных элементов = {summ}");
}
DoubleArray(x1, x2);
DoubleArray2(x1, x2);
ChangeArray(x1, x2);
SummArray(x2, x1);

/*x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5
Сумма 4 чисел в 5 степени равна пятому числу в пятой степени
Нужно найти эти числа (их 5) (от 1 до 300)*/