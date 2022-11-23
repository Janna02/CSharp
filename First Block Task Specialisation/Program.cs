// Написать программу, которая из имеющегося массива строк сформирует массив из строк , длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Задайте количество элементов в массиве: ");
int numOfrRow = Convert.ToInt32(Console.ReadLine());

string[] CreateArrayString(int num)
{
    var array = new string[num];

    for (int i = 0; i < array.Length; i++)
    {
        string row = Console.ReadLine();
        array[i] = row;

    }
    return array;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

string[] FilterArrayThreeChars(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        

    }
    return arr;
}


Console.WriteLine("Введите значение элемента массива (строку из символов): ");
string[] arrayOfRows = CreateArrayString(numOfrRow);
Console.WriteLine("Первоначальный массив: ");
PrintArray(arrayOfRows);

