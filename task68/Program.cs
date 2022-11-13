//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int FunctionOfAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FunctionOfAckermann(m - 1, 1);
    }
    else
    {
        return FunctionOfAckermann(m - 1, FunctionOfAckermann(m, n - 1));
    }
}

if (num1 < 0 || num2 < 0)
    Console.Write("Функция Аккермана определяется рекурсивно ДЛЯ неотрицательных целых чисел m и n");
else
{
    int functionOfAckermann = FunctionOfAckermann(num1, num2);
    Console.Write("Рассчитанное значение = " + functionOfAckermann);
}
