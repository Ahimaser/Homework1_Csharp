using System;
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16
*/
int result_deg = 0;
int degree(int A, int B)
{

    int result_deg = 1;
    for (int i = 0; i < B; i++)
    {
        result_deg *=  A;

    }
    return result_deg;
}

Console.Write("Введите первое число:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(degree(x1, y1));
Console.WriteLine();

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
int count = 0;
int countN(int numA)
{
    // int count = 0;
    while (numA != 0)
    {
        numA = numA / 10;
        count += 1;
    }
    return count;
}

int sumN(int numA, int lenght)
{
    int length = count;
    int result = 0;
    for (int i = 0; i <= lenght; i++)
    {
        result += numA % 10;
        numA = numA / 10;
    }
    return result;
}
Console.Write("Введите число:");
int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(countNum(82));
Console.WriteLine($"Сумма цифр введенного числа = {sumN(x2, countN(x2))}");




/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33-> [6, 1, 33]
*/
string Arr(int count)
{

    string x = "";
    if (count <= 8)
    {
        int[] array = new int[count];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0,50);

        }
        x = string.Join(", ", array);


    }

    else
    {
        Console.Write("Максимальное колличество элементов 8.");
    }
    return x;
}
Console.Write("Введите колличество чисел :");
int result = Convert.ToInt32(Console.ReadLine());
Console.Write(Arr(result));