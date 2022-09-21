// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] mat1, int[,] mat2)
{
    int[,] result = new int[mat1.GetLength(0), mat2.GetLength(1)];

    for (int i = 0; i < mat1.GetLength(0); i++)
    {
        for (int j = 0; j < mat2.GetLength(1); j++)
        {
            for (int k = 0; k < mat2.GetLength(0); k++)
            {
                result[i, j] += mat1[i, k] * mat2[k, j];
            }
        }
    }
    return result;
}
Console.Write("Enter the number rows matrix1 = ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number columns matrix1 = ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Enter the number rows matrix2 = ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number columns matrix2 = ");
int n2 = int.Parse(Console.ReadLine());


if (n1 != m2) Console.WriteLine("Matrices cannot be multiplied");
else
{
    int[,] myArray1 = GetArray(m1, n1, -10, 10);
    int[,] myArray2 = GetArray(m2, n2, -10, 10);

    PrintArray(myArray1);
    Console.WriteLine();
    PrintArray(myArray2);
    Console.WriteLine();

    int[,] resUmn = MatrixMultiplication(myArray1, myArray2);
    PrintArray(resUmn);
    Console.WriteLine();
}