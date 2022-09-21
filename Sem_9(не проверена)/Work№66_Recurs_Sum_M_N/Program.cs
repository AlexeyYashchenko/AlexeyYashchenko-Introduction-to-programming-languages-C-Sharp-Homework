// Задача №66: Задать значения М и N. Написать программу, которая найдет сумму натуральных
//             эл-тов в промежутке от М до N.

int NumberSum(int a, int b)
{
    if (b == a) return a;
    else return b + NumberSum(a, b - 1);
}

Console.WriteLine("Введите число M: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int end = int.Parse(Console.ReadLine());

Console.WriteLine($"Sum of numbers from {start} to {end} = {NumberSum(start, end)}");