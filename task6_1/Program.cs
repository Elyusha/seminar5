// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PositiveNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.Write("Введите числа через пробел, затем нажмите Enter: ");
int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int PosNumb = PositiveNumb(num);
Console.WriteLine($"Вы ввели {PosNumb} положительных чисел.");

