// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите для точки a координату x: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для точки a координату y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для точки a координату z: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите для точки b координату x: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для точки b координату y: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для точки b координату z: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(bx - ax,2) + Math.Pow(by - ay,2) + Math.Pow(bz - az,2));

distance = distance - distance % 0.01;

Console.Write($"\nDistance = {distance}");