// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int thirdDigit= Convert.ToInt32(Console.ReadLine());

if (NumbControl(thirdDigit))
{
int numberResult = FindThirdDigit(thirdDigit);
Console.WriteLine($"{ numberResult }");
}

int FindThirdDigit(int numb)
{
    while(numb>999)
    {
     numb = numb/10;
    }
  int res = numb%10;
    return  res ;
}
bool NumbControl(int numbCon)
{
    if  (numbCon<100)
    {
        Console.WriteLine("У числа нет третей цифры");
        return  false;
    }
  return  true;
}
    

