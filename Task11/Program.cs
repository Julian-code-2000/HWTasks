// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int numbResult= -1;
int numberRandom = new Random().Next(99, 1000);
int numberNew = DeleteSecondDigit(numberRandom);

Console.WriteLine($"Рандомное трехзначное число {numberRandom}");

numbResult = numberNew;

Console.WriteLine($"Полученное двухзначное число {numbResult}");


int DeleteSecondDigit(int numberRan )
{
    int firstDigit = numberRan/ 100;
    int thirtDigit = numberRan % 10;
    int numberNew = (firstDigit*10)+thirtDigit;
    return numberNew;
}
