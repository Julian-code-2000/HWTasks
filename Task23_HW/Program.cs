// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


string Table(int n)
{
string tResult = "________________\n";
for (int i = 1; i <= n; i++)
{
tResult = tResult + $"|{i} | {i *i*i}| \n";
}
tResult =tResult+ "______________________";

return tResult;
}

Console.Write("Введи число N:");
int number = Convert.ToInt32(Console.ReadLine());

string result = Table(number);
Console.Write(result);

