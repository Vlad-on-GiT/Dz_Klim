Console.WriteLine ("Введите число:  ");
int a = int.Parse (Console.ReadLine()!);

if ( a % 2 == 0)
{
    Console.WriteLine ($"Число {a} является четным");
}
else
{
    Console.WriteLine ($"Число {a} не является четным");
}