using System;

//Масссивы
// Math.Sqrt(x) - корень числа
//Math.Pow(x,2) - возведение в степень

/*Задача №17.Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
Console.WriteLine("Введите x : "); 
Console.WriteLine("Введите y : ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("вы в правой верхней четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("вы в правой нижней четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("вы в левой верхней четверти");
    }
    else
        Console.WriteLine("вы в левой нижней четверти");
}
else Console.WriteLine("Ваша точка расположена по центру");

/*Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
int [] arrX = { -3, -2, -1, 0, 1, 2, 3 };
int [] arrY = { -3, -2, -1, 0, 1, 2, 3 };
Console.WriteLine("Введите номер четверти : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Диапазон возможных координат данной четверти : ");
    for (int i = 0; i < arrX.Length; i++)
    {
        if (arrX[i] >= 0 && arrY[i] >= 0)
        {
            Console.WriteLine("x : " + arrX[i] + " y : " + arrY[i]);
        }

    }

}
else if (number == 2)
{
    Console.WriteLine("Диапазон возможных координат данной четверти : ");
    for (int i = 0; i < arrX.Length; i++)
    {
        if (arrX[i] <= 0 && arrY[i] >= 0)
        {
            Console.WriteLine("x : " + arrX[i] + " y : " + arrY[i]);
        }

    }

}
else if (number == 3)
{
    Console.WriteLine("Диапазон возможных координат данной четверти : ");
    for (int i = 0; i < arrX.Length; i++)
    {
        if (arrX[i] >= 0 && arrY[i] <= 0)
        {
            Console.WriteLine("x : " + arrX[i] + " y : " + arrY[i]);
        }

    }

}
else if (number == 4)
{
    Console.WriteLine("Диапазон возможных координат данной четверти : ");
    for (int i = 0; i < arrX.Length; i++)
    {
        if (arrX[i] <= 0 && arrY[i] <= 0)
        {
            Console.WriteLine("x : " + arrX[i] + " y : " + arrY[i]);
        }

    }

}
else Console.WriteLine("Такой четверти не существует, их всего 4");
/*21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B(2, 1)-> 5,09
A(7, -5); B(1, -1)-> 7,21
*/

Console.WriteLine("Введите координаты первой точки x = ");
Console.WriteLine("Введите координаты первой точки y = ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки x = ");
Console.WriteLine("Введите координаты второй точки y = ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());


double s = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
Console.WriteLine(s);


/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/
Console.WriteLine("Введите число : ");
int xx = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= xx; i++)
{
    Console.Write ( $"{i} в квадрате = {Math.Pow(i, 2)}; ");
}