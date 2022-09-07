// Задача №34 Задать массив, заполненный случайными положительными трехзначными числами. 
//            Написать программу, которая покажет количество четных чисел в массиве.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int[] EvenSum(int[] array)
{
    int[] count = new int[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count[0] += 1;
        }
    }
    return count;
}
Console.Write("Enter length array: ");
int lm = int.Parse(Console.ReadLine());

int[] myArray = GetArray((lm), 100, 999);
int[] result = EvenSum(myArray);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine($"Number of even numbers = {String.Join(" ", result)}");                                                                //выводим сумму полож 