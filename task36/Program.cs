// Задайте одномерный массив, заполненный случайными числами.
//   Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    var array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumOddPositionOfElem(int[] array)
{
    int sumOddPositionOfElem = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sumOddPositionOfElem += array[i];
    }
    return sumOddPositionOfElem;
}

int[] arr = CreateArrayRndInt(4, -99, 100);
PrintArray(arr);
int result = SumOddPositionOfElem(arr);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях -> {result}");