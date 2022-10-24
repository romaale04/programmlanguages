// Задача 2
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// Значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNumber(string msg)
{
    System.Console.WriteLine(msg);
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double k1 = InputNumber("Введите k1: ");
double b1 = InputNumber("Введите b1: ");
double k2 = InputNumber("Введите k2: ");
double b2 = InputNumber("Введите b2: ");

if (k1 == k2)
{
    Console.WriteLine("прямые параллельны");
}

if (b1 == b2)
{
    Console.WriteLine($"прямые пересекаются в точке (0; {b1}). ");

}

double x = (b2 - b1) / (k1 - k2);
double y = k1*x +b1;
System.Console.WriteLine($"Точка пересечения находится в точке с координатами ({x}; {y})");