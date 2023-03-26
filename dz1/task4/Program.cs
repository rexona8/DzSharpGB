// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

for (int i = 1; i < number; i++)
{
    i++;
    System.Console.WriteLine(i);
}