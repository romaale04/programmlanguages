// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int m, int n, int sum)
{
    if (m > n)
    {
       Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");  
       return;
    }

    sum = sum + (m);
    PrintNumbers(m, n, sum);
}

int m = Prompt("Введите число m: ");
int n = Prompt("Введите число n: ");
