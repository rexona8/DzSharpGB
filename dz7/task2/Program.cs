// Задача 2: Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

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

int rows = ReadInt("Введите кол-во строк: ");
int cols = ReadInt("Введите кол-во столбцов: ");
int[,] array = Create2DArray(rows, cols);
Print2DArray(array);
int rowsPos = ReadInt("Введите запрашиваемую строку: ");
int colsPos = ReadInt("Введите запрашиваемый столбец: ");
if (rowsPos <= array.GetLength(0) && colsPos <= array.GetLength(1))
{
    Console.WriteLine
    ($"Значение элемента в заданной позиции равно: {array[rowsPos - 1, colsPos - 1]}");
}
else
{
    Console.WriteLine($"{rowsPos} строка, {colsPos} столбец, такой позиции в массиве нет");
}