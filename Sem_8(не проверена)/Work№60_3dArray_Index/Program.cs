// Задача 60. Сформировть трёхмерный массив из неповторяющихся двузначных чисел. Написать
//        программу, которая будет построчно выводить массив, добавляя индексы каждого эл-нта.

int[,,] GetThirdArray(int m, int n, int p)
{
    int[,,] result = new int[m, n, p];
    int num = 9;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                {
                    num = num + 1;          //в условии не сказано что числа д.б. случайными
                    result[i, j, k] = num;
                }
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})   ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Enter the number rows = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the number columns = ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter the number width = ");
int p = int.Parse(Console.ReadLine());

if (m * n * p < 91)    // двузначных чисел всего 90
{
    int[,,] myArray = GetThirdArray(m, n, p);
    PrintArray(myArray);
}
else Console.WriteLine("Run the program again, because there are no such number of non-repeating two-digit numbers");