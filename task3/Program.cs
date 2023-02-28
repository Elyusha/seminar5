// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArray(int len, int maxValue)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, maxValue + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Write("Введите количество чисел в массиве: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение числа в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = FillArray(len, maxValue);
PrintArray(myArray);
double max = FindMax(myArray);
double min = FindMin(myArray);
Console.WriteLine($"{max} - {min} = {max - min}");