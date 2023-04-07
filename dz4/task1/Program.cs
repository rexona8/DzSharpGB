// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message)
{
    System.Console.Write($"{message}");
    return System.Convert.ToInt32(Console.ReadLine());
}

int Degree(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int num1 = ReadInt("Введите 1 число: ");
int num2 = ReadInt("Введите 2 число: ");
System.Console.WriteLine($"{num1} в степени {num2} будет равняться {Degree(num1, num2)}");