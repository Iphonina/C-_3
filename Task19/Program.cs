﻿// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите 5-значное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int n1 = N/10000;
int help = N-n1*10000;
int n2 = (help)/1000;
int n4 = ((help)/10)%10;
int n5 = N%10;

if(N < 10000 | N > 99999) Console.Write("Введенное число неверное, введите другое число!");
else if(n1 == n5 && n2 == n4) Console.Write("Введенное число является палиндромом!");
else Console.Write("Введенное число не является палиндромом!");

