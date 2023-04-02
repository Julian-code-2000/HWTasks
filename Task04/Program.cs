// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());


if (number1>number2)
{
    if (number1>number3)
    {
        Console.WriteLine($"число {number1} ,большее");
    }
    else
    {
        Console.WriteLine($"число {number3} ,большее");
    }
}
else
{
    if (number2>number3)
    {
        Console.WriteLine($"число {number2} ,большее");
    }
    else
    {
        Console.WriteLine($"число {number3} ,большее");
    }
}