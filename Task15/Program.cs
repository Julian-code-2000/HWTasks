// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число сотвествующее дню недели");
string numberDay = Console.ReadLine();
DaysWeek(numberDay);
DaysOff(numberDay);

void DaysOff(string day)
{
    if (day == "6")
    {
        Console.WriteLine("ВЫХОДНОЙ");
    }
    else if (day == "7")
    {
        Console.WriteLine("ВЫХОДНОЙ");
    }
}
void DaysWeek(string day)

{
    if (day == "1")
    {
        Console.WriteLine("Понедельник");
    }
    else if (day == "2")
    {
        Console.WriteLine("Вторник");
    }
    else if (day == "3")
    {
        Console.WriteLine("Среда");
    }
    else if (day == "4")
    {
        Console.WriteLine("Четверг");
    }
    else if (day == "5")
    {
        Console.WriteLine("Пятница");
    }
    else if (day == "6")
    {
        Console.WriteLine("Суббота");
    }
    else if (day == "7")
    {
        Console.WriteLine("Воскресенье");
    }
    else
    {
        Console.WriteLine("Число НЕ СООТВЕТСТВУЕТ дню недели");
    }
}