// Задача 1
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


System.Console.Write("Сколько чисел ввести: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] InputNum()
{
    int lenght = quantity;
    int[] numbers = new int[lenght];
    for(int i=0; i < numbers.Length; i++)
    {
        System.Console.Write($"Введите число под №:{i+1} ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

int[] num = InputNum();

int QuantityPositive()
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int result = QuantityPositive();
System.Console.WriteLine($"Количество введенных чисел больше нуля:  {result}");