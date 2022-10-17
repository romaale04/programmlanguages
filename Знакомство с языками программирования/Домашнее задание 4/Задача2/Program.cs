// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumDigits(int Number)
{
    if (Number < 0) 
    {
        Number = -Number;
    } 
    int sum = 0;
    while (Number > 0)
    {
        sum = sum + Number % 10;
        Number = Number / 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int SumDig = SumDigits(a);
Console.WriteLine($"Сумма цифр числа {a} равна {SumDig}");


