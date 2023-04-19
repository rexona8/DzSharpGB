// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

int ReadInt(string message)
{
    System.Console.Write(message);
    return System.Convert.ToInt32(Console.ReadLine());
}

double[,] Create2DArray(int rows, int cols)
{
    double[,] array = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.Next(1, 101) * 0.1, 1);
        }
    }
    return array;
}

void Print2DArray(double[,] massive)
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

int rows = ReadInt("Введите кол-во строк: ");
int cols = ReadInt("Введите кол-во столбцов: ");
double[,] arr = Create2DArray(rows, cols);
Print2DArray(arr);