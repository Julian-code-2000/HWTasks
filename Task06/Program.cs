// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
if(0==number1%2)
// % остаток от деления, если он равен 0, то число четное
{
Console.WriteLine($"Число {number1} ЧЕТНОЕ ");
}
else
{
    Console.WriteLine($"Число {number1} НЕ ЧЕТНОЕ ");
}