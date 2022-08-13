/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите xA");
double xA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите yA"); 
double yA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите zA");
double zA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите xB");
double xB = double.Parse(Console.ReadLine());
Console.WriteLine("Введите yB");
double yB = double.Parse(Console.ReadLine());
Console.WriteLine("Введите zB");
double zB  = double.Parse(Console.ReadLine());
double sqrtAB = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
Console.WriteLine(sqrtAB);      