using System;
/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/
int[] arr1 = new int[12];
int summPl = 0;
int summOtr=0;
foreach(int i in arr1)
{
    arr1[i] = new Random().Next(-9, 10);
    Console.Write($"{arr1[i]} ");
    if (arr1[i] > 0)
    {
        summPl += arr1[i];
    }
    else
        summOtr += arr1[i];
    
}
Console.WriteLine();
Console.WriteLine(summOtr + " " + summPl);
Console.WriteLine(arr1[1]);

/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/
/*int[] arr2  = new int[12];
foreach (int r in arr2)
{
    arr2[r] = new Random().Next(-9, 10);
    Console.Write(arr2[r]);
    Console.Write(" ");
}
Console.WriteLine();
*/
for (int i = 0 ;i < arr1.Length ;i++ )
{
    arr1[i] = new Random().Next(-9, 10);
    Console.Write($"{arr1[i]} ");
    Console.Write($"{arr1[i] * (-1)} ");
}
Console.WriteLine();

Console.WriteLine(arr1[1]);
/*Задача 33: Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
- 3; массив[6, 7, 19, 345, 3]->да*/
Console.WriteLine(); 

void FindNumber(int r)
{
    foreach(int i in arr1)
    {
        if(arr1[i] == i)
        {
            Console.WriteLine($"Элемент {r} присутствует в массиве");
        }else
            Console.WriteLine($"Элемент {r} отсутствует в массиве");
    }

}
Console.WriteLine("Введите число, которое хотите найти в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
FindNumber(x);
    

    
