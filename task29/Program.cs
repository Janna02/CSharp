//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Массив из 8 элементов, заполненный случайными числами от 0 до 99 : ");

int[] FillArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[{0}]", string.Join(", ", arr));
}

int[] myArr = FillArray(8);
PrintArray(myArr);
