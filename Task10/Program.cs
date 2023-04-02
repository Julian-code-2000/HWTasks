// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int numbResult = -1; //-1 подсказка о неисправн.
int numberRandom = new Random().Next(99, 1000);
int numberNew = FindSecondDigit(numberRandom);

Console.WriteLine($"Рандомное трехзначное число {numberRandom}");

numbResult = numberNew;

Console.WriteLine($"Полученная вторая цифра {numbResult}");


int FindSecondDigit(int numb)
{
    int numbRes = (numb / 10) % 10;
    return numbRes;
}
