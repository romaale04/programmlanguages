// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int m, int n)
{
    if (m < n)
    {
        return ;
    }

    System.Console.Write(m + " ");
    PrintNumbers(m + 1, n);
}

int NatNum(int num)
{
    if (num > m && num < n)
    {
        return NatNum (num % 2 == 0);
    }
return 0;
    

}

int m = Prompt("Введите число m: ");
int n = Prompt("Введите число n: ");
PrintNumbers(NatNum);
