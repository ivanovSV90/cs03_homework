// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите A(X Y Z) И B(X Y Z),  координаты вводятся через пробел");
string xy = Console.ReadLine()!;
string[] parts = xy.Split(' ');
int xa = int.Parse(parts[0]);
int ya = int.Parse(parts[1]);
int za = int.Parse(parts[2]);
int xb = int.Parse(parts[3]);
int yb = int.Parse(parts[4]);
int zb = int.Parse(parts[5]);

double long1 = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.WriteLine($"Длинна {Math.Round(long1, 2)}");