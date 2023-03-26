// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(System.Console.ReadLine());

if (a < b)
{
    System.Console.WriteLine($"a = {a}; b = {b} -> max = {b}, min = {a}");
}
else if (a > b)
{
    System.Console.WriteLine($"a = {a}; b = {b} -> max = {a}, min = {b}");
}
else
{
    System.Console.WriteLine("Числа равны");
}