﻿// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

void EvenNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            sum++;
        }
    }
    System.Console.WriteLine($"Колличество четных чисел в массиве составляет: {sum}");
}

int len = ReadInt("Введите число: ");
int min = ReadInt("Введите минимальную границу: ");
int max = ReadInt("Введите максимальную границу: ");
int[] array = CreateArray(len, min, max);
PrintArray(array);
EvenNumbers(array);