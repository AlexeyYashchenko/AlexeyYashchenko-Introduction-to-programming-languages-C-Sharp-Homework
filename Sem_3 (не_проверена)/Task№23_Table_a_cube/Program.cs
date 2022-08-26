// Задача №23 Написать программу, которая принимает на вход число N и выдаёт 
//            таблицу кубов чисел от 1 до числа N

Console.Write("Enter N = ");
int N = int.Parse(Console.ReadLine());

int count = 1;

while (count <= N)
{
    Console.Write($"{Math.Pow(count,3)} "); // Я РЕШИЛ БЕЗ double, ЭТО ПРАВИЛЬНОЕ РЕШЕНИЕ ?
    count++;
}
Console.WriteLine();
for (int i=1; i <= N; i++)
{
    Console.Write($"{i*i*i} ");
}
Console.WriteLine();