// Задача №30. Написать программу, которая задает массив из N элементов, 
//             заполненных случайными числами из [a,b) и выводит их на экран.
int[] RanArray(int N, int a, int b)
{
int[] rarray = new int[N];
    for (int i = 0; i < rarray.Length; i++)
    {
        rarray[i] = new Random().Next(a, b);
    }
    return rarray;
}
Console.Write("Enter the number of elements in the array, N = ");
int numN = int.Parse(Console.ReadLine());
Console.Write("Enter start of array, a = ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Enter end of array, b = ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine(String.Join(", ", RanArray(numN, numA, numB)));