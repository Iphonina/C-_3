﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
Console.Clear();
Console.Write("Введите номер четверти для определения возможных координат: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Координаты X > 0 и Y > 0");
}
else if( num == 2)
{
    Console.WriteLine("Координаты X < 0 и Y > 0");
}
else if( num == 3)
{
    Console.WriteLine("Координаты X < 0 и Y < 0");
}
else if( num == 4)
{
    Console.WriteLine("Координаты X > 0 и Y < 0");
}
else if(num<1 | num > 4)
{
    Console.Write("Такой четверти нет!");
}