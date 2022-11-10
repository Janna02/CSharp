// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationOfMatrix(int[,] arrOne, int[,] arrTwo)
{
    int[,] resMatrix = new int[arrOne.GetLength(0), arrTwo.GetLength(1)];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrOne.GetLength(1); k++)
            {
                sum += arrOne[i, k] * arrTwo[k, j];
            }
            resMatrix[i, j] = sum;
        }
    }
    return resMatrix;
}

int[,] firstMatrix = CreateMatrixRndInt(10, 3, 1, 3);
int[,] secondMatrix = CreateMatrixRndInt(3, 7, 1, 3);

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    Console.WriteLine("Первая матрица: ");
    PrintMatrix(firstMatrix);
    Console.WriteLine("");
    Console.WriteLine("Вторая матрица: ");
    PrintMatrix(secondMatrix);
    Console.WriteLine("");
    int[,] resMatrix = MultiplicationOfMatrix(firstMatrix, secondMatrix);
    Console.WriteLine("Результирующая матрица: ");
    PrintMatrix(resMatrix);
}
else
    Console.WriteLine("Матрицы нельзя перемножить, количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");
