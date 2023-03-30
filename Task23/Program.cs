/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear ();
Console.Write("Введите число N: ");
string strNumN = Console.ReadLine();
int numN = Convert.ToInt32(strNumN);
int count = 1;


Console.WriteLine($"Кубы чисел от 1 до {numN}:");
while (count <= numN)
{
    Console.Write($" {Math.Pow((count), 3)} ");
    count++;
}
Console.WriteLine();