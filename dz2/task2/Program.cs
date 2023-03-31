// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. Не использовать строки для расчета.

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}

int ThirdNumber(int x, int y)
{
int result = 0;
    if (y < 3)
    {
        Console.Write("Нет. ");
    }
    else
    {
        int z = 1;
        for (int i = y; i > 3; i--)
        {
            z = z * 10;
        }
        result = (x / z) % 10;
    }
return result;
}

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
System.Console.WriteLine($"Третья цифра в {number} будет {ThirdNumber(number, count)}");