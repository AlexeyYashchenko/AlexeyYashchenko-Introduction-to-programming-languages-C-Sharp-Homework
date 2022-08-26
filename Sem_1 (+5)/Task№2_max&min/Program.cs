// Факультет: Разработчик  Студент: Ященко Алексей
// Задача №2: Написать программу,которая на вход принимает два числа 
//            и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (b > a)
{
    Console.WriteLine($"Большее число второе = {b}");          // 1 вариант
    Console.WriteLine("Меньшее число первое = {0}", a);       // 2 вариант
}

if (b < a) 
{
    Console.WriteLine($"Большее число первое ={a}"); 
    Console.WriteLine($"Меньшее число второе = {b}");
   //Console.Write("Меньшее число второе = ");              //3 вариант
   //Console.WriteLine(b);
}