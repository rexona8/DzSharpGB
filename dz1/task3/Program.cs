// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}