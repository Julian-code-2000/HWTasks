//  Написать программу котораая на вход получает 2 числа, и проверяет является ли второе число корнем первого.
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1==number2*number2)
{
Console.WriteLine($"Число {number1} является квадартом числа {number2}");
}
else
Console.WriteLine($"Число {number1} НЕ является квадартом числа {number2}");