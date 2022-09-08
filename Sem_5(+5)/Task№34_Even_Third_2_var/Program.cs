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
// var 1                                            // через массив из 1-го эл-та
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

//var 2                             // через int
// int EvenSum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count ++;
//         }
//     }
//     return count;
// }

Console.Write("Enter length array: ");
int lm = int.Parse(Console.ReadLine());

int[] myArray = GetArray((lm), 100, 999);
Console.WriteLine(String.Join(" ", myArray));

//var 1
int [] result = EvenSum(myArray);
//var 2
// int result = EvenSum(myArray);

//var 1
Console.WriteLine($"Number of even numbers = {String.Join(" ", result)}");  
// var2
// Console.WriteLine($"Number of even numbers = {result}");                                                       //выводим сумму полож 