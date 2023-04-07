// Задача 2: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе. Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    System.Console.Write($"{message}");
    return System.Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        int rightSide = num % 10;
        result = result + rightSide;
        num = num / 10;
    }
    return result;
}

bool NegativeNumber(int negative)
{
    if (negative < 0)
    {
        System.Console.WriteLine("Число отрицательное");
        return false;
    }
    return true;
}

int number = ReadInt("Введите число: ");
if (NegativeNumber(number))
{
    System.Console.WriteLine($"Сумма цифр числа {number} равна {SumNumbers(number)}");
}