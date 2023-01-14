using System;
/*1.Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5->да 
a = 2, b = 10->нет 
a = 9, b = -3->да 
a = -3 b = 9 -> нет
*/

Console.Write("Введите первое число : ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число : ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
if (firstnumber == (secondnumber * secondnumber))
{
	Console.WriteLine($"{firstnumber} является квадратом числа {secondnumber}");
}
else Console.WriteLine($"{firstnumber} не является квадратом числа {secondnumber}");
//----------------------------------------------------------------------------------------------------
/*3.Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
5 -> Пятница
*/
string m = "Понедельник", t = "Вторник", s = "Среда", c = "Четверг", fr = "Пятница", sub = "Суббота", vs = "Воскресенье";
Console.WriteLine("Введите порядковый номер дня недели (от 1 до 7) : ");
int x = Convert.ToInt32(Console.ReadLine());
switch (x){
	case 1:
		Console.WriteLine(m);
		break;
	case 2 :
		Console.WriteLine(t);
		break;
	case 3:
		Console.WriteLine(s);
		break;
	case 4:
		Console.WriteLine(c);
		break;
	case 5:
		Console.WriteLine(fr);
		break;
	case 6:
		Console.WriteLine(sub);
		break;
	case 7:
		Console.WriteLine(vs);
		break;
	default:
		Console.WriteLine("Вы ввели неверное число!");
		break;
}
//----------------------------------------------------------------------------------------------------
/*5.Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/
Console.WriteLine("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
 for (int i = -N; i <= N; i++)
{
	Console.Write($" {i}");
}
//------------------------------------------------------------------------------------------------------
/*7.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8*/
Console.WriteLine();
Console.WriteLine("Введите трехзначное число : ");
int numbr = Convert.ToInt32(Console.ReadLine());
if(numbr< 100 && numbr > 999)
{
	Console.WriteLine("Вы ввели неверное число");
}
else
{

	Console.WriteLine($"Последняя цифра вашего числа : {numbr%10}");
}