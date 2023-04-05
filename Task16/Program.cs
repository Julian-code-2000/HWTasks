// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите  первое  число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsFirstSquareSecond(number1, number2);
Console.WriteLine(result ? "Является" : " НЕ Является");

bool IsFirstSquareSecond(int numb1, int numb2)
{
    return numb1 * numb1 == numb2;
}