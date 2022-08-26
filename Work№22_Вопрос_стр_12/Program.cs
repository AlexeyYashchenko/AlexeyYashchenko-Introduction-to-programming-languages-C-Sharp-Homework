// Задача №22 Напишите программу, которая принимает на вход число N и выдает 
//            квадраты чисел от 1 до числа N

Console.Write("Enter N = ");
int N = int.Parse(Console.ReadLine());

if (N<0)   N = -N;
int count = 1;

while (count <= N)
{
    Console.Write($"{Math.Pow(count,2)} "); // Я РЕШИЛ БЕЗ double, ЭТО ПРАВИЛЬНОЕ РЕШЕНИЕ ?
    count++;
}
    // var 2
    // double kvadrat =  Math.Pow((count),2);
    // Console.Write($"{kvadrat} ");
    