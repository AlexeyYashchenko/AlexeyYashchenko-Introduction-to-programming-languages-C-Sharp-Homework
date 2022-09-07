// Задача* Написать функцию, которая принимает одно число - высоту 
//         елочки и рисует ее в консоли

void GetNums(int number)
{
    for (int i = 0; i < number; i++)
    {
        for (int p = number; p > i; p--)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i*2; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
Console.Write("Enter number A = ");
int A = int.Parse(Console.ReadLine());

GetNums(A);