// Задача 2
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Printer(CreateArray(4));

int[] CreateArray(int len) 
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        int rand = new Random().Next(0, 1000);
        array [i] = rand;
      
    }
    return array;
}

void Printer(int [] array)

{
    
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (i%2 != 0)
       {
        sum = sum + array[i];
       }
        Console.WriteLine($"{array[i]} ");
    }
    
    Console.Write($"Сумма элементов, стоящих на нечётных позициях равна {sum} ");
} 


