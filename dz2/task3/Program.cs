// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

int PrintDayoftheWeek(string message)
{
    System.Console.Write($"{message}");
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int day = PrintDayoftheWeek("Введите день недели: ");

if (day == 6 || day == 7)
{
    System.Console.WriteLine("Является выходным днём");
}
else if (day == 1 || day == 2)
{
    System.Console.WriteLine("Не является выходным днём");
}
else if (day == 3 || day == 4)
{
    System.Console.WriteLine("Не является выходным днём");
}
else if (day == 5)
{
    System.Console.WriteLine("Не является выходным днём");
}
else
{
    System.Console.WriteLine("Такого дня недели не существует");
}


// Другой вариант решения:
// if (day == 1)
// {
//     System.Console.WriteLine("Понедельник - является будним днём");
// }
// else if (day == 2)
// {
//     System.Console.WriteLine("Вторник - является будним днём");
// }
// else if (day == 3)
// {
//     System.Console.WriteLine("Среда - является будним днём");
// }
// else if (day == 4)
// {
//     System.Console.WriteLine("Четверг - является будним днём");
// }
// else if (day == 5)
// {
//     System.Console.WriteLine("Пятница - является будним днём");
// }
// else if (day == 6)
// {
//     System.Console.WriteLine("Суббота - является выходным днём");
// }
// else if (day == 7)
// {
//     System.Console.WriteLine("Воскресение - является выходным днём");
// }
// else
// {
//     System.Console.WriteLine("Такого дня недели не существует");
// }