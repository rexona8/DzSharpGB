// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный
// случайными числами. Оформите заполнение массива и вывод в виде функции 
// (пригодится в следующих задачах).  Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//  -> 8

int ReadInt(string message)
{
    System.Console.Write($"{message}");
    return System.Convert.ToInt32(Console.ReadLine());
}

int[] PrintArray(int randLen)
{
    int[] randArray = new int[randLen];
    for (int i = 0; i < randArray.Length; i++)
    {
        randArray[i] = new Random().Next(1, 9);
        Console.Write(randArray[i] + " ");
    }
    return randArray;
}

bool MinMaxArrayLen(int numbers)
{
    if (numbers > 8)
    {
        System.Console.WriteLine("Больше 8 элементов в массиве");
        return false;
    }
    if (numbers < 3)
    {
        System.Console.WriteLine("Меньше 3 элементов в массиве");
        return false;
    }
    return true;
}

int lenArray = ReadInt("Введите длинну массива: ");
if (MinMaxArrayLen(lenArray))
{
    System.Console.WriteLine(PrintArray(lenArray));
}