// Факультет: Разработчик           Студент: Ященко Алексей
// Задача №4: Написать программу,которая принимает на вход три числа 
//            и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число из трех введенных чисел = ");
Console.WriteLine(max);