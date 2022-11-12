// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int Prompt(string message) // Ввод числа с клавиатуры
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void PrintMultiArray(int[,] arr)  // Печать многомерного массива
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            System.Console.Write($"{arr[i, j]}");
        }
        System.Console.WriteLine();
    }
}

int[,] NewArray(int line, int col)  // создание нового массива из случайных чисел
{
    int[,] newarray = new int[line, col];
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(0); j++)
        {
            newarray[i, j] = new Random ().Next(1, 10); 
        }
    }
    return newarray;
}

int[,] SortedArray (int[,] arr) // Сортирует строки массива по убыванию
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int index = 0; index < arr.GetLength(1); index++)
        {
            int max = arr[i, index];
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < max)
                {
                    max = arr[i, j];
                    arr[i, j] = arr[i, index];
                    arr[i, index] = max;
                }
            }
        }
    }
    return arr;
}

int line = Prompt("Введите число строк в массиве: ");
int column = Prompt("Введите число столбцов в массиве: ");
int[,] newarray = NewArray(line, column); // Сортируем новый массив
PrintMultiArray(newarray); // Выводим новый массив
int[,] sortedArray = SortedArray(newarray); // Сортируем новый массив
System.Console.WriteLine();
System.Console.WriteLine("Массив случайных чисел: ");
System.Console.WriteLine();
System.Console.WriteLine("массив с упорядоченными по убыванию элементами каждой строки: ");
PrintMultiArray(sortedArray); // Сортируем массив