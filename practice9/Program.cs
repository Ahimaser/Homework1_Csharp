using System;
/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/
Console.WriteLine("Задача №1 \n");
Console.WriteLine("Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
int x = 1;
void ShowDoN(int i, int x)
{
    Console.WriteLine($"{x} ");
    if (x < i) 
    {
        x++;
        ShowDoN(i, x);
    }
}
ShowDoN(n, x);
/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5-> "1, 2, 3, 4, 5"
M = 4; N = 8-> "4, 6, 7, 8"*/
Console.WriteLine("\nЗадача №2 \n");
Console.WriteLine("Введите число :");
int m = Convert.ToInt32(Console.ReadLine());

void ShowSecond(int i, int x)
{
    if (i <= x)
    {
        Console.WriteLine($"{i} ");

        i++;
        ShowSecond(i, x);
    } 
    else Console.WriteLine();
    
}

ShowSecond(n, m);

/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/
Console.WriteLine("\nЗадача №3 \n");
int z = new Random().Next(10,100000);
Console.WriteLine(z + "\n");
int summ = 0;
void SummNumbers(int x, int sum)
{
    sum += x % 10;
    x /= 10;
    if (x % 10 != 0)
    {
        SummNumbers(x, sum);
    }else
    Console.WriteLine(sum);
    
}

SummNumbers(z, summ);
/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5-> 243(3⁵)
A = 2; B = 3-> 8*/
Console.WriteLine("\nЗадача №4 \n");
Console.WriteLine("Введите число :");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую хотите возвести число : ");
int x2 = Convert.ToInt32(Console.ReadLine());

int Stepen(int x, int y)
{
    if (y == 1)
    {
        return x;
    }
    else { 
        return x * Stepen(x, y - 1);
    }
    
}
Console.WriteLine(Stepen(x1, x2));