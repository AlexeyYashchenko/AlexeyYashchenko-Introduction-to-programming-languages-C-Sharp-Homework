// Задача 56: Задать прямоугольный двумерный массив. Написать программу, которая будет 
//            находить строку с наименьшей суммой элементов. Программа считает сумму 
//      элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов

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

int[] SumRows(int[,] matrix)                // метод перевода матрицы в одном массив
{
    int[] sumRowArr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum = sum + matrix[i, j];
            }
        }
        sumRowArr[i] = sum;
    }
    return sumRowArr;
}

int MinRow(int[] arr2)   // метод поиска  строки с мин суммой эл
{
    int min = arr2[0];
    int index = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] < min)
        {
            min = arr2[i];
            index = i;
        }
    }
    return index;
}

int[,] myArray = GetArray(5, 7, -10, 10);
PrintArray(myArray);
Console.WriteLine();

int[] sumRowArray = SumRows(myArray);
Console.Write($"The Sum of the elements in each row : {String.Join(" ", sumRowArray)}");
Console.WriteLine();

int res = MinRow(sumRowArray);
Console.WriteLine($"Row number with the smallest sum of elements = {res}");