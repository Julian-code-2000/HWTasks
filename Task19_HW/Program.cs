// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// // 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = NumbPalynodrome(number);
string resulta = result ? "число является палиндромом" : "число  НЕ вляется палиндромом";

Console.WriteLine(resulta);



bool NumbPalynodrome(int numb)
{
  
    int i = 1;
    int n1 = 0;
    int n2 = 0;
    int n4 = 0;
    int n5 = 0;
    while (i < 6)
    {
        int summ = numb % 10;
        numb = numb / 10;


        if (i == 1) n1 = summ;
        if (i == 2) n2 = summ;
        if (i == 4) n4 = summ;
        if (i == 5) n5 = summ;
        i++;
    }
    return n1 == n5 && n2 == n4;
}