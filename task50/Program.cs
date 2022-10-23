// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] array2D = CreateMatrixRndInt(1, 3, -100, 100);

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

void ReturnValueExistPositionOfElem(int[,] arr, int row, int column)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == row && j == column)
                Console.WriteLine($"Значение элемента на позиции {(i, j)}= {arr[i, j]}");
        }
    }
}

void ReturnMessageIfWeDontHavePositon(int[,] arr, int row, int column)
{
    if (row >= arr.GetLength(0) || column >= arr.GetLength(1) || row < 0 || column < 0)
    {
        Console.WriteLine($"Элемента {(row, column)} не существует в данном массиве");
        Console.WriteLine("Возможные варианты позиций элементов: ");
        PrintMatrixIndex(arr);
    }
}


void PrintMatrixIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{i}{j} ");
            else Console.Write($" {i}{j}");
        }
        Console.WriteLine("]");
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

Console.WriteLine("Введите номер строки в которой нужно найти элемент:");
int numOfrRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца в котором нужно найти элемент:");
int numOfColumn = Convert.ToInt32(Console.ReadLine());

PrintMatrix(array2D);

ReturnValueExistPositionOfElem(array2D, numOfrRow, numOfColumn);
ReturnMessageIfWeDontHavePositon(array2D, numOfrRow, numOfColumn);


