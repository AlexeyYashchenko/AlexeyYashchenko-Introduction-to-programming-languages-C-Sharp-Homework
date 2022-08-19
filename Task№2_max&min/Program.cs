// Факультет: Разработчик  Студент: Ященко Алексей
// Задача №2: Написать программу,которая на вход принимает два числа 
//            и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (b > a)
{ 
    Console.Write("Большее число второе = ");
    Console.WriteLine(b);
    Console.Write("Меньшее число первое = ");
    Console.WriteLine(a);
}
else
{
   Console.Write("Большее число первое = ");
   Console.WriteLine(a);
   Console.Write("Меньшее число второе = ");
   Console.WriteLine(b);
}