// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

int ReadInt(string message)
{
    System.Console.Write(message);
    return System.Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int cols)
{
    int[,] arr = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
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

void СompositionMatrix(int[,] array1, int[,] array2, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int n = 0; n < array1.GetLength(1); n++)
      {
        sum += array1[i,n] * array2[n,j];
      }
      resultArray[i,j] = sum;
    }
  }
}

int rows = ReadInt("Введите кол-во строк 1-й матрицы: ");
int cols1 = ReadInt("Введите кол-во столбцов 1-й матрицы (и строк 2-й): ");
int cols2 = ReadInt("Введите кол-во столбцов 2-й матрицы: ");
int[,] firstMatrix = Create2DArray(rows, cols1);
System.Console.WriteLine("Первая матрица:");
Print2DArray(firstMatrix);
int[,] secomdMatrix = Create2DArray(rows, cols2);
System.Console.WriteLine("Вторая матрица:");
Print2DArray(secomdMatrix);
int[,] resultMatrix = new int[rows,cols2];
СompositionMatrix(firstMatrix, secomdMatrix, resultMatrix);
System.Console.WriteLine("Произведение первой и второй матриц:");
Print2DArray(resultMatrix);