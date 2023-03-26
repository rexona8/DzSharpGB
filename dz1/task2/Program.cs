// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

System.Console.Write("Введите 1 число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите 2 число: ");
int num2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите 3 число: ");
int num3 = Convert.ToInt32(System.Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    System.Console.WriteLine($"{num1}, {num2}, {num3} -> {num1}");
}
else if (num2 > num1 && num2 > num3)
{
    System.Console.WriteLine($"{num1}, {num2}, {num3} -> {num2}");
}
else if (num3 > num1 && num3 > num2)
{
    System.Console.WriteLine($"{num1}, {num2}, {num3} -> {num3}");
}
else
{
    System.Console.WriteLine("числа равны");
}