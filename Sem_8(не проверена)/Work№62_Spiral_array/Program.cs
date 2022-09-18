// Задача №62: Написать программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralArray(int m, int n)
{
    int[,] array = new int[m, n];
    int value = 1;
    
    for (int perimetr = 0; perimetr < n - 2; perimetr++) 
    {
        int row = array.GetLength(0);
        int column = array.GetLength(1);
        for (int j = 0 + perimetr; j < n - perimetr; j++)
        {
            array[0 + perimetr, j] = value++;
        }
        for (int i = 1 + perimetr; i < m - perimetr; i++)
        {
            array[i, column - 1 - perimetr] = value++;
        }
        for (int j = column - 2 - perimetr; j > 0 + perimetr; j--)
        {
            array[row - 1 - perimetr, j] = value++;
        }
        for (int i = row - 1 - perimetr; i > 0 + perimetr; i--)
        {
            array[i, 0 + perimetr] = value++;
        }
    }
    return array;
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

Console.Write("Enter the number rows = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the number columns = ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = SpiralArray(m,n);
PrintArray(myArray);
Console.WriteLine();