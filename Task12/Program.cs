﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int resultNumber= DivisionRemainder( number1 ,  number2);


if(resultNumber==0)
{
Console.WriteLine($"Число {number1} является кратным {number2}");
}
else
{
Console.WriteLine($"Осаток {resultNumber} ");
}


int DivisionRemainder(int num1 , int num2)  //поиск остатка
{
return  num1%num2;
}