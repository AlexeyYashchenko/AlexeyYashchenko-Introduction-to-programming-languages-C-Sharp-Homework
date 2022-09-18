// Задача №50: Написать программу, которая на вход принимает число и генерирует случайный двумерный массив, 
//             и возвращает индексы этого элемента или же указание, что такого элемента нет.

int[,] GetArray(int m, int n, int minValue, int maxValue)  //  метод ввода
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}
void PrintArray(int[,] array)                    //метод вывода на экран
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

bool IsExist(int num, int[,] arr)       // метод есть ли число
{
    foreach (var item in arr)
    {
        if (item == num)
            return true;
    }
    return false;
}

int[] IsExist1(int num, int[,] array1)    // метод вывода индекса если есть число
{
    int[] res = new int[2];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (array1[i, j] == num)
            {
                res[0] = i;
                res[1] = j;
                return res;
            }
        }
    }
    return res;
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

Console.Write("Enter the desired number: ");
int number = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
Console.WriteLine("Random Array:");
PrintArray(myArray);

int[] result = IsExist1(number, myArray);
if (IsExist(number, myArray))
    Console.WriteLine($"Number {number} find and  Found number Index: [{String.Join(", ", result)}]");
else
    Console.WriteLine("There is no such number in a two-dimensional array");







