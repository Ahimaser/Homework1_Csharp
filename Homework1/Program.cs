using System;

/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3*//*
Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
int max, min;
if (first > second)
{
    max = first;
    min = second;
    Console.WriteLine($"Число {max} больше числа {min} ");
}
else if (first == second)
{
    
    Console.WriteLine($"Числа равны!");

}
else
{
    max = second;
    min = first;
    Console.WriteLine($"Число {max} больше числа {min} ");

}



*//*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*//*
Console.WriteLine("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int x3 = Convert.ToInt32(Console.ReadLine());
int maximum;
if (x1 > x2)
{
    if (x1 > x3)
    {
        maximum = x1;
        
    }
    else
        maximum = x3;

}
else
{
    if (x2 > x3)
    {
        maximum = x2;
    }
    else
        maximum = x3;
}
Console.WriteLine($"Максимальное из введенных чисел - это {maximum}");


*//*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4->да
- 3->нет
7->нет*//*

Console.WriteLine("Введите число : ");
int definition = Convert.ToInt32(Console.ReadLine());
if(definition%2 == 0)
{
    Console.WriteLine($"Число {definition} является четным");
}else
    Console.WriteLine($"Число {definition} является нечетным");

*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= N; i+=2)
{
        Console.WriteLine(i);
}