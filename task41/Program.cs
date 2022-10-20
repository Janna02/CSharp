// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел");
Console.Write("M = ");
int[] arr = new int[int.Parse(Console.ReadLine())];

void ReadNumbers(int[] array)
{
    Console.WriteLine("Введите числа: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
}

int CountNumbersMoreThanZero(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

ReadNumbers(arr);
int count = CountNumbersMoreThanZero(arr);
Console.WriteLine($"Количество чисел больше нуля среди введенных :");
PrintArray(arr);
Console.WriteLine($" -> {count}");





