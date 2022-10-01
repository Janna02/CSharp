// Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Большее число это {number1}");
    Console.WriteLine($"Меньшее число это {number2}");
    Console.WriteLine($"Max= {number1}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Большее число это {number2}");
    Console.WriteLine($"Меньшее число это {number1}");
    Console.WriteLine($"Max= {number2}");
}
else 
{
    Console.WriteLine("Числа равны");
}

