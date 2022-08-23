// Факультет: Разработчик  Студент: Ященко Алексей
// Задача №8: Написать программу,которая на вход принимает число (N),
//            на выходе показывает все четные числа от 1 до N.

Console.Write("Введите число = ");
int N = int.Parse(Console.ReadLine());

int count = 0;

while (count < N-1)
{
    count +=2;
    Console.Write($"{count},");
    //Console.Write(",");
}