// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] GetCount(int size, int minValue, int maxValue) // создали функцию
{
    int[] res = new int[size];   // создали пустой масив
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetCount(8, 100, 999);
int count = 0;

foreach (int el in array)
{
    if (el % 2 == 0) count++;
}

Console.WriteLine($"\nКоличество чётных чисел = {count}");