// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

bool ArrayControl (int[,] firstArray, int[,] secondArray) // Проверка возможности условия произведения матриц
{
    if (firstArray.GetLength(1) == secondArray.GetLength(0))
    {
        return true;
    }
    return false;
}

int [,] MatrixProizv(int[,] firstArray, int[,] secondArray) // Произведение матриц
{
    int max = 0; 
       if (firstArray.GetLength(0) > secondArray.GetLength(1))
       {
        max = firstArray.GetLength(0);
       }
       else
       {
        max = secondArray.GetLength(1);
       }
       int[,] array = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
       for (int i = 0; i < firstArray.GetLength(0); i++)
       {
        for (int n = 0; n < max; n++)
        {
            int sum = 0;
            for (int j = 0; j < firstArray.GetLength(1); j++)
            {
                sum = sum + firstArray[i, j] * secondArray[j,n];
                array[i,n] = sum;
            }
        }
       }
    return array;
}
    
int line = Prompt("Введите число строк в матрице 1: ");
int column = Prompt("Введите число столбцов в матрице 1: ");
int[,] firstArray = NewArray(line, column); 
PrintMultiArray(firstArray); 
System.Console.WriteLine();
int secline = Prompt("Введите число строк в матрице 2: ");
int seccolumn = Prompt("Введите число столбцов в матрице 2: ");
int[,] secondArray = NewArray(secline, seccolumn); 
PrintMultiArray(secondArray); 
System.Console.WriteLine();
if(ArrayControl(firstArray, secondArray))
{
    System.Console.WriteLine("Произведение двух матриц:");
    PrintMultiArray(MatrixProizv(firstArray, secondArray));
}
else
{
    System.Console.WriteLine("Произведение невозможно");
}