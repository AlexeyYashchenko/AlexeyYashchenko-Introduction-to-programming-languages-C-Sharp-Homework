// Задача*: Разобраться с алгоритмом сортировки методом пузырька. 
//          Реализовать невозрастающую сортировку

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void BubbleMethod(int[] newArr)
{
    for (int i = 0; i < newArr.Length - 1; i++)
    {
        int max = i;
        for (int j = i + 1; j < newArr.Length; j++)
        {
            if (newArr[j] > newArr[max])
                max = j;
        }
        int temp = newArr[i];
        newArr[i] = newArr[max];
        newArr[max] = temp;
    }
}

void PrintArray(int[] newArr)
{
    int count = newArr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{newArr[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Enter length array: ");
int lm = int.Parse(Console.ReadLine());
int[] myArray = GetArray((lm), -999, 999);
Console.WriteLine(String.Join(" ", myArray));

BubbleMethod(myArray);
PrintArray(myArray);