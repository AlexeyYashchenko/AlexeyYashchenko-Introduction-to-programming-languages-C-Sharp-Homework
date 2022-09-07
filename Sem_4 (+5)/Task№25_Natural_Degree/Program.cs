// Задача №25: Написать цикл, который принимает на вход два числа (А и В)
//             возводит число А в натуральнуй степень В.(функцию возведения самостоятельно)
int NatDegree(int A, int B)
{
     int natdeg = 1;
     for (int i = 1; i <= B; i++ )
     {
        natdeg = natdeg * A;
     }
     return natdeg;
}

Console.Write("Enter number A = ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Enter number B = ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine($"Natural degree ({numB}) number {numA} = {NatDegree(numA,numB)}");