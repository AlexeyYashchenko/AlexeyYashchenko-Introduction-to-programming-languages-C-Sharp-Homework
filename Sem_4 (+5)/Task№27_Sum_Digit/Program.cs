// Задача №27: Написать функцию и запустить ее, которая принимает на вход число и
//             выдает сумму цифр в числе
int SumDig(int num)
{
    int sum = 0;
    while ( num > 0 )
    {
        int remainder = num%10;
        num = (num - remainder) / 10;
        sum = sum + remainder;
    }
    return sum;
}

Console.Write("Enter number A = ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine($"Sum of digits {numA} = {SumDig(numA)}");