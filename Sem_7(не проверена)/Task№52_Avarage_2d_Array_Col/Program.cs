// Задача №52: Задать двумерный массив из целых чисел. Найти среднее арифмитическое эл-тов
//             в каждом столбце.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

double[] AverageArray(int[,] arrayAver)
{
    double[] result = new double[arrayAver.GetLength(1)];
    for (int j = 0; j < arrayAver.GetLength(1); j++)
    {
        double count = 0;
        for (int i = 0; i < arrayAver.GetLength(0); i++)
        {
            count += arrayAver[i, j];
        }
        result[j] = count / arrayAver.GetLength(0);
    }
    return result;
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

int[,] myArray = GetArray(m, n, min, max);
Console.WriteLine("Random Array:");
PrintArray(myArray);

double[] resultAverage = AverageArray(myArray);
Console.WriteLine($"Average Columns: {String.Join(";  ", resultAverage)}");