// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    var array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 1);

    }
    return array;
}
void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindDiffOfMaxAndMinElemOfArr(double[] array)
{
    double minElem = array[0];
    double maxElem = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElem) minElem = array[i];
        else if (array[i] > maxElem) maxElem = array[i];
    }
    return maxElem - minElem;
}

double[] arr = CreateArrayRndDouble(4, 0, 100);
PrintArrayDouble(arr);
double diffMaxAndMin = FindDiffOfMaxAndMinElemOfArr(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {Math.Round(diffMaxAndMin, 1)}");





