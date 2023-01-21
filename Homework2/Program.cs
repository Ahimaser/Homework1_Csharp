using System;
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
/*Console.WriteLine("Введите трехзначное число : ");
int x = Convert.ToInt32(Console.ReadLine());
int anotherX = new Random().Next(100, 1000);

Console.WriteLine($"Вторая цифра числа введенного с клавиатуры = {(x / 10) % 10}, вторая цифра рандомно числа {anotherX} = {(anotherX / 10) % 10}");
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number / 100 != 0)
{
    int x = number;
    while (x!=0)
    {
        x /= 10;
        count++;
    }
    count = count - 2;
    int i = 1;
    int r = 1;
    while (i < count)
    {
        r *= 10;
        i++;
    }
    Console.WriteLine($"Третья цифра числа {number} (справа) = {(number / 100) % 10}, а третья цифра (слева) ={number/r%10}");
}
else Console.WriteLine($"В числе {number} меньше 3 цифр");


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine($"Введите номер дня недели (от 1 до 7)");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
    if (day == 6 && day == 7)
    {
        Console.WriteLine("Сегодня выходной! Отдыхайте!!");
    }
    else Console.WriteLine("Рабочий день.");
}
else Console.WriteLine("Такого дня нет, вы ошиблись.");