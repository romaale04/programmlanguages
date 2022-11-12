// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

int StringElementsSum (int[,] arr, int str) // Считает сумму элементов заданной строки
{
    int sum = 0; 
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[str, j];
    }
    return sum;
}

int FindMinSumString (int[,] arr) // СВозвращает строку с наименьшей суммой элементов
{
    int minsum = StringElementsSum (arr, 0); 
    int minstr = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
       if (StringElementsSum(arr, i) < minsum)
       {
        minsum = StringElementsSum(arr, i);
        minstr = i;
       }
    }
    return minstr;
}

int line = Prompt("Введите число строк в массиве: ");
int column = Prompt("Введите число столбцов в массиве: ");
int[,] newarray = NewArray(line, column); // Сортируем новый массив
PrintMultiArray(newarray); // Выводим новый массив
System.Console.WriteLine();
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMinSumString(newarray)} ");
