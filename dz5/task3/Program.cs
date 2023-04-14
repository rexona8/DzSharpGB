// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

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

void FindDiff(int[] massive, int min, int max)
{
    int minV = massive[0];
    int maxV = massive[0];
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < minV)
        {
            minV = massive[i];
        }
        if (massive[i] > maxV)
        {
            maxV = massive[i];
        }
    }
    System.Console.WriteLine($"Разница между {maxV} и {minV} равна {maxV - minV}");
}

int len = ReadInt("Введите число: ");
int min = ReadInt("Введите минимальную границу: ");
int max = ReadInt("Введите максимальную границу: ");
int[] array = CreateArray(len, min, max);
PrintArray(array);
FindDiff(array, min, max);