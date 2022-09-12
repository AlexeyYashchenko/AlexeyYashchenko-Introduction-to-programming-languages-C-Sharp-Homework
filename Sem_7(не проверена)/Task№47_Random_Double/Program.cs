// Задача №47: Задать двумерный массив размером m x n, заполненный случ. вещественными числами.

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int b = new Random().Next(minValue, maxValue + 1);
            double c = new Random().Next(minValue, maxValue + 1);
            result[i, j] = b / c;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2} \t "); // ограничил 2 знаками после
                                                    // запятой, п.ч. получается некрасивая матрица если не ограничить
        }
        Console.WriteLine();
    }
}

Console.Write("Enter the number rows = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the number columns = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter the number min Random = ");
int min = int.Parse(Console.ReadLine());
Console.Write("Enter the number max Random = ");
int max = int.Parse(Console.ReadLine());

if (min > max)               // Если ввели неправильно, сначало большое, потом меньшее
{
    int temp = max;
    max = min;
    min = temp;
}

double[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);