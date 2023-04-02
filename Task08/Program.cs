// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите  число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int i = 0;
while(i<=number1)
// пока
{
if (0==i%2)
{
Console.Write($"{i},");
}
i++;
}

