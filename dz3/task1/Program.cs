// Задача 1: Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

int ReadInt(string message)
{
    System.Console.Write($"{message}");
    return System.Convert.ToInt32(Console.ReadLine());
}

string Palindrome(int number)
{
    int rightSide = number % 100;
    int leftSide = number / 1000;
    if (number / 10000 == rightSide % 10 && rightSide / 10 == leftSide % 10)
    {
        System.Console.Write("Является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Не является палиндромом");
    }
    return "";
}

bool CountNumbers(int count)
{
    if (count < 9999 || count > 99999)
    {
        System.Console.WriteLine("Число не пятизначное");
        return false;
    }
    return true;
}

int number = ReadInt("Введите число: ");
if (CountNumbers(number))
{
    string count = Palindrome(number);
    System.Console.WriteLine(count);
}