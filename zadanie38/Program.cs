// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] array = GetSumEven(8, 0, 99);
//PrintArray(array);


int[] GetSumEven(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int max = 0;
foreach (int el in array) if (max < el) max = el;
Console.WriteLine($"\nМаксимальное число = {max}.");
int min = max;
foreach (int el in array) if (min > el) min = el;
Console.WriteLine($"Миниимальное число = {min}.");
Console.WriteLine($"Разница между числами {max} и {min} = {max - min}.");