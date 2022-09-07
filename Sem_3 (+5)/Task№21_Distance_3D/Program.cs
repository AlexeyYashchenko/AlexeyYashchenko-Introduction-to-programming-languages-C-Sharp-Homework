//Задача №21 Написать программу, которая принимает на вход координаты двух точек
//           и находит расстояние между ними в 3D пространстве 

Console.WriteLine("Enter X1 of point 1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y1 of point 1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Z1 of point 1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter X2 of point 2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y2 of point 2");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Z2 of point 2");
int z2 = int.Parse(Console.ReadLine());

double Distance = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
Console.WriteLine($"Растояние между точками = {Distance:f2}");