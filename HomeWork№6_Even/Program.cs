﻿// Факультет: Разработчик  Студент: Ященко Алексей
// Задача №6: Написать программу,которая на вход принимает число
//            и выдает, является ли число четным.


Console.Write("Введите число = ");
int num = int.Parse(Console.ReadLine());

int result = num %2;

if (result == 0)
{
    Console.WriteLine("Введенное число является ЧЕТНЫМ");
}
else
{
    Console.WriteLine("Введенное число является НЕЧЕТНЫМ");
}