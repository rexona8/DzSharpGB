// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.

int ReadInt(string msg)
{
    System.Console.Write($"{msg}");
    return System.Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

void OddSumNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    System.Console.WriteLine($"Сумма чисел на нечётных позициях равна: {sum}");
}

int len = ReadInt("Введите число: ");
int min = ReadInt("Введите минимальную границу: ");
int max = ReadInt("Введите максимальную границу: ");
int[] array = CreateArray(len, min, max);
PrintArray(array);
OddSumNumbers(array);