// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

int SecondNumber(int num)
{
    int rightNumber = num % 100;
    int result = rightNumber / 10;
    return result;
}

int PrintNumber(string message)
{
    System.Console.Write($"{message}");
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int number = PrintNumber("Введите число: ");

if (number < 999 && number > 10)
{
    System.Console.Write($"Вторая цифра от {number} будет {SecondNumber(number)}");
}
else
{
    System.Console.WriteLine("Число не трёхзначное");
}