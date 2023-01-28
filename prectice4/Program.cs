using System;


/*24) Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/
int Summ(int a)
{
    int summ = 0;
    for (int i = 1; i <= a; i++)
    {
        summ += i;
    }
    return summ;

}
Console.WriteLine("Введите число : ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {x} = {Summ(x)}");


/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/
int CountNumbers(int r)
{
    int count = 0;
    while (r != 0)
    {
        r /= 10;
        count++;
    }
    return count;
}
Console.WriteLine("Введите число : ");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {r} количество цифр = {CountNumbers(r)}");

/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/
int factorial(int n)
{
    int factorial = 1;
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    else
    {
        Console.WriteLine("Введите пожалуйста положительное число, а то мы не знаем что делать с отрицательным");
        return 0;
    }
}
Console.WriteLine("Введите число : ");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {f} = {factorial(f)}");

/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

void RandArr()
{
    
    int[] arr = new int [8];
    
    foreach(int n in arr)
    {
        arr[n] = new Random().Next(0, 2);
        Console.WriteLine(arr[n]);
    }
    
}
RandArr();