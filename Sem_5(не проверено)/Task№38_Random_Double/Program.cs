// Задача №38 Задать массив вещественных чисел. Найти разницу между макисмальным и минимальным
//            элементом массива.

double[] GetArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        int b = new Random().Next(-1000000, 1000001);
        double c = new Random().Next(1, 1001);
        res[i] = b / c;
    }
    return res;
}

double GetMin(double[] Array)
{
    double min = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min)
        {
            min = Array[i];
        }
    }
    return min;
}

double GetMax(double[] Array)
{
    double max = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
        {
            max = Array[i];
        }
    }
    return max;
}

Console.Write("Enter length array: ");
int lm = int.Parse(Console.ReadLine());
double[] myArray = GetArray(lm);
Console.WriteLine(String.Join(";  ", myArray));

double minimum = GetMin(myArray);
Console.WriteLine($"Minimum array element = {minimum}");

double maximum = GetMax(myArray);
Console.WriteLine($"Maximum array element = {maximum}");

Console.WriteLine($"The difference between the maximum and minimum = {maximum - minimum}");