// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();

int[] array = GetSumEven(8, -99, 99);
PrintArray(array);


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

void PrintArray(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) res += array[i];
    }
    //Console.WriteLine();
    Console.WriteLine($"\nCумма элементов, стоящих на нечётных позициях = {res}");
}