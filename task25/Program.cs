// Напишите программу, в которой на вход принимаются два числа (A и B) и возводится число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую нужно возвести число:  ");
int number1 = Convert.ToInt32(Console.ReadLine());

PrintNumberInDegree(number, number1);

double NumDegree(double num, int num1)
{
    double numDegree = 1;

    if (num1 > 0)
    {
        for (int i = 1; i <= num1; i++)
        {
            numDegree = numDegree * num;
        }
    }
    else if (num1 < 0)
    {
        for (int i = -1; i >= num1; i--)
        {
            numDegree = numDegree / num;
        }
    }
    return numDegree;
}

void PrintNumberInDegree(int num, int num1)
{
    if (number1 == 0)
        Console.WriteLine($"{num} в степени {num1} = 1");

    else
    {
        double numDegree = NumDegree(number, number1);
        Console.WriteLine($"{num} в степени {num1} = {numDegree}");
    }
}