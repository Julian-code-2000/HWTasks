// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве: AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

 Console.WriteLine("Введите координату X1 ");
int nX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1 ");
int nY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1 "); 
int nZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X2 ");
int nX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2 ");
int nY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2 ");
int nZ2 = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(nX1, nX2, nY1, nY2, nZ1, nZ2);
Console.WriteLine($"Растояние: {result}");

double FindDistance( int x1, int x2, int y1 , int y2, int z1 ,int z2)
{
    int cat1 = x1-x2;
    int cat2= y1- y2;
    int cat3= z1- z2;
    
    double dist  = Math.Sqrt((cat1*cat1)+(cat2*cat2)+(cat3*cat3));
    dist=  Math.Round( dist, 2, MidpointRounding.ToZero);
    return  dist;
}