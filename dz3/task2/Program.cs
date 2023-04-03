// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

int ReadInt(string message)
{
    System.Console.Write($"{message}");
    return System.Convert.ToInt32(Console.ReadLine());
}

int aX = ReadInt("Введите координату Х первой точки: ");
int aY = ReadInt("Введите координату Y первой точки: ");
int aZ = ReadInt("Введите координату Z первой точки: ");
int bX = ReadInt("Введите координату X второй точки: ");
int bY = ReadInt("Введите координату Y второй точки: ");
int bZ = ReadInt("Введите координату Z второй точки: ");

double coordX = Math.Pow((aX - bX), 2);
double coordY = Math.Pow((aY - bY), 2);
double coordZ = Math.Pow((aZ - bZ), 2);
double result = Math.Sqrt(coordX + coordY + coordZ);
System.Console.WriteLine($"Расстояние между точками в 3D равно {Math.Round(result, 2)}");