﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// // возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти ");
int numberDeap = Convert.ToInt32(Console.ReadLine());

string quarterDeap = QuarterDeap(numberDeap);


Console.WriteLine(quarterDeap);


string QuarterDeap(int n)
{
    if (n == 1) return "x > 0   y > 0";
    if (n == 2) return "x < 0   y > 0";
    if (n == 3) return "x < 0  y < 0";
    if (n == 4) return "x > 0  y < 0";
    return "0 или НЕТ ТАКОЙ ЧЕТВЕРТИ!!!";
}