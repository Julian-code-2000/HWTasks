// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число ");

int number = Convert.ToInt32(Console.ReadLine());
if (NumbControl(number))
{
    Console.WriteLine($"трехзначное число {number}");
    int numbResult = FindSecondDigit(number);
    Console.WriteLine($"Полученная вторая цифра {numbResult}");
}
else
{
Console.WriteLine("Не трехзначное!!");
}






int FindSecondDigit(int numb)

{
    int numbRes = (numb / 10) % 10;
    return numbRes;
}
bool NumbControl(int numbCon)

{
    if (numbCon<100 || numbCon>=999+1)
    {
        return false;
    }
    return true;
    


}


