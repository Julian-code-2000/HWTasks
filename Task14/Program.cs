// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.WriteLine("Введите  число");
int number1 = Convert.ToInt32(Console.ReadLine());
bool result = MultipleToNumbers(number1, 7, 23);

Console.WriteLine(result ? "Число кратно" : "Число не кратно");

bool MultipleToNumbers(int numb, int secNumb, int firNumb)

{
    return numb % secNumb == 0 && numb % firNumb == 0;
}




