// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите k1 из уравнения первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2 из уравнения второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b1 из уравнения первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2 из уравнения второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] FindPointOfIntersection(double kp1, double kp2, double bp1, double bp2)
{
    double x = -(bp2 - bp1) / (kp2 - kp1);
    double y = kp1 * x + bp1;
    return new double[] { x, y };
}

void PrintArrayDouble(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(")");
}

double[] arr = FindPointOfIntersection(k1, k2, b1, b2);
Console.WriteLine($"Точка пересечения двух прямых:");
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
PrintArrayDouble(arr);



