// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
//  чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
void CubeTable(int num)
{
    int index = 1;
    Console.WriteLine($"Таблица кубов чисел от 1 до {num}");
    while (index <= num)
    {
        Console.WriteLine($"|{index,4}|{Math.Pow(index, 3),4}|");
        index++;
    }
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeTable(number);