// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] SumOfNumOfRow(int[,] matrix)
{
    int sumOfNum = default;
    int[] arrayOfSums = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfNum += matrix[i, j];
        }
        arrayOfSums[i] = sumOfNum;
        sumOfNum = 0;
    }
    return arrayOfSums;
}

int MinSumOfRow(int[] arrOfsum)
{
    int min = arrOfsum[0];
    for (int i = 0; i < arrOfsum.Length; i++)
    {
        if (arrOfsum[i] < min) min = arrOfsum[i];
    }
    return min;
}

void NumOfRowMinSum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            Console.WriteLine($"Номер строки с наименьшей суммой элементов: {i + 1} строка");
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


int[,] array2D = CreateMatrixRndInt(5, 3, 1, 10);
PrintMatrix(array2D);
int[] sumOfNumOfRow = SumOfNumOfRow(array2D);
int numOfMinSumOfRow = MinSumOfRow(sumOfNumOfRow);
NumOfRowMinSum(sumOfNumOfRow, numOfMinSumOfRow);

