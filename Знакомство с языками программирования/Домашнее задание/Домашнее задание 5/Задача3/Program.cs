// Задача 3
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = {1, 5, 1.1, 3.7, 7.9};
double max = Max(array, array.Length);
double min = Min(array, array.Length);
Printer(array, max, min);

double Max(double [] arr, int len)
{
    double max = arr[0];

    for (int i = 0; i < len; i++)
    {
        if(max < arr[i])
        {
            max = arr[i];
        }
    }
    return max;
}

double Min(double [] arr, int len)
{
    double min = arr[0];
    for (int i = 0; i < len; i++)
    {
        if(min > arr[i])
        {
            min = arr [i];
        }
    }
    return min;
}

void Printer (double[] arr1, double max, double min)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"{arr1[i]} ");
    }
    Console.Write($"Разница между max и min: {max - min} ");
}

