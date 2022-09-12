// Задача №43: Написать программу, которая найдет точку пересечения двух прямых, заданных 
//           уравнениями у=k1*x+b1, у=k2*x+b2; значения b1,k1,b2 и k2 задаются пользователем.

double[,] values = new double[2, 2];

void EnteringValues()
{
    for (int i = 0; i < values.GetLength(0); i++)
    {
        for (int j = 0; j < values.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write($"Enter value k{i + 1}:");
            }
            else Console.Write($"Enter value b{i + 1}:");
            values[i, j] = int.Parse(Console.ReadLine());
        }
    }
}

double[] MethodIntersectionPoint(double[,] value)
{
    double[] intersecPoint = new double[2];
    intersecPoint[0] = (value[1, 1] - value[0, 1]) / (value[0, 0] - value[1, 0]);
    intersecPoint[1] = intersecPoint[0] * value[0, 0] + value[0, 1];
    return intersecPoint;
}
EnteringValues();
if (values[0, 0] == values[1, 0])
{
    Console.WriteLine("No intersection point. Lines are parallel");
}
else
{
double[] intersectionPoint = MethodIntersectionPoint(values);
Console.WriteLine($"Intersection point lines: {String.Join(";  ", intersectionPoint)}");
}