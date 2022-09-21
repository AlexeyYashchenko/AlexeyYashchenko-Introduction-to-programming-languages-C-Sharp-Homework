// Задача №54: Задать двумерный массив. Написать программу, которая упорядочит по убыванию
//             эл-ты каждой строки двумерного массива.

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

void BubbleMethod(int[,] newArr)
{
    int row = newArr.GetLength(0);
    int column = newArr.GetLength(1);

    for (int k = 0; k < row; k++)
        for (int i = 0; i < column - 1; i++)
        {
            int max = i;
            for (int j = i + 1; j < column; j++)
            {
                if (newArr[k, j] > newArr[k, max])
                    max = j;
            }
            int temp = newArr[k, i];
            newArr[k, i] = newArr[k, max];
            newArr[k, max] = temp;
        }
}

int[,] myArray = GetArray(5, 7, -100, 100);
PrintArray(myArray);
Console.WriteLine();

BubbleMethod(myArray);
PrintArray(myArray);