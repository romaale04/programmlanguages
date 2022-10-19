// Задача *: Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных).
// Задача 1
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray() 
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
      array [i] = new Random().Next(100,1000);
      
    }
    return array;
}

void PrintArray(int [] array)

{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
            Console.WriteLine($"{array[i]}");
        }
       
       else {Console.WriteLine($"{array[i]}");}
    }

Console.WriteLine($"Четных чисел в массиве: {count}");
}

int [] arr = CreateArray();
PrintArray(arr);