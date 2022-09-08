// Задача №36 Задать одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечетных позициях.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int[] SumOdd(int[] array)
{
    int[] count = new int[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            count[0] += array[i];
        }
    }
    return count;
}
Console.Write("Enter length array: ");
int lm = int.Parse(Console.ReadLine());
int[] myArray = GetArray((lm), -1000, 1000);
Console.WriteLine(String.Join(" ", myArray));

int[] result = SumOdd(myArray);
Console.WriteLine($"Sum of odd index numbers = {String.Join(" ", result)}");