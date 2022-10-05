// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{

    int secondDigitStepOne = num / 10; // 456 : 10 = 45
    int secondDigitStepTWo = secondDigitStepOne % 10; // 45 % 10 = 5
    return secondDigitStepTWo;

}

if (number < 100 || number > 999)
{
    Console.WriteLine("Ввели не трехзначное число");
}
else
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра введенного трехзначного числа = {secondDigit}");
}








