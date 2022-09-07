//6. Пользователь вводит координаты двух точек A и B на плоскости. Программа определяет, 
//какая из них дальше от начала координат.

Console.WriteLine("Введите A(X Y) И B(X Y), координаты вводятся через пробел");
string xy = Console.ReadLine()!;
string[] parts = xy.Split(' ');
int xa = int.Parse(parts[0]);
int ya = int.Parse(parts[1]);
int xb = int.Parse(parts[2]);
int yb = int.Parse(parts[3]);

double longA = Math.Sqrt((xa) * (xa) + (ya) * (ya));
double longB = Math.Sqrt((xb) * (xb) + (yb) * (yb));
if (longA > longB)
{
    Console.WriteLine($"Точка A на расстояни {Math.Round(longA, 2)} от начала координат, дальше чем точка B {Math.Round(longB, 2)} от начала координат");
}
else
{
    Console.WriteLine($"Точка B на расстояни {Math.Round(longB, 2)} от начала координат, дальше чем точка A {Math.Round(longA, 2)} от начала координат");
}