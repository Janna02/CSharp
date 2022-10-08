// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x1 первой точки");
Console.Write("x1: ");
int xc1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y1 первой точки");
Console.Write("y1: ");
int yc1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z1 первой точки");
Console.Write("z1: ");
int zc1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координату x2 второй точки");
Console.Write("x2: ");
int xc2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y2 второй точки");
Console.Write("y2: ");
int yc2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z2 второй точки");
Console.Write("z2: ");
int zc2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Distance(xc1, yc1, zc1, xc2, yc2, zc2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между первой и второй точкой  = {distance}");

double Distance(int x1, int  y1, int  z1, int x2, int  y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}


