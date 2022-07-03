// Напишите программу, которая принимает на вход координаты 2х точек
// и находит расстояние между ними в 3Д пространстве.
// формула: d=\sqrt{(x1-x2)^2+(y1-y2)^2+(z1-z2)^2}.

System.Console.WriteLine("Введите координаты точки A через запятую:");
string A = Console.ReadLine();
var a1 = A.Split(',').Select(int.Parse).ToArray();

System.Console.WriteLine("Введите координаты точки B через запятую:");
string B = Console.ReadLine();
var b1 = B.Split(',').Select(int.Parse).ToArray();

double d = Math.Sqrt(Math.Pow(b1[0]-a1[0],2) + Math.Pow(b1[1]-a1[1],2) + Math.Pow(b1[2]-a1[2],2));
System.Console.WriteLine($"Расстояние между точками: {d}");