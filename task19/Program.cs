// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{
    CheckNumberOnPalindrome(number);
}
else Console.WriteLine("Введено не пятизначное число. Правильный формат ввода - пятизначное число. Пример: 12345");

void CheckNumberOnPalindrome(int num)
{
    int getFifthDigit = num % 10; // 12345 % 10 = 5
    int getFourthDigit = (num / 10) % 10; // 12345 / 10 = 4
    int getSecondDigit = (num / 1000) % 10; // 12345 / 100 = 2
    int getFirstDigit = (num / 1000) / 10; // 12345 / 100 = 1 
    if (getFirstDigit == getFifthDigit && getSecondDigit == getFourthDigit)
    {
        Console.WriteLine($"Пятизначное число {num} является палиндромом ");
    }
    else
    {
        Console.WriteLine($"Пятизначное число {num} не является палиндромом ");
    }
}




