Console.WriteLine ("Введите число №1");
int a = int.Parse (Console.ReadLine ()!);
Console.WriteLine ("Введите число №2");
int b = int.Parse (Console.ReadLine ()!);

if (a < b)
{
    Console.WriteLine ($"Число {b} больше, чем {a}");
}
else
{
    Console.WriteLine ($"Число {a} больше, чем {b}");
}