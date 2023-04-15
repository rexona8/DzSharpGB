// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.

int ReadInt(string msg)
{
    System.Console.Write($"{msg}");
    return System.Convert.ToInt32(Console.ReadLine());
}

void EnteringNumbersAboveZero(int[] numbers)
{
    int[] array = new int[ReadInt("Введите колличество элементов: ")];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt("Введите число: ");
        if (array[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Колличество чисел больше нуля составляет {count}");
}

int[] array = new int[5];
EnteringNumbersAboveZero(array);