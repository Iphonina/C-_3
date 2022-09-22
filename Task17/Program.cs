﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();
Console.Write("Ввведите координату Х: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X == 0 | Y == 0)
{
    Console.WriteLine("Введите другую координату");
}
else if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}