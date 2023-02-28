// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int len, int maxValue)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Sum(int[] array)
{
    int sum = 0;
    int index = 1;
    while (index < array.Length)
    {
        sum += array[index];
        index += 2;
    }
    return sum;
}

Console.Write("Введите количество чисел в массиве: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение числа в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = FillArray(len, maxValue);
PrintArray(myArray);
int sum = Sum(myArray);
Console.WriteLine($"Сумма чисел с нечетными индексами равна: {sum}");