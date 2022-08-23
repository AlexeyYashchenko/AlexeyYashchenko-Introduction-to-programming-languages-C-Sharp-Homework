// Задача №13. Написать программу, которя выводит третью цифру (справа налево) заданного число,
// или сообщает, что третьей цифры нет.
Console.Write("Enter number = ");
int number = int.Parse(Console.ReadLine());

if (number < 0) number = number * -1;

int a = number / 100;
if (a > 0)
{
    int newNum = a % 10;
    Console.WriteLine($"Third digit of the number = {newNum}");
} 
  else
{
    Console.WriteLine("Number does not have a third digit");
}