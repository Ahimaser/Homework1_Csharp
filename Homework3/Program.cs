using System;
/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/




Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if ((N / 10000 == N % 10) && (N / 1000 % 10 == N / 10 % 10))
{
    Console.WriteLine($"{N} -> палиндром");
}
else
{
    Console.WriteLine($"{N} -> не палиндром");
}


/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53*/
Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2)));

Console.WriteLine($" Дистанция между двумя точками = {Math.Round(dist, 2)}");


/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.Write("Введите число N: ");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N2} -> ");
for (int i = 1; i <= N2; i++)
{
    if (i != N2)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
    else
    {
        Console.Write($"{Math.Pow(i, 3)}. ");
    }
}