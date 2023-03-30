/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
Console.Write("Enter X1  ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Enter Y1  ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Enter Z1  ");
double Z1 = double.Parse(Console.ReadLine());
Console.Write("Enter X2  ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Enter Y2  ");
double Y2 = double.Parse(Console.ReadLine());
Console.Write("Enter Z2  ");
double Z2 = double.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));

Console.WriteLine($"Расстояние между точками равно: {AB}");
Console.WriteLine();
