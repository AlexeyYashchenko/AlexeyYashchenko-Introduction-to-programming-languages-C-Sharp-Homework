// Задача №51: Задать двумерный массив размером m x n, заполненный случ. целыми числами.
//   Найти сумму эл-нтов, находящихся на главной диаганали(с индексами (0,0); (1,1)и т.д.)


Console.Write("Enter the number rows = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the number columns = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter the number min Random = ");
int min = int.Parse(Console.ReadLine());
Console.Write("Enter the number max Random = ");
int max = int.Parse(Console.ReadLine());

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

int DiagonalArray(int[,] arrayDiag)
{
    if (m > n) m = n;           // ввел для того чтобы обрубать выход за рамки матрицы
    int result = 0;             // но в этом случае ввод данных нужно разместить в начале
                                // ЭТО НОРМАЛЬНО???
    for (int i = 0; i < m; i++) 
    {
        result = result + arrayDiag[i, i];
    }
    Console.WriteLine();
    return result;
}

// Console.Write("Enter the number rows = "); // ЗАКОМЕНТИРОВАЛ ПОТОМУ ЧТО ЕСЛИ m>n ТО ОШИБКУ ВЫДАЕТ
// int m = int.Parse(Console.ReadLine());
// Console.Write("Enter the number columns = ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("Enter the number min Random = ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Enter the number max Random = ");
// int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
Console.WriteLine("Random Array:");
PrintArray(myArray);

int SumElementDiagonal = DiagonalArray(myArray);
Console.WriteLine($"Sum Elements of Diagonal: {SumElementDiagonal}");