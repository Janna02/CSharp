// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели (от 1 до 7 включительно): ");
int number = Convert.ToInt32(Console.ReadLine());

int DecideDayOfWeek(int number)
{
    if (number == 6 || number == 7)
        Console.WriteLine("День является выходным");
    else if (number >= 1 && number <= 5)
        Console.WriteLine("День не является выходным");
    else
        Console.WriteLine("Неправильно набран номер дня недели, правильный формат в диапазоне от 1 до 7 включительно ");
    return number;
}
int decideDayOfWeek = DecideDayOfWeek(number);