// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

int ReadInt(string message)
{
    System.Console.Write(message);
    return System.Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int cols)
{
    int[,] arr = new int[rows, cols];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
        }
    }
    return arr;
}

void Print2DArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write($"{massive[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void PrintAverageArr(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            sum += massive[i, j];
        }
        System.Console.Write($"{sum / massive.GetLength(0)}\t");
    }
    System.Console.WriteLine();
}

int rows = ReadInt("Введите кол-во строк: ");
int cols = ReadInt("Введите кол-во столбцов: ");
int[,] array = Create2DArray(rows, cols);
System.Console.WriteLine();
Print2DArray(array);
System.Console.WriteLine();
PrintAverageArr(array);