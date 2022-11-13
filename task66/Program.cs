// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sum = default;

if (num1 < num2 && num1 > 0 && num2 > 0) SumOfNaturalNumbers(num1, num2);
else if (num2 < num1 && num1 > 0 && num2 > 0) SumOfNaturalNumbers(num2, num1);
else Console.Write("Одно из введенных чисел является  отличным от натурального.Попробуйте еще раз");

void SumOfNaturalNumbers(int m, int n)
{
    sum = sum + n;

    if (m >= n)
    {
        Console.Write($"Сумма натуральных элементов в промежутке от M до N -> {sum} ");
        return;
    }
    SumOfNaturalNumbers(m, n - 1);
}






