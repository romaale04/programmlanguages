// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m, n);

void AkkermanFunction(int m, int n);
{
    Console.Write(Akkerman(m, n));
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n +1;
    }
    else if (n > 0 && m > 0)
    {
        return AkkermanFunction(m -1, AkkermanFunction(m, n - 1));
    }
    else
    {
        return AkkermanFunction(m, n)
    }
}
