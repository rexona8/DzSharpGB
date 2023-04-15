// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

System.Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
 
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
System.Console.WriteLine($"Пересечение точек: {x}; {y}");