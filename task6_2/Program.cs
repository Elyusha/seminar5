// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2) Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} совпадают.");
        else Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} параллельны (не пересекаются).");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * b2 - k2 * b1) / (k1 - k2);
        Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} пересекаются в точке ({x};{y}).");
    }

}

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
IntersectionPoint(b1, k1, b2, k2);
