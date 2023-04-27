// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumEvenNum(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return m + SumEvenNum(m + 1, n);
}

System.Console.Write(SumEvenNum(1, 15));