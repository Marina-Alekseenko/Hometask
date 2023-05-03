// // Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

int X = x2 - x1;
int Y = y2 - y1;
int Z = z2 - z1;
var result = Math.Round((Math.Sqrt(Math.Pow((X), 2) + Math.Pow((Y), 2) + Math.Pow((Z), 2))), 2);

Console.WriteLine($"расстояние между точками в 3D пространстве - {result}");