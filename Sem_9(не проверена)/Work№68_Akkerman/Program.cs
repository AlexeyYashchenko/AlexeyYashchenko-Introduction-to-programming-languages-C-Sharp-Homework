// Задача №68: Написать программу вычисления функции Аккермана с помошью рекурсиию.
// Даны два неотрицательных числа m и n.

int FunctionАkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FunctionАkkerman(m - 1, 1);
    return FunctionАkkerman(m - 1, FunctionАkkerman(m, n - 1));
}
Console.WriteLine("Enter number m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"FunctionАkkerman({m}, {n}) = {FunctionАkkerman(m, n)}");