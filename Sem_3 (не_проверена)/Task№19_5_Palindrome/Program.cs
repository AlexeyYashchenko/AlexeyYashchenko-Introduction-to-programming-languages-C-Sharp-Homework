// Задача №19: Написать программу, которая принимает на вход 5-ти значное число
//             и проверяет, является ли оно полиндромом.
Console.Write("Enter five-digit muber = ");
int N = int.Parse(Console.ReadLine());

int n1 = N % 10;
int n2 = N / 10 % 10;
int n4 = (N / 1000 - n1 * 10) % 10;
int n5 = N / 10000;

if (n1 == n5 && n2 == n4)
    Console.WriteLine($"{N} is PALINDROME");
else
{
    Console.WriteLine($"{N} isn`t palindrome");
}