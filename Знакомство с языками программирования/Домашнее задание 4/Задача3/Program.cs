// Задача 3: Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8

int[] CreateArray() 
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
      array [i] = new Random().Next(0,21);
      
    }
    return array;
}

void PrintArray(int [] array)

{
    for (int i = 0; i < array.Length; i++)
    {
       
        Console.WriteLine($"{array[i]}");
    }
} 

int [] arr = CreateArray();
PrintArray(arr);