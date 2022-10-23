// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[] SumOfNumOfColumn(int[,] matrix)
{
    int sumOfNum = default;
    int[] arrayOfSums = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumOfNum += matrix[i, j];
        }
        arrayOfSums[j] = sumOfNum;
        sumOfNum = 0;
    }
    return arrayOfSums;
}

double[] AverageOfNumOfColumn(int[] arrOfsum)
{
    double[] arrayOfAverageofNum = new double[arrOfsum.Length];
    for (int i = 0; i < arrOfsum.Length; i++)
    {
        double avgRes;
        avgRes = arrOfsum[i] / (double)(arrOfsum.Length);
        arrayOfAverageofNum[i] = avgRes;
    }
    return arrayOfAverageofNum;
}

void PrintAverageOfNumOfColumn(double[] arrAvgOfsum)
{
    Console.Write($"Среднее арифметическое каждого столбца : ");
    for (int i = 0; i < arrAvgOfsum.Length; i++)
    {
        if (i < arrAvgOfsum.Length - 1)
            Console.Write(Math.Round(arrAvgOfsum[i], 2, MidpointRounding.ToZero) + "; ");
        else
            Console.Write(Math.Round(arrAvgOfsum[i], 2, MidpointRounding.ToZero) + ".");
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
Console.WriteLine("Массив из целых чисел: ");
PrintMatrix(array2D);
int[] sumOfNumOfColumn = SumOfNumOfColumn(array2D);
double[] averageOfNumOfColumn = AverageOfNumOfColumn(sumOfNumOfColumn);
PrintAverageOfNumOfColumn(averageOfNumOfColumn);
