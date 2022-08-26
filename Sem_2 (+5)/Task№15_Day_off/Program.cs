// Задача №15. Написать программу, которая приниает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

Console.Write("Enter a number for the day of the week = ");
int number = int.Parse(Console.ReadLine());

if ( number < 1 || number > 7) 
    Console.WriteLine("No such day of the week");

else 
   if (number >0 && number < 6)    
        Console.WriteLine("This day isn`t a day off");
    else
        Console.WriteLine("This day a day off");