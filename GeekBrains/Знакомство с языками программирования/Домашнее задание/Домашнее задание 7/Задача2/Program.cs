// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int InputNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ??"0");
    return number;
}

int[,] RandomMatrixFill(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
        
    } 
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
        
    } 
    
}

bool SearchNumberInMatrix(int index1, int index2, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[index1, index2] == array [i, j])
            {
            Console.WriteLine(array [i, j]);
            return true;
               
            } 
        }
    }
    return false;
}

int firstNumber = InputNumber("Введите количество строк: ");
int secondNumber = InputNumber("Введите количество столбцов: ");

Console.WriteLine();

int[,] myMatrix = RandomMatrixFill(firstNumber, secondNumber);
PrintMatrix(myMatrix);

Console.WriteLine("Индексы начинаются с нуля!");

int rows = InputNumber("Введите искомый индекс сторок: ");
int columns = InputNumber("Введите искомый индекс столбцов:: ");

if (rows > myMatrix.GetLength(0) - 1 | columns > myMatrix.GetLength(0) - 1)
{
    Console.WriteLine($"\n[{rows}, {columns}] -> Числа по заданному адресу не существует");

}
else
{
    Console.Write($"[{rows}, {columns}] -> ");
    SearchNumberInMatrix(rows, columns, myMatrix);
}