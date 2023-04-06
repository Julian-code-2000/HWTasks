// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату X1 ");
int nX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X2 ");
int nX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1 ");
int nY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2 ");
int nY2 = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(nX1, nX2, nY1, nY2);
Console.WriteLine($"Растояние: {result}");

double FindDistance( int x1, int x2, int y1 , int y2)
{
    int fCat = x1-x2;
    int sCat= y1- y2;
    double dist  = Math.Sqrt((fCat*fCat)+(sCat*sCat));
    dist=  Math.Round( dist, 2, MidpointRounding.ToZero);
    return  dist;
}


