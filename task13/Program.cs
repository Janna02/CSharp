// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = new Random().Next();
Console.WriteLine(number);

int GetThirddDigitOfNum(int num)
{
    int counter = default;
    while (num >= 1000)
    {
        num = num / 10;
        counter++;
    }
    return num;
}

int ThirddDigit(int num)
{
    int thirdDigit = num % 10; // 645 % 10 = 5
    return thirdDigit;
}


if (number < 100)
{
    Console.WriteLine("Третьей цифры нет, число содержит меньше 3 знаков");
}
else if (number > 999)
{
    int getThirdDigitOfNum = GetThirddDigitOfNum(number);
    int thirdDigit = ThirddDigit(getThirdDigitOfNum);
    Console.WriteLine($"Третья цифра  числа = {thirdDigit}");
}
else if (number >= 100 && number <= 999)
{
    int thirdDigit = ThirddDigit(number);
    Console.WriteLine($"Третья цифра  числа = {thirdDigit}");
}
