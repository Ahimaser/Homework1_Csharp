using System;
// Math.Abs() - модуль числа
//Math.Round(x, 0) - округление до целых , Math.Round(x, 1) - округление до 1 знака после запятой


/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Например:
78-> 8
12-> 2
85-> 8
*/
int number1 = new Random().Next(10,99);
int firstnumbr, secondnumbr, maxnumbr;

secondnumbr = number1 % 10;
firstnumbr = (number1 - secondnumbr)/10;
if (firstnumbr > secondnumbr)
{
    maxnumbr = firstnumbr;
}
else
    maxnumbr = secondnumbr;
Console.WriteLine($" Число {number1}, первая цифра числа = {firstnumbr}, вторая = {secondnumbr}, макскимальная цифра числа = {maxnumbr}");


/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
int numberthree = new Random().Next(100, 999);
int x;
x = (numberthree / 100) * 10 + numberthree% 10;
Console.WriteLine($"Число {numberthree}, если убрать вторую цифру получится {x}");


/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
Console.WriteLine("Введите первое число : ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int second = Convert.ToInt32(Console.ReadLine());
if(first%second == 0)
{
	Console.WriteLine($"Число {first} кратно {second}");
}else
{
	int ostatok = first % second;
	Console.WriteLine($"{ostatok}");
}


/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да*/
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
if(number%7==0 && number % 23 == 0)
{
	Console.WriteLine($"Число {number} кратно и 7 и 23");
}
else
{
	Console.WriteLine($"Число {number} не кратно и 7 и 23");
}


/*У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
	​Необходимо составить код, который находит их пересечение.
	Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего
	С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или «не пересекаются»
*/
Console.WriteLine("Задайте 2 отрезка (значение начала отрезка должно быть меньше значения конца отрезка!");
Console.WriteLine("Введите начало первого отрезка : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец первого отрезка : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало второго отрезка : ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец второго отрезка : ");
int x4 = Convert.ToInt32(Console.ReadLine());

if (x1 < x2 && x3 < x4)
{
	if (x1 < x3)
	{
		if (x2 == x3)
		{
			Console.WriteLine($"отрезки  пересекаются в точке {x2}");
		}
		else if (x2 > x3)
		{
			Console.WriteLine($"Отрезки пересекаются на отрезке {x3}, {x2}");
		}
		else
			Console.WriteLine("отрезки не пересекаются");
	}
	else if (x1 > x3)
	{
		if (x4 == x1)
		{
			Console.WriteLine($"отрезки  пересекаются в точке {x1}");
		}
		else if (x4 > x1)
		{
			Console.WriteLine($"Отрезки пересекаются на отрезке {x4}, {x1}");
		}
		else
			Console.WriteLine("отрезки не пересекаются");
	}
} else Console.WriteLine("Читайте условия внимательнее!");


