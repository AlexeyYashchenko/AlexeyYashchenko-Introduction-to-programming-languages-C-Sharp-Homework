// Задача №10. Написать программу, которя принимает на вход трехзначное число
// и на выходе показывает вторую чифру числа.
Console.Write("Enter three-digit number = ");
int number = int.Parse(Console.ReadLine());

if (number <0 ) number = number * -1;
 
int a2 = number / 10; 
int newNum = a2%10;

Console.WriteLine($"Second digit of the number = {newNum}");